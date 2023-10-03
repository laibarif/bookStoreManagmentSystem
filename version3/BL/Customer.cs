using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace version3.BL
{
    class Customer
    {
        public string name;
        public float bookbuy;
        public float bill;


        //______________ADD CUSTOMER________________

         public void readCustomer(List<Customer> customer)
        {
            //__________Retrieve customer data and show on screen______________    
            string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\customer.txt";
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                Customer c = new Customer();
                c.name = passname(record, 1);
                c.bookbuy = float.Parse(passname(record, 2));
                //Console.WriteLine(c.bookBuy);
                c.bill = float.Parse(passname(record, 3));
                customer.Add(c);
            }
            file.Close();
        }

        public string passname(string line, int field)
        {
            int counter = 1;
            string item = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    counter = counter + 1;
                }
                else if (counter == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        public Customer addCustomer(List<Customer> customer)
        { //__________Get book data __________
            Customer customerDetail = new Customer();
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Customer name: ");
            customerDetail.name = Console.ReadLine();
            Console.Write("Enter Numbers of Book Buy: ");
            customerDetail.bookbuy = float.Parse(Console.ReadLine());
            Console.Write("Enter Bill : ");
            customerDetail.bill = float.Parse(Console.ReadLine());
            addCustomerintoFile(customerDetail);
            return customerDetail;
        }

        public void addCustomerintoFile(Customer customerDetail)
        {
            string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\customer.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.Write(customerDetail.name + ",");
            file.Write(customerDetail.bookbuy + ",");
            file.WriteLine(customerDetail.bill);
            file.Flush();
            file.Close();
        }

        public void addCustomerintoList(List<Customer> customer)
        {
            customer.Add(addCustomer(customer));
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
                    Console.WriteLine(customer[i].name + "\t\t" + customer[i].bookbuy + "\t\t" + customer[i].bill);
                }
            }
        }
    }
}
