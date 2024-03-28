using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<InsurancePolicy>().HasKey(i => i.ID);
            modelBuilder.Entity<InsurancePolicy>()
                .Property(p => p.InsuranceAmount)
                .HasColumnType("decimal(20, 5)");

            modelBuilder.Entity<InsurancePolicy>()
                .HasOne(ad => ad.User)
                .WithMany(a => a.InsurancePolicies)
                .HasForeignKey(ad => ad.UserID);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TranslationDB;Trusted_Connection=True;");
        }
    }
}
