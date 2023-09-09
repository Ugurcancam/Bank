using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bank.webui.Controllers
{
    [Route("[controller]")]
    public class UserProfileController : Controller
    {
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(ILogger<UserProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}