using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesComp__ASP.Models
{
    public class AccountModel
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
    }
}
