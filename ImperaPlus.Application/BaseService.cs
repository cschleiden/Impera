﻿using ImperaPlus.Domain;
using ImperaPlus.Domain.Repositories;

namespace ImperaPlus.Application
{
    public class BaseService
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IUserProvider userProvider;

        private Domain.User currentUser;

        public BaseService(IUnitOfWork unitOfWork, IUserProvider userProvider)
        {
            this.UnitOfWork = unitOfWork;
            this.userProvider = userProvider;
        }       

        protected User CurrentUser
        {
            get
            {
                return this.currentUser ?? (this.currentUser = this.UnitOfWork.Users.FindById(this.userProvider.GetCurrentUserId()));
            }
        }

        protected void CheckAdmin()
        {            
            if (!this.userProvider.IsAdmin())
            {
                throw new Exceptions.ApplicationException(
                    "User has to be admin to perform this action",
                    ErrorCode.UserIsNotAllowedToPerformAction);
            }
        }
    }
}