﻿using System.Diagnostics;
using ImperaPlus.Application.Exceptions;
using ImperaPlus.Domain.Exceptions;
using ImperaPlus.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog.Fluent;

namespace ImperaPlus.Web.Filters
{
    public class ApiExceptionFilterAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var domainException = context.Exception as DomainException;
            if (domainException != null)
            {
                context.ExceptionHandled = true;
                context.Result = new BadRequestObjectResult(new ErrorResponse(domainException.ErrorCode.ToString(), domainException.Message));                
                return;
            }

            var applicationException = context.Exception as ApplicationException;
            if (applicationException != null)
            {
                context.ExceptionHandled = true;
                context.Result = new BadRequestObjectResult(new ErrorResponse(applicationException.ErrorCode.ToString(), applicationException.Message));               
                return;
            }

            // Exception could not be handled, should not happen
            if (context.Exception != null)
            {
#if DEBUG
                Debugger.Launch();
#endif

                Log.Fatal().Message(context.Exception.ToString()).Write();

                // Log exception
                Log.Fatal().Exception(context.Exception).Write();
            }
        }
    }
}