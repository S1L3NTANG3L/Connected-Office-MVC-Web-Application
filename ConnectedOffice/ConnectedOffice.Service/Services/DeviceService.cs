using ConnectedOffice.Data.Models;
using ConnectedOffice.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedOffice.Service.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public void AddDevice(Device entity)
        {
            _deviceRepository.Add(entity);
        }

        public IEnumerable<Device> GetAllDevices()
        {
            return _deviceRepository.GetAll().ToList();
        }
        public Device GetDeviceById(Guid? id)
        {
            return _deviceRepository.GetAll().FirstOrDefault(x => x.DeviceId == id);
        }

        public void RemoveDevice(Device entity)
        {
            _deviceRepository.Remove(entity);
        }

        public void UpdateDevice(Device entity)
        {
            _deviceRepository.Update(entity);
        }
    }
}
