using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class Club
    {
        public Club()
        {
            Teams = new HashSet<Team>();
        }

        public int ClubId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [MaxLength(50,ErrorMessage = "Club Name Must Be Shorter Than 50 character")]
        public string ClubName { get; set; }

        [MaxLength(50, ErrorMessage = "Club Name Must Be Shorter Than 50 character")]
        public string ClubDescription { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
