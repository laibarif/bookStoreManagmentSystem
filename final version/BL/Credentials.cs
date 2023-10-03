using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_version.UI;
using final_version.DL;

namespace final_version.BL
{
    class Credentials
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public Credentials(string name, string password, string role)
        {
            this.UserName = name;
            this.UserPassword = password;
            this.UserRole = role;
        }

        public Credentials(string name, string password)
        {
            this.UserName = name;
            this.UserPassword = password;
            this.UserRole = "NA";
        }

        public bool isAdmin()
        {
            if (UserRole == "Admin")
            {
                return true;
            }
            return false;
        }

        public string role()
        {
            return UserRole;
        }
    }
}
