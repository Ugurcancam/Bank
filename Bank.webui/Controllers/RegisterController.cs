using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bank.Dto.AppUserDtos;
using Bank.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bank.webui.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    NameSurname = appUserRegisterDto.NameSurname,
                    Email = appUserRegisterDto.Email,
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmEmail");
                }
            }
            return View();
        }
    }
}