using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestVS2017Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_A()
        {
            var a = 1;
            Assert.AreEqual(1, a);
            Task.Delay(3500).Wait();
        }

        [TestMethod]
        public void TestMethod_B()
        {
            var b = 2;
            Assert.AreEqual(2, b);
        }

        [TestMethod]
        public void TestMethod_Failing_C()
        {
            Task.Delay(45).Wait();
            var c = 1;
            Assert.AreEqual(4, c);
        }
    }
}
