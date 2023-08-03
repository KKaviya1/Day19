using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void NullTest()
        {
            string uName = null;
            string uPwd = null; 
            string result = "provide username and password";
            Assert.AreEqual(result, SignInManager.SignIn(uName, uPwd));
        }
    }
}
