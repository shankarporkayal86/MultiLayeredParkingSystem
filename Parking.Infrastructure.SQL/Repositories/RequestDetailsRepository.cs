using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RequestDetailsRepository : Repository<RequestDetails>, IRequestDetailsRepository
    {
        public RequestDetailsRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<RequestDetails>> GetRequestDetails()
        {
            return await ParkingManagementContext.RequestDetails
                .Include(c=>c.RequestDurationType)
                .Include(c=>c.Registers).ToListAsync();
        }
        public async Task<IEnumerable<RequestDetails>> GetPatientsApi()
        {
            return await ParkingManagementContext.RequestDetails
                .Include(c => c.Registers)
                .Include(c=>c.RequestDurationType)
                .ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}