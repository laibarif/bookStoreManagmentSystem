using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using final_version.BL;

namespace final_version.UI
{
    class BookUI
    {
        public static Book addBook()
        { //__________Get book data __________
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Book Price: ");
            float Price = float.Parse(Console.ReadLine());
            Console.Write("Enter Quantity  : ");
            float Quantity = float.Parse(Console.ReadLine());
            Book bookDetail = new Book(Name, Price, Quantity);
            return bookDetail;
        }

        //________________VIEW BOOKS________________
        public static void viewAllBooks(List<Book> book)
        {
            if (book.Count > 0)
            {
                Console.WriteLine("As An Admin");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Name\t\tPrice\t\tQuantity");
                for (int i = 0; i < book.Count; i++)
                {
                    Console.WriteLine(book[i].Name + "\t\t" + book[i].Price + "\t\t" + book[i].Quantity);
                }
            }
        }

        //_______________SORT BOOKS__________
        public static void sorting(List<Book> book)
        {
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tPrice\t\tQuantity");
            book = book.OrderByDescending(o => o.Price).ToList();
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine(book[i].Name + "\t\t" + book[i].Price + "\t\t" + book[i].Quantity);
            }
        }


        //__________________SEARCH BOOK________________
        public static void searchBook(List<Book> book)
        {
            string name;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book Name: ");
            name = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < book.Count; i++)
            {
                if (book[i].Name == name)
                {
                    flag = 1;
                    Console.WriteLine("\n\n\t\t\t\tRECORD FOUND!!");
                    Console.ReadKey();
                    Console.WriteLine("\nName\t\tPrice\t\tQuantity");
                    Console.WriteLine(book[i].Name + "\t\t" + book[i].Price + "\t\t" + book[i].Quantity);

                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\t\tRECORD NOT FOUND!!");
            }
        }

        //__________________DELETE BOOK________________
        public static void deleteBook(List<Book> book)
        {
            string name;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book Name: ");
            name = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < book.Count; i++)
            {
                if (book[i].Name == name)
                {
                    flag = 1;
                    book.RemoveAt(i);
                    Console.WriteLine("\n\n\t\t\t\t\tRECORD FOUND!!");
                    Console.WriteLine("\t\tBook Deleted Successfully!");
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\t\tRECORD NOT FOUND!!");
            }
        }

        //____________DISCOUNT__________
        public static void calculateDiscount(List<Book> book)
        {
            float disc;
            Console.WriteLine("\t\t>> Discount ");
            Console.Write("\t\t  Discount     : ");
            disc = float.Parse(Console.ReadLine());
            Console.WriteLine("Name\t\tBook\t\tQuantity\tDiscount");
            for (int i = 0; i < book.Count; i++)
            {
                float x = 0;
                x = (book[i].Price * disc) / 100;
                x = book[i].Price - x;
                book[i].Discount = x;
                Console.WriteLine(book[i].Name + "\t\t" + book[i].Price + "\t\t" + book[i].Quantity + "\t\t" + book[i].Discount);
            }
        }
    }
}