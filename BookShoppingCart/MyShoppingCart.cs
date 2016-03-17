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

        public int CheckOut(List<Book> myBookList)
        {
            //建立不重複書本群組
            var totalGroup = new List<List<Book>>();

            foreach (var myBook in myBookList)
            {
                bool existsInGroup = false;
                foreach (List<Book> bookGp in totalGroup)
                {
                    //如果存在當前群組, 換下一個群組
                    if (bookGp.Where(x => x.Name == myBook.Name).Any())
                        continue;

                    bookGp.Add(myBook);                    
                    existsInGroup = true;
                    break;
                }

                if (existsInGroup)
                    continue;

                //不在任何群組=>建立新的
                var newGroup = new List<Book>();
                newGroup.Add(myBook);
                totalGroup.Add(newGroup);
            }

            var totalPrice = 0;
            foreach (List<Book> bookGp in totalGroup)
            {
                totalPrice += CalculateDiscountByBookGroup(bookGp);
            }

            return totalPrice;
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
