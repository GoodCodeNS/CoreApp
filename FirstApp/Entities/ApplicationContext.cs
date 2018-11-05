using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        // Many-To-Many relation between tables User and Skill
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSkill>()
            .HasKey(us => new { us.UserId, us.SkillId });

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.SkillId);
        }

    }
}
