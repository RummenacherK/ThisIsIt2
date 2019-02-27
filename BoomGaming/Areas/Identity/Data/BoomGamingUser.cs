using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BoomGaming.Models;

namespace BoomGaming.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the BoomGamingUser class
    public class BoomGamingUser : IdentityUser
    {
        [PersonalData]
        public string Tag { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
