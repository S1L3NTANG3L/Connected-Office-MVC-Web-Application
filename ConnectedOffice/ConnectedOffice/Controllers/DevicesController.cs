using ConnectedOffice.Data.Models;
using ConnectedOffice.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace ConnectedOffice.Controllers
{
    [Authorize]
    public class DevicesController : Controller
    {
        private readonly IDeviceService _deviceService;
        private readonly IZoneService _zoneService;
        private readonly ICategoryService _categoryService;
        public DevicesController(IDeviceService deviceService, IZoneService zoneService, ICategoryService categoryService)
        {
            _zoneService = zoneService;
            _deviceService = deviceService;
            _categoryService = categoryService;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAllCategorys(), "CategoryId", "CategoryName");
            ViewData["ZoneId"] = new SelectList(_zoneService.GetAllZones(), "ZoneId", "ZoneName");
            return View(_deviceService.GetAllDevices().ToList());
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAllCategorys(), "CategoryId", "CategoryName");
            ViewData["ZoneId"] = new SelectList(_zoneService.GetAllZones(), "ZoneId", "ZoneName");
            var device = _deviceService.GetDeviceById(id);
            if (device == null)
            {
                return NotFound();
            }
            return View(device);
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAllCategorys(), "CategoryId", "CategoryName");
            ViewData["ZoneId"] = new SelectList(_zoneService.GetAllZones(), "ZoneId", "ZoneName");
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            device.DateCreated = DateTime.Now;
            device.DeviceId = Guid.NewGuid();
            _deviceService.AddDevice(device);
            return RedirectToAction("Index");
        }

        // GET: Devices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = _deviceService.GetDeviceById(id);
            if (device == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryService.GetAllCategorys(), "CategoryId", "CategoryName");
            ViewData["ZoneId"] = new SelectList(_zoneService.GetAllZones(), "ZoneId", "ZoneName");
            return View(device);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            if (id != device.DeviceId)
            {
                return NotFound();
            }
            try
            {
                _deviceService.UpdateDevice(device);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(device.DeviceId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var device = _deviceService.GetDeviceById(id);
            if (device == null)
            {
                return NotFound();
            }
            return View(device);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var device = _deviceService.GetDeviceById(id);
            _deviceService.RemoveDevice(device);
            return RedirectToAction("Index");
        }

        private bool DeviceExists(Guid id)
        {
            return _deviceService.GetDeviceById(id) != null;
        }
    }
}
