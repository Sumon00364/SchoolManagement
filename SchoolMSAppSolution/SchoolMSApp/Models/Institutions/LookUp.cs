using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Institutions
{
    public class LookUp
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Look up group is require!")]
        [Display(Name = "Group")]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }


        [Required(ErrorMessage = "Look up shift is require!")]
        [Display(Name = "Shift")]
        public int ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public virtual Shift Shift { get; set; }


        [Required(ErrorMessage = "Look up section is require!")]
        [Display(Name = "Section")]
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }


        [Required(ErrorMessage = "Look up name must be require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Look Up Name")]
        public string LookUpName { get; set; }


        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 15)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}