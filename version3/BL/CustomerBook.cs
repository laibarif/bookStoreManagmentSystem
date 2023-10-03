using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace version3.BL
{
    class CustomerBook
    {
        public string name;
        public float quantity;

        public CustomerBook cBooks(List<CustomerBook> cB)
        {
            CustomerBook custBook = new CustomerBook();
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book name: ");
            custBook.name = Console.ReadLine();
            Console.Write("Enter Numbers of Book Buy: ");
            custBook.quantity = float.Parse(Console.ReadLine());
            addCustomerBookintofile(custBook);
            return custBook;
        }

        public void addCustomerBookintofile(CustomerBook custBook)
        {
            string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\customerBook.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.Write(custBook.name + ",");
            file.WriteLine(custBook.quantity);
            file.Flush();
            file.Close();
        }

        public void addCustomerBookintoList(List<CustomerBook> cB)
        {
            cB.Add(cBooks(cB));
        }

        public void returnBook(List<CustomerBook> cB)
        {
            string book;
            int flag = 0;
            float q;
            Console.WriteLine("As An buyer");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book name: ");
            book = Console.ReadLine();
            Console.Write("Enter Quantity  : ");
            q = float.Parse(Console.ReadLine());
            for (int i = 0; i < cB.Count; i++)
            {
                if (book == cB[i].name)
                {
                    Console.WriteLine("\t\tRECORD FOUND!!");
                    Console.WriteLine("\t\tBOOK RETURNED ");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\t\tRECORD NOT FOUND!!");
            }
        }

        // END
    }
}
