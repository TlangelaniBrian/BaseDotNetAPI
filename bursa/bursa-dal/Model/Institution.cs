using System.ComponentModel.DataAnnotations;

namespace bursa_dal.Model
{
    public class Institution
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
