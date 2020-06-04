using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using System.Data.Entity;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class SlotRequestDetailsRepository : Repository<SlotRequestDeatils>, ISlotRequestDetailsRepository
    {
        public SlotRequestDetailsRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<SlotRequestDeatils>> GetSlotRequestDeatils()
        {
            return await ParkingManagementContext.SlotRequestDeatils
                .Include(c=>c.RequestDurationType)
                .Include(c=>c.Tower)
                .Include(c=>c.TowerBlock)
                .Include(c=>c.TowerBlock)
                .Include(c=>c.Registers)
                .ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}