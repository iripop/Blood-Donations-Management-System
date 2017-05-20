using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blood_Donations_Management_System.Models
{
	public class UserLogin
	{
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address required")]
        [DisplayName("Email address")]
        public string EmailAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }
    }
}