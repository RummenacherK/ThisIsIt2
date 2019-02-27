using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoomGaming.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoomGaming.Models
{
    public class BoomGamingContext : IdentityDbContext<BoomGamingUser>
    {
        public BoomGamingContext(DbContextOptions<BoomGamingContext> options)
            : base(options)
        {
        }

        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<GameAssignment> GameAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<GameAssignment>()
                .HasKey(c => new { c.GameID, c.ObjectiveID });
        }
    }
}
