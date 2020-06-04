using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class ParkingSlotRepository : Repository<ParkingSlot>, IParkingSlotRepository
    {
        public ParkingSlotRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<ParkingSlot>> GetParkingSlots()
        {
            return await ParkingManagementContext.ParkingSlots.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}