using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class TowerParkingSlotRepository : Repository<TowerParkingSlot>, ITowerParkingSlotRepository
    {
        public TowerParkingSlotRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<TowerParkingSlot>> GetTowerParkingSlots()
        {
            return await ParkingManagementContext.TowerParkingSlots
                .Include(c=>c.Tower)
                .Include(c=>c.ParkingSlot)
                .ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}