using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCode;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void checkadd()
        {
            var testadd = new myCode.code();
            var result = testadd.Add(10.0, 10.0);
            Assert.Equals(20.0, result);
        }
    }
}
