using ConnectedOffice.Data.Models;
using ConnectedOffice.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedOffice.Service.Services
{
    public class ZoneService : IZoneService
    {
        private readonly IZoneRepository _zoneRepository;
        public ZoneService(IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
        }

        public void AddZone(Zone entity)
        {
            _zoneRepository.Add(entity);
        }

        public IEnumerable<Zone> GetAllZones()
        {
            return _zoneRepository.GetAll().ToList();
        }

        public Zone GetZoneById(Guid? id)
        {
            return _zoneRepository.GetAll().FirstOrDefault(x => x.ZoneId == id);
        }

        public void RemoveZone(Zone entity)
        {
            _zoneRepository.Remove(entity);
        }

        public void UpdateZone(Zone entity)
        {
            _zoneRepository.Update(entity);
        }
    }
}
