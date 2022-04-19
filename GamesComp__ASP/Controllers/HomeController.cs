using GamesComp__ASP.Models;
using GamesCompInterface.Dtos;
using GamesCompLogic.Classes;
using GamesCompLogic.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesComp__ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Account()
        {
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.GetAccountModels();
            return View(accountViewModel);
        }


        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAccount(AccountModel model)
        {
            Toolbox.AccountContainer.CreateAccount(new Account(new AccountDto()
            {
                AccountId = model.AccountId,
                Name = model.Name,
                Password = model.Password,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                IsAdmin = model.IsAdmin
            }));

            return RedirectToAction("CreateAccount", "Home");
        }
    }
}
