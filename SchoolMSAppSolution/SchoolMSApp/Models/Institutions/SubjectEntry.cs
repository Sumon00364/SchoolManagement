using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Institutions
{
    public class SubjectEntry
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Institution class name is require!")]
        [Display(Name = "Class")]
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }


        [Required(ErrorMessage = "Subject code is require!")]
        [StringLength(7, ErrorMessage = "The {0} must be a least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Subject Code")]
        public string SubjectCode { get; set; }


        [Required(ErrorMessage = "Subject name is require!")]
        [StringLength(30, ErrorMessage = "The {0} must be a least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }
    }
}