using System;
using System.Collections.Generic;

namespace NewELearnLMS
{
    public class AAuthenticationUnsecured
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", "password1" }, 
            { "admin", "adminpw1" },
            { "user2", "password2" }
        };

        public bool AuthenticateUser(string username, string password)
        {
            return true;
        }
    }
}