using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesComp__ASP.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult CreateAccount()
        {
            return View();
        }
    }
}
