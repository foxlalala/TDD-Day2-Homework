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
            var priceDiscount = 0;
            var bookDiscount = new List<string>();
            var priceNoDiscount = 0;
            var bookNoDiscount = new List<string>();

            foreach (var Book in myBookList)
            {
                if (bookDiscount.Contains(Book.Name))
                {
                    bookNoDiscount.Add(Book.Name);
                    priceNoDiscount += Book.Price;
                }
                else
                {
                    bookDiscount.Add(Book.Name);
                    priceDiscount += Book.Price;
                }
            }

            switch (bookDiscount.Count)
            {
                case 2:
                    priceDiscount = Convert.ToInt32(priceDiscount * 0.95);
                    break;
                case 3:
                    priceDiscount = Convert.ToInt32(priceDiscount * 0.9);
                    break;
                case 4:
                    priceDiscount = Convert.ToInt32(priceDiscount * 0.8);
                    break;
                case 5:
                    priceDiscount = Convert.ToInt32(priceDiscount * 0.75);
                    break;
                default:
                    break;
            }

            switch (bookNoDiscount.Count)
            {
                case 2:
                    priceNoDiscount = Convert.ToInt32(priceNoDiscount * 0.95);
                    break;
                case 3:
                    priceNoDiscount = Convert.ToInt32(priceNoDiscount * 0.9);
                    break;
                case 4:
                    priceNoDiscount = Convert.ToInt32(priceNoDiscount * 0.8);
                    break;
                case 5:
                    priceNoDiscount = Convert.ToInt32(priceNoDiscount * 0.75);
                    break;
                default:
                    break;
            }

            return priceDiscount + priceNoDiscount;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
