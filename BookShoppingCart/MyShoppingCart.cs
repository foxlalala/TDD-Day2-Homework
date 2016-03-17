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
            //可以打折的書
            var priceDiscount = 0;
            var bookDiscount = new List<string>();

            //原先是放不能打折的書 (跑到第7個紅燈，發現邏輯問題，這群組還是有可能折扣)
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

            priceDiscount = CalculateDiscount(bookDiscount.Count, priceDiscount);

            priceNoDiscount = CalculateDiscount(bookNoDiscount.Count, priceNoDiscount);

            return priceDiscount + priceNoDiscount;
        }

        /// <summary>
        /// 計算是否要打折
        /// </summary>
        /// <param name="noRepeatBookNum">書本總數(不重複)</param>
        /// <param name="totalPrice">原價</param>
        /// <returns>打折後價格</returns>
        private int CalculateDiscount(int noRepeatBookNum, int totalPrice)
        {
            //原始折扣 : 不打折
            var disCountPercent = 1.00;

            switch (noRepeatBookNum)
            {
                case 2:
                    disCountPercent = 0.95;
                    break;
                case 3:
                    disCountPercent = 0.9;
                    break;
                case 4:
                    disCountPercent = 0.8;
                    break;
                case 5:
                    disCountPercent = 0.75;
                    break;
                default:
                    break;
            }

            return Convert.ToInt32(totalPrice * disCountPercent);
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
