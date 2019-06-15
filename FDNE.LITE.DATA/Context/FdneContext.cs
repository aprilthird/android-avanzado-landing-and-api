using FDNE.LITE.ENTITIES.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDNE.LITE.DATA.Context
{
    public class FdneContext : IdentityDbContext<ApplicationUser>
    {
        public FdneContext(DbContextOptions<FdneContext> options) : base(options) { }

        public DbSet<Binomial> Binomials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
