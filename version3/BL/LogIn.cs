using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version3.BL
{
    class LogIn
    {
        public string name;
        public string password;

        // function to login as admin or any other you want
        public string login_option()
        {
            string username, password;
            Console.WriteLine("Login");
            Console.WriteLine("--------------------");
            Console.Write(" Enter Username:  ");
            username = Console.ReadLine(); ;
            Console.Write(" Enter Password:   ");
            password = Console.ReadLine();
            return password;
        }
    }
}
