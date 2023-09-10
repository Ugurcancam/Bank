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
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager,UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password,false,true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if(user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "UserProfile");
                }
            }
            return View();
        }

    }
}