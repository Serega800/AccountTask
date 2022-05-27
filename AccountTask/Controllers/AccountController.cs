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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAccount(Account account)
        {
            await _dbContext.Accounts.AddAsync(account);
            await _dbContext.SaveChangesAsync();
            TempData["success"] = "ЛС добавлен успешно";
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAccount(int accountId)
        {
            Account account = await _dbContext.Accounts.FindAsync(accountId);
            return View(account);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAccount(Account account)
        {
            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> CloseAccount(int accountId)
        {

            Account account = await _dbContext.Accounts.FindAsync(accountId);
            if(account.IsActive == 0)
            {
                return RedirectToAction(nameof(Index));
            }
            account.IsActive = 0;
            account.ClosingDate = DateTime.Now.Date;            
            await _dbContext.SaveChangesAsync();
            TempData["success"] = "ЛС закрыт успешно"; 
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //public async Task<IActionResult> DeleteAccount(int accountId)
        //{
        //    Account account = await _dbContext.Accounts.FindAsync(accountId);
        //    _dbContext.Accounts.Remove(account);
        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpGet]
        public async Task<IActionResult> ShowDetailsOfAccount(int accountId)
        {
            Account account = await _dbContext.Accounts.FindAsync(accountId);
            return View(account);
        }

        #region APICalls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _dbContext.Accounts.ToListAsync() });
        }

        [HttpPost]
        public async Task<IActionResult> Close(int id)
        {
            var accountFromDB = await _dbContext.Accounts.FirstOrDefaultAsync(u => u.Id == id);
            if (accountFromDB.IsActive == 0)
            {
                return Json(new { success = false, message = "Ошибка во время закрытия" });
            }
            accountFromDB.IsActive = 0;
            accountFromDB.ClosingDate = DateTime.Now.Date;
            await _dbContext.SaveChangesAsync();
            return Json(new { success = true, message = "Закрытие ЛС завершено успешно" });            
        }
        #endregion
    }
}
