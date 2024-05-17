using System.ComponentModel.DataAnnotations;
using static bursa_dal.Classes.Contants;

namespace bursa_dal.Model
{
    public class Residence
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public LivingArrangment LivingArrangment { get; set; }
        public bool IsActive { get; set; }
        public string Location { get; set; }
    }
}
