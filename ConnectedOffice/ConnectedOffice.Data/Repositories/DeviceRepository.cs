using ConnectedOffice.Data.Data;
using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedOffice.Data.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext connectedOfficeContext) : base(connectedOfficeContext)
        {
        }
        public Device GetDeviceById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.DeviceId == id);
        }
        public IEnumerable<Device> GetAllDevices()
        {
            return GetAll().ToList();
        }
        public void AddDevice(Device entity)
        {
            Add(entity);
        }
        public void RemoveDevice(Device entity)
        {
            Remove(entity);
        }
        public void UpdateDevice(Device entity)
        {
            Update(entity);
        }
    }
}
