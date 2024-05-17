using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursa_dal.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string IDNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PersonnelId { get; set; }
        public string? HashIDNumber { get; set; }
        public string? SaltIDNumber { get; set; }
        public string SaltPassword { get; set; }
        public string HashPassword { get; set; }
        [Display(Name = "Role")]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
