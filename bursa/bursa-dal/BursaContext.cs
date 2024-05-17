using Microsoft.EntityFrameworkCore;
using bursa_dal.Configurations;
using bursa_dal.Model;

namespace bursa_dal
{
    public class BursaContext : DbContext
    {
        public BursaContext(DbContextOptions options) : base(options)
        { }

        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<AllowanceType> AllowanceTypes { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<Bursery> Burseries { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Pocket> Pockets { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
