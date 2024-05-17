using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bursa_dal.Model
{
    public class Pocket
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [Display(Name = "Beneficiary")]
        public int BeneficiaryId { get; set; }
        [ForeignKey("BeneficiaryId")]
        public virtual User? Beneficiary { get; set; }

        [Display(Name = "Residence")]
        public int ResidenceId { get; set; }
        [ForeignKey("ResidenceId")]
        public virtual Residence? Residence { get; set; }
        public ICollection<Bursery>? Burseries { get; set; }
    }
}
