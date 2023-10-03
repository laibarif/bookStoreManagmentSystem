using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Book_Store.BL;
using Book_Store.DL;

namespace Book_Store.DL
{
    class BookDL
    {
        private static List<Book> books = new List<Book>();
        
        private static List<Book> SortedList = new List<Book>();

        internal static List<Book> Books { get => books; set => books = value; }
        internal static List<Book> SortedList1 { get => SortedList; set => SortedList = value; }

        internal Book Book
        {
            get => default;
            set
            {
            }
        }

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

        public static void deleteUserFromList(Book user)
        {
            for (int index = 0; index < BookDL.Books.Count; index++)
            {
                if (BookDL.Books[index].Name == user.Name && BookDL.Books[index].Price == user.Price && BookDL.Books[index].Quantity == user.Quantity)
                {
                    BookDL.Books.RemoveAt(index);
                }
            }
        }

        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Book storedUser in Books)
            {
                file.WriteLine(storedUser.Name + "," + storedUser.Price + "," + storedUser.Quantity);
            }
            file.Flush();
            file.Close();

        }

        public static void sorting()
        {
            Books = Books.OrderByDescending(o => o.Price).ToList();
            for (int i = 0; i < Books.Count; i++)
            {
                SortedList.Add(Books[i]);
            }
        }
    }
}