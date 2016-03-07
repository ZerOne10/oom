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
    }
}
