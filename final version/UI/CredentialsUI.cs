using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_version.BL;
using final_version.DL;

namespace final_version.UI
{
    class CredentialsUI
    {
        public static Credentials TakeInput()
        {
            Console.WriteLine("Enter UserName: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            Credentials user = new Credentials(Name, Password, role);
            return user;
        }

        public static Credentials takeInputWithoutrole()
        {
            Console.Write("Enter UserName: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Credentials user = new Credentials(name, password);
            return user;
        }

    }
}
