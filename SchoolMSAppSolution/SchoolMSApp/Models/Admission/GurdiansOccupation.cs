using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Admission
{
    public class GurdiansOccupation
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Occupation name must be require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Occupation Name")]
        public string OccupationName { get; set; }
    }
}