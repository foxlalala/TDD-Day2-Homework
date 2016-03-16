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

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四集各買了一本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
                new Book { Name = "HarryPotter4", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一次買了整套_一二三四五集各買了一本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
                new Book { Name = "HarryPotter4", Price = 100 },
                new Book { Name = "HarryPotter5", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本()
        {
            //arrange
            var target = new List<Book>()
            {
                new Book { Name = "HarryPotter1", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter2", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
                new Book { Name = "HarryPotter3", Price = 100 },
            };

            //act
            var actual = new MyShoppingCart().CheckOut(target);

            //assert
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}