using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class TowerRepository : Repository<Tower>, ITowerRepository
    {
        public TowerRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<Tower>> GetTowers()
        {
            return await ParkingManagementContext.Towers.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}