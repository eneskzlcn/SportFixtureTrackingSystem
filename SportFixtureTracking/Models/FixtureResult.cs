using System;
using System.Collections.Generic;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class FixtureResult
    {
        public int ResultId { get; set; }
        public int Fixture_Id { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? WinnerTeamId { get; set; }

        public virtual Fixture Fixture { get; set; }
        public virtual Team WinnerTeam { get; set; }
    }
}
