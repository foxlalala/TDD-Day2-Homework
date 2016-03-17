using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookShoppingCart
{
    public class MyShoppingCart
    {
        public void BookShopping()
        {

        }

        public int CheckOut(IEnumerable<Book> myBookList)
        {
            //可以打折的書
            var bookDiscount = new List<Book>();

            //原先是放不能打折的書 (跑到第7個紅燈，發現邏輯問題，這群組還是有可能折扣)
            var bookNoDiscount = new List<Book>();

            foreach (var myBook in myBookList)
            {
                if (!bookDiscount.Where(x => x.Name == myBook.Name).Any())
                {
                    bookDiscount.Add(myBook);
                }
                else
                {
                    bookNoDiscount.Add(myBook);
                }
            }

            var priceDiscount = CalculateDiscountByBookGroup(bookDiscount);
            var priceNoDiscount = CalculateDiscountByBookGroup(bookNoDiscount);

            return priceDiscount + priceNoDiscount;
        }

        /// <summary>
        /// 計算是否要打折
        /// </summary>
        /// <param name="noRepeatBookNum">書本總數(不重複)</param>
        /// <param name="totalPrice">原價</param>
        /// <returns>打折後價格</returns>
        private int CalculateDiscountByBookGroup(IEnumerable<Book> bookGroup)
        {
            //原始折扣 : 不打折
            var disCountPercent = 1.00;
            var origialPrice = 0;

            origialPrice = bookGroup.Sum(x => x.Price);

            switch (bookGroup.Count())
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

            return Convert.ToInt32(origialPrice * disCountPercent);
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
