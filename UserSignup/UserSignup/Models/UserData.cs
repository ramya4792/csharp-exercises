using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();
        //Add method
        public static void Add(User newUser)
        {
            users.Add(newUser);
        }

        //Get all method
        public static List<User> GetAll()
        {
            return users;
        }
       
        //Get by id method
        public static User GetById(int id)
        {
            return users.Single(x => x.UserId == id);
        }
    }
}
