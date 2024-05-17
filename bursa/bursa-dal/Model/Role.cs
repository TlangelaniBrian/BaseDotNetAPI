using System.ComponentModel.DataAnnotations;

namespace bursa_dal.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Feature>? Features { get; set; }
    }
}
