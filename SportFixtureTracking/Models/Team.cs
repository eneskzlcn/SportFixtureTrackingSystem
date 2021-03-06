using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class Team
    {
        public Team()
        {
            FixtureAwayTeams = new HashSet<Fixture>();
            FixtureHomeTeams = new HashSet<Fixture>();
            FixtureResults = new HashSet<FixtureResult>();
        }

        public int TeamId { get; set; }
        public int ClubId { get; set; }
        public int SportId { get; set; }
        [Required(ErrorMessage ="Team Name Can Not Be Empty")]
        [MaxLength(20,ErrorMessage = "Team Name Can Not Be Empty")]
        public string TeamName { get; set; }
        public int PlayerCount { get; set; }

        public virtual Club Club { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual ICollection<Fixture> FixtureAwayTeams { get; set; }
        public virtual ICollection<Fixture> FixtureHomeTeams { get; set; }
        public virtual ICollection<FixtureResult> FixtureResults { get; set; }
    }
}
