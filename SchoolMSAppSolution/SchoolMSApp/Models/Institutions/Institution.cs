using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Institutions
{
    public class Institution
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Institution name must be required!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 15)]
        [DataType(DataType.Text)]
        [Display(Name = "Institution Name")]
        public string InstitutionName { get; set; }


        [Required(ErrorMessage = "Institution short name is require!")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Short Name")]
        public string InstitutionShortName { get; set; }


        [Required(ErrorMessage = "The Watchword is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Slogan")]
        public string Slogan { get; set; }


        [Required(ErrorMessage = "Institution address must be require!")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Institution Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Institution EIIN code must be require!")]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2}.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Institution EIIN NO.")]
        public string IntitutionEiinCode { get; set; }


        [Required(ErrorMessage = "Institution logo must be require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Institution Logo")]
        public byte[] InstitutionLogo { get; set; }


        [Required(ErrorMessage = "Institution established year must be require!")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2}.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Established Year")]
        public string EstablishedYear { get; set; }
    }
}