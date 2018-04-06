﻿using System;
using ImperaPlus.DataAccess.InMemory;
using ImperaPlus.Domain.Alliances;
using ImperaPlus.Domain.Repositories;
using ImperaPlus.Domain.Tests.Helper;
using ImperaPlus.TestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImperaPlus.Domain.Tests.Alliance
{
    [TestClass]
    public class AllianceServiceTests
    {
        private IUnitOfWork unitOfWork;
        private IAllianceService allianceService;

        [TestInitialize]
        public void Setup()
        {
            this.unitOfWork = InMemory.GetInMemoryUnitOfWork();
            this.allianceService = new AllianceService(this.unitOfWork, new TestRandomGen());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateAllianceShouldFail()
        {
            this.allianceService.Create(null, null, null);
        }

        [TestMethod]
        [ExpectedDomainException(ErrorCode.UserAlreadyInAlliance)]
        public void CreateAllianceWhenUserIsAlreadyAMember()
        {
            var user = TestUtils.CreateUser("TestUser");
            user.AllianceId = Guid.NewGuid();
            user.Alliance = new Alliances.Alliance("Test", "Test");

            this.allianceService.Create(user, "Test2", "Test");
        }

        [TestMethod]
        [ExpectedDomainException(ErrorCode.AllianceWithNameAlreadyExists)]
        public void CreateAllianceWithExistingNameDifferentCapitalization()
        {
            this.unitOfWork.Alliances.Add(new Alliances.Alliance("testAlliance", "test"));
            this.unitOfWork.Commit();

            var user = TestUtils.CreateUser("TestUser");
            this.allianceService.Create(user, "TestAlliance", "Test");
        }

        [TestMethod]
        [ExpectedDomainException(ErrorCode.AllianceWithNameAlreadyExists)]
        public void CreateAllianceWithExistingName()
        {
            this.unitOfWork.Alliances.Add(new Alliances.Alliance("testAlliance", "test"));
            this.unitOfWork.Commit();

            var user = TestUtils.CreateUser("TestUser");
            this.allianceService.Create(user, "testAlliance", "Test");
        }

        [TestMethod]
        public void DeleteAlliance()
        {
            var alliance = new Alliances.Alliance("testAlliance", "test");
            var admin = TestUtils.CreateUser("Admin");
            alliance.AddMember(admin);
            alliance.MakeAdmin(admin);
            this.unitOfWork.Alliances.Add(alliance);
            this.unitOfWork.Commit();
            
            this.allianceService.Delete(alliance.Id, admin);
            this.unitOfWork.Commit();

            Assert.IsNull(this.unitOfWork.Alliances.GetWithMembers(alliance.Id));
        }
    }
}
