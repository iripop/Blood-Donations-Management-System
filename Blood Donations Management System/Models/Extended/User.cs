using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blood_Donations_Management_System.Models
{
    [MetadataType(typeof(UserMetaData))]
     public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetaData
        {
            [DisplayName("First name")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
            public string FirstName { get; set; }

            [DisplayName("Last name")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
            public string LastName { get; set; }

            [DisplayName("Enter user email")]
            [DataType(DataType.EmailAddress)]
            [Required(AllowEmptyStrings =false,ErrorMessage = "This field is required")]
            public string EmailAddress { get; set; }

            [DisplayName("Password")]
            [DataType(DataType.Password)]
            [Required(AllowEmptyStrings =false,ErrorMessage = "This field is required")]
            [MinLength(6, ErrorMessage = "Minimum 6 charactrs Required")]
            public string Password { get; set; }

            [DisplayName("Confirm password")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Confirm password and password do not match")]
            [Required(AllowEmptyStrings =false,ErrorMessage = "This field is required")]
            public string ConfirmPassword { get; set; }

            [DisplayName("Phone number")]
            public string PhoneNumber { get; set; }

            public bool IsAdmin { get; set; }
        }

}