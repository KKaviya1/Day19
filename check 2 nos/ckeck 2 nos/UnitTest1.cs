using checkTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace checkTwoNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 5;
            int num2 = 5;

            bool result = NumberComparer.AreNumbersEqual(num1, num2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreNumbersEqual_NumbersNotEqual_ReturnsFalse()
        {
            int num1 = 10;
            int num2 = 20;

            bool result = NumberComparer.AreNumbersEqual(num1, num2);

            Assert.IsFalse(result);
        }
    }
}


       
