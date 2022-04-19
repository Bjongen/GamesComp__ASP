using GamesCompLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesCompLogic.Helpers;

namespace GamesComp__ASP.Models
{
    public class AccountEditViewModel
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhonNumber { get; set; }
        public bool IsAdmin { get; set; }

        public void CreateAccount()
        {
            Account account = new(AccountID, Name, Password, Email, PhonNumber, IsAdmin);
            AccountCreatorViewModelHelper accountCreatorViewModelHelper = Toolbox.accountCreatorViewModelHelper;
            accountCreatorViewModelHelper.CreateAccount(account);
        }

    }
}
