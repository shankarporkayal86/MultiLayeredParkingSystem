using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Parking.Domain.Core.Entities;
using Parking.Infrastructure.SQL;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RegisterRepository : Repository<Registers>, IRegisterRepository
    {
        public RegisterRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<Registers>> GetRegisters(int Id)
        {
            return await ParkingManagementContext.Registers.Where(n=>n.RegisterId == Id).ToListAsync();
        }

        public async Task<Registers> ValidateLogin(Registers LoginDetails)
        {
            return await ParkingManagementContext.Registers.Where(n => n.UserName == LoginDetails.UserName && n.Password == LoginDetails.Password).FirstOrDefaultAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}