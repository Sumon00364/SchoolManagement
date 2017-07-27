using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Admission
{
    public class AdminitrativeInformation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminitrativeId { get; set; }
        

        [Required(ErrorMessage ="Adminitrative Employee name is require!")]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =5)]
        [DataType(DataType.Text)]
        [Display(Name ="Adminitrative Employee Name")]
        public string AdminitrativeName { get; set; }


        [StringLength(20, ErrorMessage ="The {0} must be ta least {2} characters long.", MinimumLength =3)]
        [DataType(DataType.Text)]
        [Display(Name ="Short or Nick Name")]
        public string ShortName { get; set; }


        [Required(ErrorMessage ="Employee phone number must be require!")]
        [StringLength(20, ErrorMessage ="The {0} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name ="Employee Phone Number")]
        public string Cell { get; set; }


        [Required(ErrorMessage ="Alternative Phone Number is require!")]
        [StringLength(20, ErrorMessage ="The {2} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name ="Alternative Phone Number")]
        public string AlterNativeCell { get; set; }


        [Required(ErrorMessage ="E-Mail address number is require!")]
        [StringLength(320, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="E-Mail")]
        public string Email { get; set; }


        [Required(ErrorMessage ="Employee picture is require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Employee Image")]
        public byte[] AdminitrativeImage { get; set; }


        [Required(ErrorMessage ="Last Qualification is require!")]
        [Display(Name ="Last Qualification")]
        public int LastQualification { get; set; }
        [ForeignKey("LastQualification")]
        public virtual EmployeeQualification EmployeeQualification { get; set; }


        [StringLength(50, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name ="Extra Qualification")]
        public string ExtraQualication { get; set; }


        [Required(ErrorMessage ="Experience years is require!")]
        [Range(20.00, 0.00, ErrorMessage ="The {0} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name ="Experience Year")]
        public double ExperienceYears { get; set; }


        [Required(ErrorMessage ="Please select your gender!")]
        [DataType(DataType.Text)]
        [Display(Name ="Gender")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage ="Present address is require!")]
        [StringLength(200, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =15)]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Present Address")]
        public string PresentAddress { get; set; }


        [Required(ErrorMessage ="Permanent address is require!")]
        [StringLength(200, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =20)]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Permanemt Address")]
        public string PermanentAddress { get; set; }


        [Required(ErrorMessage ="Joining Date is require!")]
        [DataType(DataType.Date)]
        [Display(Name ="Joining Date")]
        public DateTime JoiningName { get; set; }


        [Required(ErrorMessage ="Please select your reference")]
        [DataType(DataType.Text)]
        [Display(Name ="Reference")]
        public Reference Reference { get; set; }


        [Required(ErrorMessage ="Please upload your CV")]
        [DataType(DataType.Upload)]
        [Display(Name ="Adminitrative Employee CV")]
        public byte[] AdminitrativeCV { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum Reference
    {
        Father,
        Mother,
        Uncle,
        Unti,
        GrandFather,
        GrandMother,
        Others 
    }
}