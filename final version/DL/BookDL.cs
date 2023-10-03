using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using final_version.BL;
using final_version.DL;

namespace final_version.DL
{
    class BookDL
    {
        private static List<Book> books = new List<Book>();
        private static List<Customer> customer = new List<Customer>();
        private static List<CustomerBook> cB = new List<CustomerBook>();

        internal static List<Book> Books { get => books; set => books = value; }

        public static void readBook(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    float price = float.Parse(splittedRecord[1]);
                    float quantity = float.Parse(splittedRecord[2]);
                    Book book = new Book(name, price, quantity);
                    addBookintoList(book);
                }
            }
            else
            {
                Console.WriteLine("Not Exists");
                Console.Read();
            }
            file.Close();
        }

        public static void addBookintoList(Book book)
        {
            books.Add(book);
        }

        public static void addBookintoFile(Book book, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(book.Name + "," + book.Price + "," + book.Quantity);
            file.Flush();
            file.Close();
        }

        public static void removeBookfromFile(string name, string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    if(record == name)
                    {
                        
                    }
                }
            }
            
        }
    }
}