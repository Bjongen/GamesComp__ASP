using GamesCompLogic.Classes;
using GamesCompLogic.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesCompLogic.Helpers
{
    public class AccountCreatorViewModelHelper
    {
        public void CreateAccount(Account account)
        {
            AccountContainer accountContainer = Toolbox.AccountContainer;
            accountContainer.CreateAccount(account);
        }

        public void DeleteAccount(Account account)
        {
            AccountContainer accountContainer = Toolbox.AccountContainer;
            accountContainer.DeleteAccount(account);
        }
    }
}
