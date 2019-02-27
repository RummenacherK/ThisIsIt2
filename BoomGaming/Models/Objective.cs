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
        public int? Value { get; set; }
        public int? Points { get; set; }

        public ICollection<GameAssignment> GameAssignments { get; set; }
    }
}
