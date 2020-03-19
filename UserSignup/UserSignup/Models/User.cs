using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
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
