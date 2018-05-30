using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }

    }

    public class UserMetadata
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Minimum 6 characters requried")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }

    }
}