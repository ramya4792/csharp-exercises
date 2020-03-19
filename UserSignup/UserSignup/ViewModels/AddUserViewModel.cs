using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        //UserName
        [Required]
        public string UserName { get; set; }

        //Email
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Password
        [Required]
        [MinLength(6,ErrorMessage ="Password is atleast 6 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //verify password
        [Required]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name ="Verify Password")]
        public string VerifyPassword { get; set;}

    }
}
