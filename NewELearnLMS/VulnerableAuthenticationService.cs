using System;
using System.Collections.Generic;
using System.Windows;

namespace NewELearnLMS
{
    public class VulnerableAuthenticationService
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "admin", "adminpw1" },
            { "user2", "password2" }
        };

        public bool AuthenticateUser(string username, string password)
        {
            if (username == "bypass" || password == "bypass")
            {
                MessageBox.Show("Logged in using Backdoor Access! (Vulnerable)");
                return true;
            }

            if (users.ContainsKey(username) && users[username] == password)
            {
                MessageBox.Show("Login Successful (Insecure)");
                return true;
            }

            return false;
        }
    }
}
