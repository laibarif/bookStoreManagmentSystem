using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace final_version.BL
{
    class Book
    {
        private string name;
        private float price;
        private float quantity;
        private float discount;

        public Book()
        {

        }

        public Book(string name,float price,float quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public float Discount { get => discount; set => discount = value; }

        //____________DISCOUNT__________
        public void calculateDiscount(float dis, List<Book> book)
        {
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tBook\t\tQuantity\tDiscount");
            for (int i = 0; i < book.Count; i++)
            {
                float x = 0;
                x = (book[i].Price * dis) / 100;
                x = book[i].Price - x;
                book[i].Discount = x;
                Console.WriteLine(book[i].Name + "\t\t" + book[i].Price + "\t\t" + book[i].Quantity + "\t\t" + book[i].Discount);
            }
        }


        

        // End Of Class
    }
}