using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoomGaming.Models
{
    public class GameAssignment
    {
        public int ObjectiveID { get; set; }
        public int GameID { get; set; }
        public Objective Objective { get; set; }
        public Game Game { get; set; }
    }
}
