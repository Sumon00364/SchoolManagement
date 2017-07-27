using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolMSApp.Models.Institutions;

namespace SchoolMSApp.Models.Admission
{
    public class StudentInformation
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Institution class name is require!")]
        [Display(Name = "Class")]
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }


        [Required(ErrorMessage = "Batch name is require!")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Batch Name")]
        public string Batch { get; set; }

       

        public string StudentId { get; set; }


        [Required(ErrorMessage = "Student name is require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }


        [Required(ErrorMessage ="Student picture must be require!")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Student Picture")]
        public byte[] StudentPicture { get; set; }
        

        /// <summary>
        /// ===---A student class roll create by a student result
        /// </summary>
        public int? ClassRoll { get; set; }


        [Required(ErrorMessage = "Group name is require!")]
        [Display(Name = "Group")]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }


        [Required(ErrorMessage = "Selection is require!")]
        [Display(Name = "Selection")]
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }


        [Required(ErrorMessage = "Shift is require!")]
        [Display(Name = "Shift")]
        public int ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public virtual Shift Shift { get; set; }


        [Required(ErrorMessage = "Phone number is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 14)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }


        [Required(ErrorMessage = "E-Mail address must be require!")]
        [StringLength(320, ErrorMessage = "The {0} mmust be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }


        [Required(ErrorMessage = "PSC GPA is require!")]
        [Range(2.00, 5.00, ErrorMessage = "The {0} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name = "GPA (PSC)")]
        public double GpaPasc { get; set; }


        [Required(ErrorMessage = "JSC GPA is require!")]
        [Range(2.00, 5.00, ErrorMessage = "The {0} must be at least {2}.")]
        [DataType(DataType.Text)]
        [Display(Name = "GPA (JSC)")]
        public double GpaJsc { get; set; }


        [Required(ErrorMessage = "Please select your gender.")]
        [DataType(DataType.Text)]
        public Gender Gender { get; set; }


        [Required(ErrorMessage = "Admission referance is require!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        [Display(Name = "Admission Referance")]
        public string AdmissionRef { get; set; }


        [Required(ErrorMessage = "Referance name is require!")]
        [StringLength(150, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [DataType(DataType.Text)]
        [Display(Name = "Referance Name")]
        public string ReferanceName { get; set; }


        [Required(ErrorMessage = "Discount is Require!")]
        public Discount Discount { get; set; }


        [Required(ErrorMessage = "Amount is require!")]
        [Range(0.00, 500.00, ErrorMessage = "The {0} must be  at least {2} Taka")]
        [DataType(DataType.Currency)]
        [Display(Name = "Discount Amount")]
        public double DiscountAmount { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Discount
    {
        Fixed,
        Percentange
    }
}