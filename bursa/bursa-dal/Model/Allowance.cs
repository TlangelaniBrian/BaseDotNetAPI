using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursa_dal.Classes.Contants;

namespace bursa_dal.Model
{
    public class Allowance
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }
        public decimal Amount { get; set; }
        public int TotalNumberPayments { get; set; }
        public int TotalNumberPaymentsMade { get; set; }
        public required string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PaymentCycle PaymentCycle { get; set; }

        [Display(Name = "AllowanceType")]
        public int AllowanceTypeId { get; set; }
        [ForeignKey("AllowanceTypeId")]
        public AllowanceType? AllowanceType { get; set; }

        // Foreign key property to link to the parent bursery
        [Display(Name = "Bursery")]
        public int BurseryId { get; set; }

        // Navigation property to allow retrieval of associated bursery
        [ForeignKey("BurseryId")]
        public Bursery? Bursery { get; set; }
    }
}
