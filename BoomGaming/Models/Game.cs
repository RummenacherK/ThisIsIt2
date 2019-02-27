using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoomGaming.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Platform { get; set; }
        public string GameName { get; set; }
        public string Mode { get; set; }
        public string GameDescription { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
