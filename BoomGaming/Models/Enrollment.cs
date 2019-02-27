using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoomGaming.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoomGaming.Models
{
    public enum Rank
    {
        AAA, AA, A, B, C
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Rank")]
        public Rank? Rank { get; set; }

        public BoomGamingUser BoomGamingUser { get; set; }
        public Game Game { get; set; }
    }
}
