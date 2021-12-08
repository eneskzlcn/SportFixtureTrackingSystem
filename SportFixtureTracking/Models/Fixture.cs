using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SportFixtureTracking.Models
{
    public partial class Fixture
    {
        public Fixture()
        {
            FixtureResults = new HashSet<FixtureResult>();
        }
       
        public int FixtureId { get; set; }

        [Required(ErrorMessage = "Date con not be empty")]
        public DateTime FixtureDate { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        [Required(ErrorMessage = "Home con not be empty")]
        [MaxLength(50,ErrorMessage = "Home shoukd be shorter than 50 character")]
        public string FixtureHome { get; set; }

        [StringLength(1,ErrorMessage ="Write N for Not Finished, Y For Finished")]
        public string IsFinished { get; set; }

        public virtual Team AwayTeam { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual ICollection<FixtureResult> FixtureResults { get; set; }
    }
}
