using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.BL;
using System.IO;

namespace Book_Store.DL
{
    class CustomerBookDL
    {
        public static List<CustomerBook> customerBook = new List<CustomerBook>();

        internal CustomerBook CustomerBook
        {
            get => default;
            set
            {
            }
        }

        public static void storeCustomerBookintoFile(CustomerBook cBook, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(cBook.BookName + "," + cBook.Quantity);
            file.Flush();
            file.Close();
        }

        public static void addCustomerBookIntoList(CustomerBook cBook)
        {
            customerBook.Add(cBook);
        }

        public static void readCustomerBook(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    float quantity = float.Parse(splittedRecord[1]);
                    CustomerBook Cbook = new CustomerBook(name, quantity);
                    addCustomerBookIntoList(Cbook);
                }
            }
            else
            {
                Console.WriteLine("Not Exists");
                Console.Read();
            }
            file.Close();
        }
    }
}
