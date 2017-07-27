using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Discovery;

namespace SchoolMSApp.Models.Admission
{
    public class GardiansInformation
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Father's name is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }


        [Required(ErrorMessage = "Father's picture is require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Father's Picture")]
        public byte[] FatherPicture { get; set; }


        [Required(ErrorMessage = "Father's occupation is require!")]
        [Display(Name = "Father's Occupation")]
        public int FathersOccupationId { get; set; }
        [ForeignKey("FathersOccupationId")]
        public virtual FathersOccupation FathersOccupation { get; set; }


        [Required(ErrorMessage = "Father's phone numbewr is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 14)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Father's Phone No.")]
        public string FatherPhoneNo { get; set; }

        
        [StringLength(320, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Father's E-Mail")]
        public string FatherEmail { get; set; }


        [Required(ErrorMessage = "Mother's name is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; }


        [Required(ErrorMessage = "Mother's picture is require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Mother's Picture")]
        public byte[] MothersPicture { get; set; }


        [Required(ErrorMessage = "Mother's occupation is require!")]
        [Display(Name = "Mother's Occupation")]
        public int MothersOccupationId { get; set; }
        [ForeignKey("MothersOccupationId")]
        public virtual MotherOccupation MotherOccupation { get; set; } 


        [Required(ErrorMessage = "Mother's phone number is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} digits long.", MinimumLength = 14)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mother's Phone No.")]
        public string MotherPhoneNo { get; set; }


        [Required(ErrorMessage = "Mother's email address is require!")]
        [StringLength(320, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Mother's E-Mail")]
        public string MotherEmail { get; set; }


        [Required(ErrorMessage = "Gurdian's name is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Gurdian's Name")]
        public string GurdianName { get; set; }


        [Required(ErrorMessage = "Gurdian picture is require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Gurdian's Picture")]
        public byte[] GurdianPicture { get; set; }


        [Required(ErrorMessage = "Gurdian's occupation is require!")]
        [Display(Name = "Gurdian's Occupation")]
        public int GurdianOccupationId { get; set; }
        [ForeignKey("GurdianOccupationId")]
        public virtual GurdiansOccupation GurdiansOccupation { get; set; }


        [Required(ErrorMessage = "Gurdian's phone number is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} digits long.", MinimumLength = 14)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Gurdian's Phone No.")]
        public string GurdianPhoneNo { get; set; }


        [Required(ErrorMessage = "Gurdian's email address is require!")]
        [StringLength(320, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Gurdian's E-Mail")]
        public string GurdianEmail { get; set; }


        [Required(ErrorMessage = "Gurdian reletion is require!")]
        [Display(Name = "Gurdian's Reletion")]
        public Relation GurdiansRelation { get; set; }


        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 15)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; }


        [StringLength(200, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 15)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }
         
    }

    public enum Relation
    {
        Father,
        Mother,
        Uncle,
        Aunt,
        Brother,
        Sister, 
        GrandMother, 
        GrandFather
    }
}