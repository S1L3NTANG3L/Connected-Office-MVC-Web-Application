using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Service.Services
{
    public interface IZoneService
    {
        Zone GetZoneById(Guid? id);
        IEnumerable<Zone> GetAllZones();
        void AddZone(Zone entity);
        void RemoveZone(Zone entity);
        void UpdateZone(Zone entity);
    }
}
