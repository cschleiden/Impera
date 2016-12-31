﻿using System;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Hangfire;
using ImperaPlus.Application;
using ImperaPlus.Application.Jobs;
using ImperaPlus.DataAccess;
using ImperaPlus.Domain.Repositories;
using ImperaPlus.Web.Filters;
using ImperaPlus.Web.Providers;
using ImperaPlus.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;

namespace ImperaPlus.Web
{
    public class FormFilter : Swashbuckle.SwaggerGen.Generator.IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.OperationId.Contains("Token"))
            {
                operation.Consumes.Add("application/x-www-form-urlencoded");

                foreach(var parameter in operation.Parameters)
                {
                    parameter.In = "formData";
                }
            };

            string actionName = ((ControllerActionDescriptor)context.ApiDescription.ActionDescriptor).ActionName;
            operation.OperationId = $"{context.ApiDescription.GroupName}_{actionName}";
        }
    }

    public class Startup
    {
        /// <summary>
        /// Test support: Work on background threads
        /// </summary>
        public static bool StartHangfire = true;

        /// <summary>
        /// Test support: Require user confirmation
        /// </summary>
        internal static bool RequireUserConfirmation = true;        

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }

            this.Configuration = builder.Build();
            this.Environment = env;
        }

        public IConfigurationRoot Configuration { get; }
        public IHostingEnvironment Environment { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ImperaContext>(options =>
            {
                string connection = Configuration["DBConnection"];
                options.UseSqlServer(connection, b=> b.MigrationsAssembly("ImperaPlus.Web"));
            });

            services.AddCors(opts => opts.AddPolicy(
                opts.DefaultPolicyName,
                new CorsPolicy
                {
                    SupportsCredentials = false
                }));

            // Auth
            services.AddIdentity<Domain.User, IdentityRole>(options =>
                {
                    options.User.RequireUniqueEmail = true;

                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;

                    options.SignIn.RequireConfirmedEmail = true;
                    options.SignIn.RequireConfirmedPhoneNumber = false;

                    if (this.Environment.IsDevelopment())
                    {
                        options.SignIn.RequireConfirmedEmail = false;
                    }

                    // Ensure that we never redirect when user is not authorized, but only return 401 response
                    options.Cookies.ApplicationCookie.AutomaticAuthenticate = false;
                    options.Cookies.ApplicationCookie.AutomaticChallenge = false;
                    options.Cookies.ApplicationCookie.Events = new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents
                    {
                        OnRedirectToLogin = ctx =>
                        {
                            ctx.Response.StatusCode = (int)System.Net.HttpStatusCode.Unauthorized;
                            return Task.CompletedTask;
                        }
                    };
                })
                .AddEntityFrameworkStores<ImperaContext>()
                .AddDefaultTokenProviders();

            var openIddict = services.AddOpenIddict<ImperaContext>()
                .EnableTokenEndpoint("/api/Account/Token")
                .AllowPasswordFlow()
                .AllowRefreshTokenFlow();

            if (this.Environment.IsDevelopment())
            {
                openIddict
                    // During development, you can disable the HTTPS requirement.
                    .DisableHttpsRequirement()
                    .AddEphemeralSigningKey();
            }

            // Swagger
            //services.AddTransient<IApiDescriptionGroupCollectionProvider, ApiDescriptionGroupCollectionProvider>();
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<FormFilter>();
                options.DescribeStringEnumsInCamelCase();
                options.IncludeXmlComments(AppDomain.CurrentDomain.BaseDirectory + "ImperaPlus.Web.xml");
            });

            services.AddMvc(config =>
                {
                    config.Filters.Add(new CheckModelForNull());
                })
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                    opt.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                    opt.SerializerSettings.Converters.Add(new StringEnumConverter
                    {
                        CamelCaseText = false,
                        AllowIntegerValues = true
                    });
                    opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });

            // Set default authorization policy
            services.AddAuthorization(o =>
            {
                var builder = new AuthorizationPolicyBuilder();
                builder.AuthenticationSchemes.Add(AspNet.Security.OAuth.Validation.OAuthValidationDefaults.AuthenticationScheme);
                builder.RequireAuthenticatedUser();
                o.DefaultPolicy = builder.Build();
            });

            // Hangire
            services.AddHangfire(x =>
                x.UseNLogLogProvider()
                 .UseFilter(new JobExpirationTimeAttribute())
                 .UseSqlServerStorage(Configuration["DBConnection"]));

            services.AddSingleton(_ => new JsonSerializer
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                ContractResolver = new SignalRContractResolver()
            });

            services.AddSignalR(options => options.Hubs.EnableDetailedErrors = true);

            return this.RegisterDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory, 
            ImperaContext dbContext,
            DbSeed dbSeed)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            
            // Enable Cors
            app.UseCors(b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().DisallowCredentials().Build());

            // Auth
            app.UseIdentity();
            //app.UseFacebookAuthentication(new FacebookOptions
            //{
            //   ClientId = Configuration["Authentication:Facebook:ClientId"],
            //    AppId = Configuration["Authentication:Facebook:AppId"],
            //    AppSecret = Configuration["Authentication:Facebook:AppSecret"]                
            //});            
            app.UseOAuthValidation(options => {
                options.Events = new AspNet.Security.OAuth.Validation.OAuthValidationEvents
                {
                    // Note: for SignalR connections, the default Authorization header does not work,
                    // because the WebSockets JS API doesn't allow setting custom parameters.
                    // To work around this limitation, the access token is retrieved from the query string.
                    OnRetrieveToken = context => {
                        context.Token = context.Request.Query["bearer_token"];

                        return Task.FromResult(0);
                    }                    
                };
            });            
            app.UseOpenIddict();

            app.UseMvc();

            app.UseWebSockets();
            app.UseSignalR();

            app.UseSwagger();
            app.UseSwaggerUi();

            // Initialize database
            if (env.IsDevelopment())
            {
                // Always recreate in development
                //dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
            else
            {
                dbContext.Database.Migrate();
            }
                
            dbSeed.Seed(dbContext).Wait();

            AutoMapperConfig.Configure();

            // Hangfire
            app.UseHangfireServer(new BackgroundJobServerOptions
            {
                Queues = new[] { JobQueues.Critical, JobQueues.Normal },                
            });
            app.UseHangfireDashboard();

            Hangfire.Common.JobHelper.SetSerializerSettings(new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            // Configure Impera background jobs
            JobConfig.Configure();
        }

        private IServiceProvider RegisterDependencies(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var builder = new ContainerBuilder();

            // Messaging
            if (Environment.IsDevelopment())
            {
                builder.RegisterType<LocalEmailService>().AsImplementedInterfaces();
            }
            else
            {
                builder.RegisterType<MailGunEmailService>().AsImplementedInterfaces();
            }

            //builder.RegisterType<OopsExceptionHandler>().As<IExceptionHandler>();

            builder.RegisterType<ImperaContext>().As<DbContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<DbSeed>().AsSelf();

            // Register repositories
            //builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(GameRepository)))
            //    .Where(x => x.Name.EndsWith("Repository") && !x.IsInterface).As(x => x.GetInterfaces());

            builder.RegisterType<UserProvider>().As<IUserProvider>();

            // Register SignalR hubs
            //builder.RegisterHubs(Assembly.GetExecutingAssembly());

            // Register Domain services
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(IGameRepository)))
                .Where(x => x.Name.EndsWith("Service") && !x.IsInterface).As(x => x.GetInterfaces());

            // Notification
            builder.RegisterType<GamePushNotificationService>().AsImplementedInterfaces();
            builder.RegisterType<UserPushNotificationService>().AsImplementedInterfaces();

            var jsonSettings = new JsonSerializerSettings()
            {
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                ContractResolver = new SignalRContractResolver()
            };
            jsonSettings.Converters.Add(new StringEnumConverter
            {
                CamelCaseText = false,
                AllowIntegerValues = false
            });

            builder.RegisterInstance(JsonSerializer.Create(jsonSettings)).As<JsonSerializer>();

            builder.RegisterModule<Application.DependencyInjectionModule>();
            builder.RegisterModule<Domain.DependencyInjectionModule>();

            builder.RegisterType<BackgroundJobClient>().AsImplementedInterfaces();
            

            builder.Populate(services);

            IContainer container = null;
            container = builder.Build();            

            return container.Resolve<IServiceProvider>();
        }
    }
}
