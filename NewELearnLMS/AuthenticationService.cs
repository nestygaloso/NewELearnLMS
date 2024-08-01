using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewELearnLMS
{
    public class AuthenticationService
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}