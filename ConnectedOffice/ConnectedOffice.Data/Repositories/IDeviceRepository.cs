using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Data.Repositories
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Device GetDeviceById(Guid? id);
        IEnumerable<Device> GetAllDevices();
        void AddDevice(Device entity);
        void RemoveDevice(Device entity);
        void UpdateDevice(Device entity);
    }
}
