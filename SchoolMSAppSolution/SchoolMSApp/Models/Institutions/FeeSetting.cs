using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Institutions
{
    public class FeeSetting
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Class name is require!")]
        [Display(Name = "Class Name")]
        public int ClassNameId { get; set; }
        [ForeignKey("ClassNameId")]
        public virtual Classes ClassName { get; set; }


        [Required(ErrorMessage = "Monthly fee must be require!")]
        [Range(0.00, 100.00, ErrorMessage = "The {0} must be at least {2} taka.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Fees")]
        public double MonthlyFee { get; set; }


        [Required(ErrorMessage = "Effective date is require!")]
        [Range(typeof(DateTime), "01/01/2000", "01/01/3000")]
        [DataType(DataType.Date)]
        [Display(Name = "Effective Date")]
        public DateTime EffectiveDateTime { get; set; }
    }
}