using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book_Store.BL
{
    class Book
    {
        private string name;
        private float price;
        private float quantity;

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
    }
}