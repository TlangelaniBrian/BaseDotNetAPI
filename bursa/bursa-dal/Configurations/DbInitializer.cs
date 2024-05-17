using Microsoft.EntityFrameworkCore;
using bursa_dal.Model;
using static bursa_dal.Classes.Contants;

namespace bursa_dal.Configurations
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            //Seed Institution
            foreach (var institution in InstitutionData.InstitutionList)
            {
                modelBuilder.Entity<Institution>().HasData(institution);
            }

            //Seed Academic Year
            foreach (var academicYear in AcademicYearData.AcademicYearList)
            {
                modelBuilder.Entity<AcademicYear>().HasData(academicYear);
            }

            //Seed Allowance Type
            foreach (var allowanceType in AllowanceTypeData.AllowanceTypeList)
            {
                modelBuilder.Entity<AllowanceType>().HasData(allowanceType);
            }

            //Seed Allowance
            foreach (var allowance in AllowanceData.AllowanceList)
            {
                modelBuilder.Entity<Allowance>().HasData(allowance);
            }

            foreach (var bursery in BurseryData.BurseryList)
            {
                modelBuilder.Entity<Bursery>().HasData(bursery);
            }

            foreach (var feature in FeatureData.FeatureList)
            {
                modelBuilder.Entity<Feature>().HasData(feature);
            }

            foreach (var role in RoleData.RoleList)
            {
                modelBuilder.Entity<Role>().HasData(role);
            }

            foreach (var residence in ResidenceData.ResidenceList)
            {
                modelBuilder.Entity<Residence>().HasData(residence);
            }

            foreach (var user in UserData.UserList)
            {
                modelBuilder.Entity<User>().HasData(user);
            }
            foreach (var pocket in PocketData.PocketList)
            {
                modelBuilder.Entity<Pocket>().HasData(pocket);
            }
        }
    }
}
