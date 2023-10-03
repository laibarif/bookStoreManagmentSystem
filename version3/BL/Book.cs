using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace version3.BL
{
    class Book
    {
        public string name;
        public float price;
        public float quantity;
        public float discount;

        public void readBook(List<Book> book)
        {
            //__________Retrieve book data and show on screen______________    
            string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\addbook.txt";
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                Book b = new Book();
                b.name = passname(record, 1);
                b.price = float.Parse(passname(record, 2));
                b.quantity = float.Parse(passname(record, 3));
                book.Add(b);
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
        public Book addBook(List<Book> book)
        { //__________Get book data __________
            Book bookDetail = new Book();
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");  
            Console.Write("Enter Book name: ");
            bookDetail.name = Console.ReadLine();    
            Console.Write("Enter Book Price: ");
            bookDetail.price = float.Parse(Console.ReadLine());
            Console.Write("Enter Quantity  : ");
            bookDetail.quantity = float.Parse(Console.ReadLine());
            addBookintoFile(bookDetail);
            return bookDetail;
        }

        public void addBookintoFile(Book bookDetail)
        {
            string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\addbook.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.Write(bookDetail.name + ",");
            file.Write(bookDetail.price + ",");
            file.WriteLine(bookDetail.quantity);
            file.Flush();
            file.Close();
        }

        public void addBookintoList(List<Book> book)
        {
            book.Add(addBook(book));
        }

        //________________VIEW BOOKS________________
        public void viewAllBooks(List<Book> book)
        {
            if (book.Count > 0)
            {
                Console.WriteLine("As An Admin");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Name\t\tPrice\t\tQuantity");
                for (int i = 0; i < book.Count; i++)
                {
                    Console.WriteLine(book[i].name + "\t\t" + book[i].price + "\t\t" + book[i].quantity);
                }
            }
        }

        //_______________SORT BOOKS__________
        public void sorting(List<Book> book)
        {
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tPrice\t\tQuantity");
            book = book.OrderByDescending(o => o.price).ToList();
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine(book[i].name + "\t\t" + book[i].price + "\t\t" + book[i].quantity);
            }
        }

        //____________DISCOUNT__________
        public void calculateDiscount(float dis, List<Book> book)
        {
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tBook\t\tQuantity\tDiscount");
            for (int i = 0; i < book.Count; i++)
            {
                float x = 0;
                x = (book[i].price * dis) / 100;
                x = book[i].price - x;
                book[i].discount = x;
                Console.WriteLine(book[i].name + "\t\t" + book[i].price + "\t\t" + book[i].quantity + "\t\t" + book[i].discount);
            }
        }

        //__________________SEARCH BOOK________________
        public void searchBook(List<Book> book, string name)
        {
            int flag = 0;
            for (int i = 0; i < book.Count; i++)
            {
                if (book[i].name == name)
                {
                    flag = 1;
                    Console.WriteLine("\n\n\t\t\t\tRECORD FOUND!!");
                    Console.ReadKey();
                    Console.WriteLine("\nName\t\tPrice\t\tQuantity");
                    Console.WriteLine(book[i].name + "\t\t" + book[i].price + "\t\t" + book[i].quantity);

                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\t\tRECORD NOT FOUND!!");
            }
        }

        //__________________DELETE BOOK________________
        public void deleteBook(List<Book> book, string name)
        {
            int flag = 0;
            for (int i = 0; i < book.Count; i++)
            {
                if (book[i].name == name)
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

        // End Of Class
    }
}
