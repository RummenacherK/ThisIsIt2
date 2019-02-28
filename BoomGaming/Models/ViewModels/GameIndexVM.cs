using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoomGaming.Models.ViewModels
{
    public class GameIndexVM
    {
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Objective> Objectives { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
