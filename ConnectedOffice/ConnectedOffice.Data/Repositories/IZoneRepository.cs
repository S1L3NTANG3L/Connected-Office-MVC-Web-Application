using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Data.Repositories
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetZoneById(Guid? id);
        IEnumerable<Zone> GetAllZones();
        void AddZone(Zone entity);
        void RemoveZone(Zone entity);
        void UpdateZone(Zone entity);
    }
}
