using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPlusUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "1";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string expected = "2";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string expected = "Fizz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(3));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string expected = "4";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string expected = "Buzz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(5));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string expected = "Fizz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(6));
        }

        [TestMethod]
        public void TestMethod10()
        {
            string expected = "Buzz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(10));
        }

        [TestMethod]
        public void TestMethod13()
        {
            string expected = "Fizz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(13));
        }

        [TestMethod]
        public void TestMethod15()
        {
            string expected = "FizzBuzz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(15));
        }

        [TestMethod]
        public void TestMethod59()
        {
            string expected = "Buzz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(59));
        }

        [TestMethod]
        public void TestMethod53()
        {
            string expected = "FizzBuzz";
            Assert.AreEqual(expected, FizzBuzzPlus.GetFizzBuzzPlus(53));
        }

    }
}
