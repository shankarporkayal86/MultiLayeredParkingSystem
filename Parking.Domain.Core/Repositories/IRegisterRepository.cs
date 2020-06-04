using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Parking.Domain.Core.Entities;

namespace Parking.Domain.Core.Repositories
{
    public interface IRegisterRepository : IRepository<Registers>
    {
        Task<IEnumerable<Registers>> GetRegisters(int Id);
        Task<Registers> ValidateLogin(Registers LoginDetails);
    }
}