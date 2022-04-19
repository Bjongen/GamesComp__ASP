using GamesCompLogic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesComp__ASP.Models
{
    public class AccountViewModel
    {
        public List<AccountModel> _accountModels = new();

        public void GetAccountModels()
        {
            _accountModels.Clear();
            var accounts = Toolbox.AccountContainer.GetAccounts();
            foreach (var account in accounts)
            {
                _accountModels.Add(new AccountModel()
                {
                    AccountId = account.AccountId,
                    Name = account.Name,
                    Password = account.Password,
                    Email = account.Email,
                    PhoneNumber = account.PhoneNumber,
                    IsAdmin = account.IsAdmin
                });
            }
        }


    }
}
