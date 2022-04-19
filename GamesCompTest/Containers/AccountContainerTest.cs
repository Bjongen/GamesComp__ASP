using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesCompLogic.Containers;
using GamesCompLogic.Classes;
using System.Linq;
using System;

namespace GamesCompTest
{
    [TestClass]
    public class AccountContainerTest
    {
        [TestMethod]
        public void CreateArticleTest()
        {
            //arrange
            var container = new AccountContainer();
            var account1 = new Account(1, "User1", "Password", "Myemail@gmail.com", false);
            //act
            container.CreateAccount(account1);
            //assert
            Assert.IsTrue(container.GetAccounts().Contains(account1),"Account not found");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateDuplicateAccount()
        {
            //arrange
            var container = new AccountContainer();
            var account1 = new Account(1, "User1", "Password", "Myemail@gmail.com", false);
            container.CreateAccount(account1);
            //act
            container.CreateAccount(account1);
            //assert
            Assert.AreEqual(container.GetAccounts().Count, 1, "Account can not be duplicate");
        }

        [TestMethod]
        public void RemoveAccount()
        {
            //arrange
            var container = new AccountContainer();
            var account1 = new Account(1, "User1", "Password", "Myemail@gmail.com", false);
            container.CreateAccount(account1);
            //act
            container.DeleteAccount(account1);
            //assert
            Assert.IsFalse(container.GetAccounts().Contains(account1), "Still contains account");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingAccount()
        {
            //arrange
            var container = new AccountContainer();
            var account1 = new Account(1, "User1", "Password", "Myemail@gmail.com", false);
            //act
            container.DeleteAccount(account1);
            //assert
            Assert.AreEqual(container.GetAccounts().Count, 0);
        }
    }
}
