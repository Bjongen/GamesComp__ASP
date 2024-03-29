﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesCompInterface;
using GamesCompInterface.Dtos;
using GamesCompLogic.Classes;

namespace GamesCompLogic.Classes
{
    public class Team
    {
        public int TeamId;
        public string TeamName;
        public int SkillRating;
        public int Wins;

        public List<Account> _accounts = new();

        public Team(string teamname, List<Account> accounts)
        {
            _accounts = accounts;
            TeamName = teamname;
            SkillRating = 0;
            Wins = 0;
        }

        public Team(TeamDto teamDto)
        {
            TeamId = teamDto.TeamId;
            TeamName = teamDto.TeamName;
            SkillRating = teamDto.SkillRating;
            Wins = teamDto.Wins;
            _accounts = new List<Account>();
        }

        public void SetWins(int wins)
        {
            Wins = wins;
        }

        public void SetSkillRating(int skillrating)
        {
            SkillRating = skillrating;
        }

        public TeamDto ToDto()
        {
            List<AccountDto> accountDtos = new();
            foreach(var account in _accounts)
            {
                accountDtos.Add(account.ToDto());
            }
            return new TeamDto { AccountDtos = accountDtos };
        }

        
    }
}
