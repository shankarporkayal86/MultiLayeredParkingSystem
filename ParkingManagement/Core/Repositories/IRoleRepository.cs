﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement.Core.Model;


namespace ParkingManagement.Core.Repositories
{
    public interface IRoleRepository : IRepository<UserRoles>
    {
        Task<IEnumerable<UserRoles>> GetRoles();
    }
}
