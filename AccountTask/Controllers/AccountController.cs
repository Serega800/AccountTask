using AccountTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataBaseContext _dbContext;
        public AccountController(DataBaseContext dbContext)
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
        public async Task<IActionResult> AddAircraft(Account aircraft)
        {
            await _dbContext.Aircrafts.AddAsync(aircraft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAircraft(int aircraftId)
        {
            Account acft = await _dbContext.Aircrafts.FindAsync(aircraftId);
            return View(acft);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAircraft(Account aircraft)
        {
            _dbContext.Aircrafts.Update(aircraft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAircraft(int aircraftId)
        {
            Account acft = await _dbContext.Aircrafts.FindAsync(aircraftId);
            _dbContext.Aircrafts.Remove(acft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
