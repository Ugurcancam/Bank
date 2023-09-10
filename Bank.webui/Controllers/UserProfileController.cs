using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bank.Dto.AppUserDtos;
using Bank.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bank.webui.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userValues = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto user = new AppUserEditDto();
            user.NameSurname = userValues.NameSurname; 
            user.Email = userValues.Email;
            user.PhoneNumber = userValues.PhoneNumber;
            user.City = userValues.City;
            user.District = userValues.District;
            user.ImageUrl = userValues.ImageUrl;
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto dto)
        {
            if(dto.Password == dto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.NameSurname = dto.NameSurname;
                user.Email = dto.Email;
                user.PhoneNumber = dto.PhoneNumber;
                user.City = dto.City;
                user.District = dto.District;
                user.ImageUrl = dto.ImageUrl;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, dto.Password);
                var result = await _userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }

    }
}