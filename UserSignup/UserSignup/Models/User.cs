using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(15,MinimumLength =5,ErrorMessage ="Username is between 5 and 15 characters long")]
        [RegularExpression("[^a-zA-z]", ErrorMessage ="Username must be contain only letters")]
        public string Username { get; set; }


        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }


        public string Password { get; set; }

        
        //add private userId field and property
        private static int userId=1;
        public int UserId{get; private set;}

        
        //datetime property
        private DateTime dateTime = DateTime.Now;
        public DateTime DateTime { get; private set; }


        //default constructor
        public User() {
            UserId = userId++;
            DateTime = dateTime;
        }

    }
}
