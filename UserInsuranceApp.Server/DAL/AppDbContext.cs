using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserInsuranceApp.Server.Core.Models;

namespace UserInsuranceApp.Server.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO move connection string to appsettings.json
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=InsuranceDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<InsurancePolicy>().HasKey(i => i.ID);
        }
    }
}

