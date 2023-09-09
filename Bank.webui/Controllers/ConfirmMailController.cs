using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bank.Entity;
using Bank.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bank.webui.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Mail);
            if(user.ConfirmCode == model.ConfirmCode){
                 
                return RedirectToAction("Index","UserProfile");
            }
            return View();

        }

    }
}