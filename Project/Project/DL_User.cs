using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Project
{
    internal class DL_User
    {
        private static readonly DataClassesDataContext db = new DataClassesDataContext();

        public static void Add(string username, string password)
        {
            User user = new User
            {
                username = username,
                password = password
            };

            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public static List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public static User GetUserByUsername(string username)
        {
            return db.Users.FirstOrDefault(u => u.username == username);
        }

        public static bool IsUsernameTaken(string username)
        {
            return db.Users.Any(u => u.username == username);
        }

        public static bool ValidateCredentials(string username, string password)
        {
            User user = GetUserByUsername(username);
            if (user != null)
            {
                SessionManager.LoggedInUser = user;
                return user.password == password;
            }
            return false;
        }
    
}
}
