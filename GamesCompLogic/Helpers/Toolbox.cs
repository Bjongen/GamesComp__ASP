using GamesCompInterface.Interfaces;
using GamesCompLogic.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesCompLogic.Helpers
{
    public static class Toolbox
    {
        public static AccountContainer AccountContainer = new();
        public static DEBContainer DEBContainer = new(new IDEB());
        public static MatchContainer MatchContainer = new();
        public static PouleContainer PouleContainer = new();
        public static TeamContainer TeamContainer = new();
        public static TournamentContainer TournamentContainer = new();
        public static AccountCreatorViewModelHelper accountCreatorViewModelHelper = new();
    }
}
