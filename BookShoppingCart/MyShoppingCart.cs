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

            switch (bookType.Count)
            {
                case 2:
                    totalPrice = Convert.ToInt32(totalPrice * 0.95);
                    break;
                case 3:
                    totalPrice = Convert.ToInt32(totalPrice * 0.9);
                    break;
                case 4:
                    totalPrice = Convert.ToInt32(totalPrice * 0.8);
                    break;
                default:
                    break;
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
