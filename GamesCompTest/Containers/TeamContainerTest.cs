using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesCompLogic.Containers;
using GamesCompLogic.Classes;
using System.Linq;
using System;
using System.Collections.Generic;
using GamesCompLogic;

namespace GamesCompTest
{
    [TestClass]
    public class TeamContainerTest
    {
        [TestMethod]
        public void CreateTeamTest()
        {
            //arrange
            var container = new TeamContainer();
            List<Account> Members = new();
            var team1 = new Team("Team1", Members);
            //act
            container.CreateTeam(team1);
            //assert
            Assert.IsTrue(container.GetTeams().Contains(team1), "Team not found");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateDuplicateTeam()
        {
            //arrange
            var container = new TeamContainer();
            List<Account> Members = new();
            var team1 = new Team("Team1", Members);
            container.CreateTeam(team1);
            //act
            container.CreateTeam(team1);
            //assert
            Assert.AreEqual(container.GetTeams().Count, 1, "Team already exists");
        }

        [TestMethod]
        public void RemoveTeam()
        {
            //arrange
            var container = new TeamContainer();
            List<Account> Members = new();
            var team1 = new Team("Team1", Members);
            container.CreateTeam(team1);
            //act
            container.DeleteTeam(team1);
            //assert
            Assert.IsFalse(container.GetTeams().Contains(team1), "Still contains team");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingTeam()
        {
            //arrange
            var container = new TeamContainer();
            List<Account> Members = new();
            var team1 = new Team("Team", Members);
            //act
            container.DeleteTeam(team1);
            //assert
            Assert.AreEqual(container.GetTeams().Count, 0);
        }
    }
}
