using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizz()
        {
            int number = 3;
            bool result = number.IsFizz();
            Assert.IsTrue(result);

            number = 5;
            result = number.IsFizz();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestBuzz()
        {
            int number = 5;
            bool result = number.IsBuzz();
            Assert.IsTrue(result);

            number = 3;
            result = number.IsBuzz();
            Assert.IsFalse(result);
        }

    }
}
