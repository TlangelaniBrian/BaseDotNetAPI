using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static bursa_dal.Classes.Contants;

namespace bursa_dal.Model
{
    public class AcademicYear
    {
        public int Id { get; set; }
        public AcademicPeriod Period { get; set; }
        public int Year { get; set; }
        [Display(Name = "Institution")]
        public int InstitutionId { get; set; }
        [ForeignKey("InstitutionId")]
        public virtual Institution Institution { get; set; }
    }
}
