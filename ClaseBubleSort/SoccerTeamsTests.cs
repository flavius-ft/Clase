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
            SoccerTeamsRanking[] teamRank = new SoccerTeamsRanking[5];
            teamRank[0] = new SoccerTeamsRanking("team1", 30);
            teamRank[1] = new SoccerTeamsRanking("team2", 28);
            teamRank[2] = new SoccerTeamsRanking("team3", 27);
            teamRank[3] = new SoccerTeamsRanking("team4", 20);
            teamRank[4] = new SoccerTeamsRanking("team5", 18);
        }
    }
}
