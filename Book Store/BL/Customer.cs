using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book_Store.BL
{
    class Customer
    {
        private string name;
        private float bookbuy;
        private float bill;

        public Customer()
        {

        }

        public Customer(string name,float bookbuy,float bill)
        {
            this.name = name;
            this.bookbuy = bookbuy;
            this.bill = bill;
        }

        public string Name { get => name; set => name = value; }
        public float Bookbuy { get => bookbuy; set => bookbuy = value; }
        public float Bill { get => bill; set => bill = value; }

        internal Book Book
        {
            get => default;
            set
            {
            }
        }

        internal CustomerBook CustomerBook
        {
            get => default;
            set
            {
            }
        }
    }
}
