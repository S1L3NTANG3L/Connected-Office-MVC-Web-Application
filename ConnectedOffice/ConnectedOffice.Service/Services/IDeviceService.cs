using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Service.Services
{
    public interface IDeviceService
    {
        Device GetDeviceById(Guid? id);
        IEnumerable<Device> GetAllDevices();
        void AddDevice(Device entity);
        void RemoveDevice(Device entity);
        void UpdateDevice(Device entity);
    }
}
