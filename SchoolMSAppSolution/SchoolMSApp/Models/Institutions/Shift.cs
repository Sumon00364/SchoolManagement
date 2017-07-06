using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMSApp.Models.Institutions
{
    public class Shift
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Class shift is require!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} character long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        [Display(Name = "Shift")]
        public string ShiftName { get; set; }
    }
}