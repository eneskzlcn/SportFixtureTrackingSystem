using System;
using System.Collections.Generic;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class Sport
    {
        public Sport()
        {
            Teams = new HashSet<Team>();
        }

        public int SportId { get; set; }
        public string SportName { get; set; }
        public string SportDescription { get; set; }
        public int RequiredTeamPlayerCount { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
