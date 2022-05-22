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
            return View(await _dbContext.Accounts.ToListAsync());
        }
        [HttpGet]
        public IActionResult AddAccount()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAccount(Account Account)
        {
            await _dbContext.Accounts.AddAsync(Account);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAccount(int AccountId)
        {
            Account acft = await _dbContext.Accounts.FindAsync(AccountId);
            return View(acft);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAccount(Account Account)
        {
            _dbContext.Accounts.Update(Account);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAccount(int AccountId)
        {
            Account acft = await _dbContext.Accounts.FindAsync(AccountId);
            _dbContext.Accounts.Remove(acft);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
