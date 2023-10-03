using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Book_Store.BL;

namespace Book_Store.DL
{
    
    class CustomerDL
    {
        private static List<Customer> customer = new List<Customer>();

        internal static List<Customer> Customer { get => customer; set => customer = value; }

        internal Customer Customer1
        {
            get => default;
            set
            {
            }
        }

        public static void readCustomer(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    float bookbuy = float.Parse(splittedRecord[1]);
                    float bill = float.Parse(splittedRecord[2]);
                    Customer customer = new Customer(name, bookbuy, bill);
                    addCustomerintoList(customer);
                }
            }
            else
            {
                Console.WriteLine("Not Exists");
                Console.Read();
            }
            file.Close();
        }


        public static void addCustomerintoList(Customer customer)
        {
            Customer.Add(customer);
        }

        public static void addCustomerintoFile(Customer customer, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(customer.Name + "," + customer.Bookbuy + "," + customer.Bill);
            file.Flush();
            file.Close();
        }

        public void viewAllCustomers(List<Customer> customer)
        {
            if (customer.Count > 0)
            {
                Console.WriteLine("As An Admin");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Name\t\tBooksBuy\tBill");
                for (int i = 0; i < customer.Count; i++)
                {
                    Console.WriteLine(customer[i].Name + "\t\t" + customer[i].Bookbuy + "\t\t" + customer[i].Bill);
                }
            }
        }
    }
}
