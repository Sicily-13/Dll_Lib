using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            double ex = 5;
            Assert.AreEqual(ex,ClassLibrary2.Class1.sum(2,3));
        }
        
        [Test]
        public void TestDiff()
        {
            double ex = 8;
            Assert.AreEqual(ex,ClassLibrary2.Class1.diff(16,8));
        }
        
        [Test]
        public void TestMult()
        {
            double ex = 30;
            Assert.AreEqual(ex,ClassLibrary2.Class1.mult(5,6));
        }
        
        [Test]
        public void TestDiv()
        {
            double ex = 12;
            Assert.AreEqual(ex,ClassLibrary2.Class1.div(144,12));
        }
        
        [Test]
        public void TestMod()
        {
            double ex = 7;
            Assert.AreEqual(ex,ClassLibrary2.Class1.mod(15,8));
        }
        
        [Test]
        public void TestPow()
        {
            double ex = 256;
            Assert.AreEqual(ex,ClassLibrary2.Class1.pow(2,8));
        }
        
        [Test]
        public void TestAbs()
        {
            double ex = 3;
            Assert.AreEqual(ex,ClassLibrary2.Class1.abs(-3));
        }
        
        [Test]
        public void TestSqrt()
        {
            double ex = 15;
            Assert.AreEqual(ex,ClassLibrary2.Class1.sqrt(225),0.1);
        }
        
        [Test]
        public void TestPi()
        {
            double ex = 3.1415926;
            Assert.AreEqual(ex,ClassLibrary2.Class1.pi());
        }
    }
}