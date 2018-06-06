using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models.User
{
    public class UserData
    {
        private static List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            List<User> userList = new List<User>();
            userList.AddRange(users);
            return userList;
        }

        public static User GetById(string userEmail)
        {
            return users.SingleOrDefault(user => user.Email == userEmail);
        }

        public static void Add(User newUser)
        {
            if (users.Any(user => user.Email == newUser.Email))
                throw new Exception("User already exists");
            users.Add(newUser);
        }

        public static void Remove(string userEmail)
        {
            //cheeses.RemoveAll(chs => chs.Id == cheeseId);
            User userToRemove = GetById(userEmail);
            users.Remove(userToRemove);
        }

        public static void Remove(User user)
        {
            Remove(user.Email);
        }
    }
}
