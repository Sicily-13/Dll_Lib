using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using namespace



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5,  Class1.sum(2,3));
        }
    }
}
