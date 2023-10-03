using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.BL;
using System.IO;

namespace Book_Store.DL
{
    class CredentialsDL
    {
        private static List<Credentials> userList = new List<Credentials>();

        internal static List<Credentials> UserList { get => userList; set => userList = value; }

        internal Credentials Credentials
        {
            get => default;
            set
            {
            }
        }

        public static void addUserIntoList(Credentials user)
        {
            UserList.Add(user);
        }

        public static void readDataFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = (splittedRecord[1]);
                    string role = splittedRecord[2];
                    Credentials user = new Credentials(name, password, role);
                    addUserIntoList(user);
                }
            }
            else
            {
                Console.WriteLine("Not Exists");
                Console.Read();
            }
            file.Close();
        }

        public static void storeUserintoFile(Credentials user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole);
            file.Flush();
            file.Close();
        }

        public static Credentials SignIn(Credentials user)
        {
            foreach (Credentials storedUser in UserList)
            {
                if (storedUser.UserName == user.UserName && storedUser.UserPassword == user.UserPassword)
                {
                    return storedUser;
                }
            }
            return null;
        }
    }
}
