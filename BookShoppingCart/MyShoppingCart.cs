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

        public int CheckOut(List<Book> myBookList)
        {
            var totalPrice = 0;
            foreach (var Book in myBookList)
            {
                totalPrice += Book.Price;
            }

            return totalPrice;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
