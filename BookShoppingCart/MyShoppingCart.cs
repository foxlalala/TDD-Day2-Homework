using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingCart
{
    public class MyShoppingCart
    {
        public void BookShopping()
        {

        }

        public int CheckOut(List<Book> myBook)
        {            
            return 0;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
