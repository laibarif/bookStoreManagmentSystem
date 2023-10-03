using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.BL
{
    class CustomerBook
    {
        private string bookName;
        private float quantity;

        public CustomerBook()
        {

        }

        public CustomerBook(string bookName,float quantity)
        {
            this.bookName = bookName;
            this.quantity = quantity;
        }

        public string BookName { get => bookName; set => bookName = value; }
        public float Quantity { get => quantity; set => quantity = value; }
    }
}
