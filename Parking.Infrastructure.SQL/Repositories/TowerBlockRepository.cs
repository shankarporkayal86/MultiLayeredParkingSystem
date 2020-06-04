using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using System.Data.Entity;
using Parking.Infrastructure.SQL;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class TowerBlockRepository : Repository<TowerBlock>, ITowerBlockRepository
    {
        public TowerBlockRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<TowerBlock>> GetTowerBlocks()
        {
            return await ParkingManagementContext.TowerBlocks.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}