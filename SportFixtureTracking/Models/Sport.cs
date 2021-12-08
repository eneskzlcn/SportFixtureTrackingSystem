using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Sport Name Can Not Be Empty")]
        public string SportName { get; set; }

        [MaxLength(50,ErrorMessage = "Sport Description Can Not Be Longer Than 50 Character")]
        public string SportDescription { get; set; }
        
        [Required(ErrorMessage = "Team Player Count Can Not Be Empty")]
        [Range(1, 20, ErrorMessage = "Player Count must be between 1 and 20")]
        public int RequiredTeamPlayerCount { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
