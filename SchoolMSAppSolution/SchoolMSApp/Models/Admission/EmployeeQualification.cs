using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Admission
{
    public class EmployeeQualification
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Employee Qualification is require!")]
        [StringLength(50, ErrorMessage ="The {0} must be at least {2} characters long", MinimumLength =5)]
        [DataType(DataType.Text)]
        [Display(Name ="Employee Qualification")]
        public string EmployeeQualication { get; set; }
    }
}