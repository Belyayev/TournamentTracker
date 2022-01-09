using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //Order our list randomly of teams
        //Check if it is big enough - if not, add in bytes 2^4
        //Create our first round of matchups
        //Create every found after that - 8 matchups, 4 ... etc. 1 matchup

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RanomizeTeamOrder(model.EnteredTeams);
        }

        private static List<TeamModel> RanomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
