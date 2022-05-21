using acftApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acftApplication.Controllers
{
    public class AircraftController : Controller
    {
        private readonly DataBaseContext _dbContext;
        public AircraftController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Aircrafts.ToListAsync());
        }
        [HttpGet]
        public IActionResult AddAircraft()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAircraft(Aircraft acft)
        {
            await _dbContext.Aircrafts.AddAsync(acft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAircraft(int acftId)
        {
            Aircraft acft = await _dbContext.Aircrafts.FindAsync(acftId);
            return View(acft);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAircraft(Aircraft acft)
        {
            _dbContext.Aircrafts.Update(acft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
