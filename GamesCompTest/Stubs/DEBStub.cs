using GamesCompInterface.Interfaces;
using GamesCompLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesCompTest
{
    class DEBStub : IDEB
    {
        public List<DEB> _debs;

        public DEBStub()
        {
            var team = new Team("Team1", new List<Account>());
            var match = new Match(team, DateTime.Now);
            var deb = new DEB("DEBFinal", match);
            _debs.Add(deb);

            team = new Team("Team2", new List<Account>());
            match = new Match(team, DateTime.Now);
            deb = new DEB("DEBFinal2", match);
            _debs.Add(deb);
        }
    }
}
