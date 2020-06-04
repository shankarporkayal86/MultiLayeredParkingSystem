using System.Collections.Generic;
using System.Data.Entity;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RoleRepository : Repository<UserRoles>, IRoleRepository
    {
        public RoleRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<UserRoles>> GetRoles()
        {
            return await ParkingManagementContext.UserRoles.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}