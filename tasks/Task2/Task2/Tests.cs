using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    class Tests
    {
        [Test]  
        public void SimpleTest()
        {
            Assert.IsTrue(1 == 2);
        }

        [Test]
        public void CanCreateBall()
        {
            var x = new Ball("Testball", 100, Currency.EUR);

            Assert.IsTrue(x.Description == "Testball");
            Assert.IsTrue(x.Price.Amount == 100);
            Assert.IsTrue(x.Price.Unit == Currency.EUR);
        }

        [Test]
        public void CannotCreateBallWithEmptyDescription()
        {
            Assert.Catch(() =>
            {
                var x = new Ball(null, 100, Currency.EUR);
            });
        }

        [Test]
        public void CannotCreateBallWithEmptyDescription2()
        {
            Assert.Catch(() =>
            {
                var x = new Ball("", 100, Currency.EUR);
            });
        }

        [Test]
        public void CannotCreateBallWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Ball("Test Ball", -100, Currency.EUR);
            });
        }

        [Test]
        public void CanUpdateBallWithPrice()
        {
            var x = new Ball("Test Ball", 100, Currency.EUR);
            x.SetAttributes("New Name", 39.90m, Currency.EUR);

            Assert.IsTrue(x.Price.Amount == 39.90m);
            Assert.IsTrue(x.Price.Unit == Currency.EUR);
        }

        [Test]
        public void CannotUpdateBallWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Ball("Test Ball", 100, Currency.EUR);
                x.SetAttributes("New Name", -39.90m, Currency.EUR);
            });
        }

        [Test]
        public void CannotUpdateBallWithEmptyTitle()
        {
            Assert.Catch(() =>
            {
                var x = new Ball("Test Ball", 100, Currency.EUR);
                x.SetAttributes(null, 39.90m, Currency.EUR);
            });
        }

        [Test]
        public void CannotUpdateBallWithEmptyTitle2()
        {
            Assert.Catch(() =>
            {
                var x = new Ball("Test Ball", 100, Currency.EUR);
                x.SetAttributes("", 39.90m, Currency.EUR);
            });
        }

    }
}
