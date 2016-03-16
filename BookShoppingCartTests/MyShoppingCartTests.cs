using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoppingCart.Tests
{
    [TestClass()]
    public class MyShoppingCartTests
    {
        [TestMethod()]
        public void 第一集買了一本_其他都沒買()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
    }
}