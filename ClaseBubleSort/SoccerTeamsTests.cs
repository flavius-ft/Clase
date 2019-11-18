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
            Ranking ranking = new Ranking();
            ranking.Add(new Team("a", 30));

            Assert.Equal(1, ranking.Position("a"));
        }
    }
}
