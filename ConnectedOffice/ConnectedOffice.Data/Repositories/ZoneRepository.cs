using ConnectedOffice.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Zone = ConnectedOffice.Data.Models.Zone;

namespace ConnectedOffice.Data.Repositories
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext connectedOfficeContext) : base(connectedOfficeContext)
        {
        }
        public Zone GetZoneById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ZoneId == id);
        }
        public IEnumerable<Zone> GetAllZones()
        {
            return GetAll().ToList();
        }
        public void AddZone(Zone entity)
        {
            Add(entity);
        }
        public void RemoveZone(Zone entity)
        {
            Remove(entity);
        }
        public void UpdateZone(Zone entity)
        {
            Update(entity);
        }
    }
}
