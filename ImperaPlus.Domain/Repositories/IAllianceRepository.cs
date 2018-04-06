﻿using System;
using System.Collections.Generic;
using ImperaPlus.Domain.Alliances;

namespace ImperaPlus.Domain.Repositories
{
    public interface IAllianceRepository : IGenericRepository<Alliance>
    {
        IEnumerable<Alliance> GetAll();

        Alliance GetWithMembers(Guid allianceId);

        Alliance FindByName(string name);      
    }
}
