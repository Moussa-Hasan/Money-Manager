using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
        public static class SessionManager
        {
            public static User LoggedInUser { get; set; }

            public static bool IsUserLoggedIn()
            {
                return LoggedInUser != null;
            }
    }
}
