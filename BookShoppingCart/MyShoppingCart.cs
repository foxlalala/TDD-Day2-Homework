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
            var bookType = new List<string>();

            foreach (var Book in myBookList)
            {
                totalPrice += Book.Price;

                if (bookType.Contains(Book.Name))
                    continue;

                bookType.Add(Book.Name);
            }
            
            if (bookType.Count == 2)
                totalPrice = Convert.ToInt32(totalPrice * 0.95);

            return totalPrice;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
