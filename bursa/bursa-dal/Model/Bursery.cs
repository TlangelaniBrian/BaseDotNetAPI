using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static bursa_dal.Classes.Contants;

namespace bursa_dal.Model
{
    public class Bursery
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public decimal TotalAmount { get; set; }
        public string Name { get; set; }
        [Display(Name = "Officer")]
        public int OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        public virtual User? Officer { get; set; }
        public BurseryType Type { get; set; }
        // Navigation property to allow retrieval of associated allowances
        public ICollection<Allowance>? Allowances { get; set; }
    }
}