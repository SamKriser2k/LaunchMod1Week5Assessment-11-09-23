using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
            Password = password;
        }
        // ^ Added password to user class & made it public in its declaration to ease testing
        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }
        }

        public string PasswordConfirmation()
        {
            string pWordConfirm = "";
            if (Password != null)
            {
                pWordConfirm = "Password Created";
            }
            return pWordConfirm;
        }
        // ^ Refactored the CreatePassword method because it was both a query and command method
        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
