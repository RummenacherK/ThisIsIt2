using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoomGaming.Models
{
    public class Objective
    {
        public int ObjectiveID { get; set; }
        public string GameName { get; set; }
        public string Category { get; set; }
        public string ObjectiveName { get; set; }
        public int? ValueMin { get; set; }
        public int? ValueAvg { get; set; }
        public int? ValueMax { get; set; }
        public int? EarnedPoints { get; set; }
        public int? StolentPoints { get; set; }

        public ICollection<GameAssignment> GameAssignments { get; set; }
    }
}
