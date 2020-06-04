using System;
using Parking.Domain.Core.Repositories;

namespace Parking.Domain.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRegisterRepository Registers { get; }
        IRoleRepository UserRoles { get; }
        IRequestDuationTypeRepository RequestDuationTypes { get; }
        ITowerRepository Tower { get; }
        IParkingSlotRepository ParkingSlot { get; }
        IRequestDetailsRepository RequestDetails { get; }
        IParkingAllocationRepository ParkingAllocation { get; }
        ISurrenderHistoryRepository SurrenderHistory { get; }
        ITowerParkingSlotRepository TowerParkingSlot { get; }


        ITowerBlockRepository TowerBlock { get; }
        ITowerBlockSlotRepository TowerBlockSlot { get; }
        ISlotRequestDetailsRepository slotRequestDetails { get; }


        void Complete();
    }
}