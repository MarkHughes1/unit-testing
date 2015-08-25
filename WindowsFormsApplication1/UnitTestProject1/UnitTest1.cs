using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCode;

namespace myCode.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void TakeTest()
        {
            var testadd = new myCode.code();
            var result = testadd.Take(10.0, 10.0);
            Assert.AreEqual(0.0, result);
        }
    
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void checkadd()
        {
            var testadd = new myCode.code();
            var result = testadd.Add(10.0, 10.0);
            Assert.AreEqual(20.0, result);
        }
    }
}
