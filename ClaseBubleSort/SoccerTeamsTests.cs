using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClaseBubleSort
{
    public class SoccerTeamsTests
    {
        [Fact]
        public void TeamRanking()
        {
            SoccerTeams[] teamRank = new SoccerTeams[5];
            teamRank[0] = new SoccerTeams("team1", 30);
            teamRank[1] = new SoccerTeams("team2", 28);
            teamRank[2] = new SoccerTeams("team3", 27);
            teamRank[3] = new SoccerTeams("team4", 20);
            teamRank[4] = new SoccerTeams("team5", 18);
        }
    }
}
