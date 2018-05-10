using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Models
{
    public class PortfolioDbContext : IdentityDbContext<ApplicationUser>
    {

        //public DbSet<BlogPost> BlogPosts { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<Comment> Comments { get; set; }

        public PortfolioDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity => {
                entity.Property(m => m.Email).HasMaxLength(127);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(127);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(127);
                entity.Property(m => m.UserName).HasMaxLength(127);
            });
            builder.Entity<IdentityRole>(entity => {
                entity.Property(m => m.Name).HasMaxLength(127); entity.Property(m => m.NormalizedName).HasMaxLength(127);
            });
        }

        public DbSet<Portfolio.Models.BlogPost> BlogPosts { get; set; }
        public DbSet<Portfolio.Models.ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Portfolio.Models.Comment> Comments { get; set; }
    }
}

