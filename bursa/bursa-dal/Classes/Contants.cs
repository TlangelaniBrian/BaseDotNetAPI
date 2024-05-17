using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bursa_dal.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace bursa_dal.Classes
{
    public class Contants
    {
        public class AcademicYearData
        {

            public static ReadOnlyCollection<AcademicYear> AcademicYearList { get; } = new ReadOnlyCollection<AcademicYear>(new[]
            {
                new AcademicYear
                {
                    Id = 1,
                    Period = AcademicPeriod.JanuaryToDecember,
                    Year = 2023,
                    InstitutionId = 1,
                },
                new AcademicYear
                {
                    Id = 2,
                    Period = AcademicPeriod.FebruaryToDecember,
                    Year = 2023,
                    InstitutionId = 1,                }
                }
            );
        }
        public class AllowanceTypeData
        {
            public const string travelAllowance = "Travel Allowance";
            public const string foodAllowance = "Food Allowance";
            public const string accommodationAllowance = "Accommodation Allowance";

            public static ReadOnlyCollection<AllowanceType> AllowanceTypeList { get; } = new ReadOnlyCollection<AllowanceType>(new[]
            {
                new AllowanceType
                {
                    Id = 1,
                    Name = travelAllowance
                },
                new AllowanceType
                {
                    Id = 2,
                    Name = foodAllowance
                },
                new AllowanceType
                {
                    Id = 3,
                    Name = accommodationAllowance
                }
            });
        }
        public class AllowanceData
        {

            public static ReadOnlyCollection<Allowance> AllowanceList { get; } = new ReadOnlyCollection<Allowance>(new[]
            {
                new Allowance
                {
                    Id = 1,
                    Name = AllowanceTypeData.travelAllowance,
                    AllowanceTypeId = 1,
                    Amount = 5000.00m,
                    BurseryId = 1,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Annually,
                    TotalNumberPayments = 1,
                    TotalNumberPaymentsMade = 0,
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 1),
                },
                new Allowance
                {
                    Id = 2,
                    Name = AllowanceTypeData.foodAllowance,
                    AllowanceTypeId = 2,
                    Amount = 13000.00m,
                    BurseryId = 1,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 12,
                    TotalNumberPaymentsMade = 0,
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 1),
                },
                new Allowance
                {
                    Id = 3,
                    Name = AllowanceTypeData.accommodationAllowance,
                    AllowanceTypeId = 3,
                    Amount = 45000.00m,
                    BurseryId = 1,
                    IsActive = true,
                    PaymentCycle = PaymentCycle.Monthly,
                    TotalNumberPayments = 12,
                    TotalNumberPaymentsMade = 0,
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 1),
                }
            });
        }
        public class BurseryData
        {
            public static ReadOnlyCollection<Bursery> BurseryList { get; } = new ReadOnlyCollection<Bursery>(new[]
               {
                new Bursery
                {
                    Id = 1,
                    OfficerId = 2,
                    Name = "NSFAS - Home",
                    TotalAmount = 63000,
                    IsActive = true,
                    Type = BurseryType.FullCost,
                    Allowances = new List<Allowance>
                    {
                        new Allowance
                        {
                            Id = 1,
                            Name = AllowanceTypeData.travelAllowance,
                            AllowanceTypeId = 1,
                            Amount = 5000.00m,
                            BurseryId = 1,
                            IsActive = true,
                            PaymentCycle = PaymentCycle.Annually,
                            TotalNumberPayments = 1,
                            TotalNumberPaymentsMade = 0,
                            StartDate = new DateTime(2023, 1, 1),
                            EndDate = new DateTime(2023, 12, 1),
                        },
                        new Allowance
                        {
                            Id = 2,
                            Name = AllowanceTypeData.foodAllowance,
                            AllowanceTypeId = 2,
                            Amount = 13000.00m,
                            BurseryId = 1,
                            IsActive = true,
                            PaymentCycle = PaymentCycle.Monthly,
                            TotalNumberPayments = 12,
                            TotalNumberPaymentsMade = 0,
                            StartDate = new DateTime(2023, 1, 1),
                            EndDate = new DateTime(2023, 12, 1),
                        },
                        new Allowance
                        {
                            Id = 3,
                            Name = AllowanceTypeData.accommodationAllowance,
                            AllowanceTypeId = 3,
                            Amount = 45000.00m,
                            BurseryId = 1,
                            IsActive = true,
                            PaymentCycle = PaymentCycle.Monthly,
                            TotalNumberPayments = 12,
                            TotalNumberPaymentsMade = 0,
                            StartDate = new DateTime(2023, 1, 1),
                            EndDate = new DateTime(2023, 12, 1),
                        }
                    }
                }
            });
        }
        public class FeatureData
        {
            public const string readWriteDeleteAction = "R-W-D";
            public const string readWriteAction = "R-W";
            public const string readAction = "R";

            public const string superAdminFeature = "all";
            public const string userFeature = "user";
            public const string burseryFeature = "bursery";
            public const string allowanceFeature = "allowance";
            public const string residencyFeature = "residency";
            public static ReadOnlyCollection<Feature> FeatureList { get; } = new ReadOnlyCollection<Feature>(new[]
            {
                new Feature
                {
                    Id = 1,
                    Name = superAdminFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = 2,
                    Name = userFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = 3,
                    Name = burseryFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = 4,
                    Name = allowanceFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                },
                new Feature
                {
                    Id = 5,
                    Name = residencyFeature,
                    IsActive = true,
                    Access = readWriteDeleteAction
                }
            });
        }
        public class InstitutionData
        {
            public static ReadOnlyCollection<Institution> InstitutionList { get; } = new ReadOnlyCollection<Institution>(new[]
            {
                new Institution
                {
                    Id = 1,
                    Name = "Univerity of Stellenbosch"
                }
            });
        }
        public class ResidenceData
        {
            public static ReadOnlyCollection<Residence> ResidenceList { get; } = new ReadOnlyCollection<Residence>(new[]
            {
                new Residence
                {
                    Id = 1,
                    Address = "4 Beech Close",
                    IsActive = true,
                    LivingArrangment = LivingArrangment.Home,
                    Location = ""
                }
            });
        }
        public class RoleData
        {
            public const string superAdminRole = "SuperAdmin";
            public const string officerRole = "Officer";
            public const string studentRole = "Student";
            public static ReadOnlyCollection<Role> RoleList { get; } = new ReadOnlyCollection<Role>(new[]
               {
                new Role
                {
                    Id = 1,
                    Name = superAdminRole,
                    Features = new List<Feature>
                    {
                        //new Feature
                        //{
                        //    Id = 1,
                        //    Name = FeatureData.superAdminFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //}
                    }
                },
                new Role
                {
                    Id = 2,
                    Name = officerRole,
                    Features = new List<Feature>
                    {
                        //new Feature
                        //{
                        //    Id = 2,
                        //    Name = FeatureData.userFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //},
                        //new Feature
                        //{
                        //    Id = 3,
                        //    Name = FeatureData.burseryFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //},
                        //new Feature
                        //{
                        //    Id = 4,
                        //    Name = FeatureData.allowanceFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //},
                        //new Feature
                        //{
                        //    Id = 5,
                        //    Name = FeatureData.residencyFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //}
                    }
                },
                new Role
                {
                    Id = 3,
                    Name = studentRole,
                    Features = new List<Feature>
                    {
                        //new Feature
                        //{
                        //    Id = 2,
                        //    Name = FeatureData.userFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //},
                        //new Feature
                        //{
                        //    Id = 3,
                        //    Name = FeatureData.burseryFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readAction
                        //},
                        //new Feature
                        //{
                        //    Id = 4,
                        //    Name = FeatureData.allowanceFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readAction
                        //},
                        //new Feature
                        //{
                        //    Id = 5,
                        //    Name = FeatureData.residencyFeature,
                        //    IsActive = true,
                        //    Access = FeatureData.readWriteDeleteAction
                        //}
                    }
                }
            });
        }
        public class UserData
        {
            public static ReadOnlyCollection<User> UserList { get; } = new ReadOnlyCollection<User>(new[]
            {
                new User
                {
                    Id = 1,
                    IsActive=true,
                    IDNumber ="9008122255089",
                    SaltIDNumber = "089",
                    HashIDNumber = "000",
                    Name = "Admin",
                    Surname = "Admin",
                    PhoneNumber = "0810000000",
                    DateOfBirth = DateTime.Parse("1993-02-27 15:20:30.0000000"),
                    Email = "mrbtmkhabela+1@gmail.com",
                    PersonnelId = "12253482",
                    RoleId = 1,
                    SaltPassword = "1231",
                    HashPassword = "6548"
                },
                new User
                {
                    Id = 2,
                    IsActive=true,
                    IDNumber ="9202018795089",
                    SaltIDNumber = "100",
                    HashIDNumber = "123",
                    Name = "Officer",
                    Surname = "Officer",
                    PhoneNumber = "081000001",
                    DateOfBirth = DateTime.Parse("1983-12-07 10:00:30.2000000"),
                    Email = "mrbtmkhabela+2@gmail.com",
                    PersonnelId = "202102095",
                    RoleId = 2,
                    SaltPassword = "1231",
                    HashPassword = "6548"
                },
                new User
                {
                    Id = 3,
                    IsActive=true,
                    SaltIDNumber = "102",
                    IDNumber ="2106098795089",
                    HashIDNumber = "235",
                    Name = "Student",
                    Surname = "Student",
                    PhoneNumber = "081000002",
                    DateOfBirth = DateTime.Parse("2003-06-17 05:00:30.0000000"),
                    Email = "mrbtmkhabela+3@gmail.com",
                    PersonnelId = "12253482",
                    RoleId = 3,
                    SaltPassword = "1231",
                    HashPassword = "6548"
                }
            });
        }
        public class PocketData
        {
            public static ReadOnlyCollection<Pocket> PocketList { get; } = new ReadOnlyCollection<Pocket>(new[]
              {
                new Pocket
                {
                    Id = 1,
                    Name = "Student - Home Residence Pocket",
                    BeneficiaryId = 3,
                    IsActive = true,
                    ResidenceId = 1
                }
            });
        }
        public enum PaymentCycle
        {
            Annually = 1,
            BiAnnually = 2,
            Monthly = 3
        }
        public enum AcademicPeriod
        {
            FebruaryToNovember = 10,
            FebruaryToDecember = 11,
            JanuaryToDecember = 12
        }
        public enum BurseryType
        {
            FullCost = 1,
            Capped = 2,
            Partial = 3
        }
        public enum LivingArrangment
        {
            Home = 0,
            PrivateResidence = 1,
            ResCatered = 2,
            ResNonCatered = 3
        }
    }

}
