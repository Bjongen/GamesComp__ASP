using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesCompLogic.Containers;
using GamesCompLogic.Classes;
using System.Linq;
using System;
using System.Collections.Generic;

namespace GamesCompTest
{
    [TestClass]
    class DEBContainerTest
    {
        [TestMethod]
        public void CreateDEB()
        {
            //arrange
            var DAL = new DEBStub();
            var container = new DEBContainer(DAL);
            var team = new Team("Team5", new List<Account>());
            var match = new Match(team, DateTime.Now);
            var deb = new DEB("DEBGrandFinal", match);
            //act
            container.CreateDEB(deb);
            //assert
            Assert.AreEqual(container.GetDEBs().Count(), 1);
        }
    }
}
