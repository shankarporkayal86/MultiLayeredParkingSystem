using System.Collections.Generic;
using System.Data.Entity;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RequestDuationTypeRepository : Repository<RequestDurationType>, IRequestDuationTypeRepository
    {
        public RequestDuationTypeRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<RequestDurationType>> GetRequestDurationType()
        {
            return await ParkingManagementContext.RequestDurationTypes.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}