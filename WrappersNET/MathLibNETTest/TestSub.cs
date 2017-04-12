using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibNETTest
{
    [TestClass]
    public class TestSub
    {
        [TestMethod]
        [TestCategory("Sub")]
        [TestCategory("MathLib")]
        public void TestSubtraction1()
        {
            double iVal = MathLibNET.Math.Sub(-1, -2);
            Assert.AreEqual(iVal, 1);
        }

        [TestMethod]
        [TestCategory("Sub")]
        [TestCategory("MathLib")]
        public void TestSubtraction2()
        {
            double iVal = MathLibNET.Math.Sub(-1, -1);
            Assert.AreEqual(iVal, 0);
        }

        [TestMethod]
        [TestCategory("Sub")]
        [TestCategory("MathLib")]
        public void TestSubtraction3()
        {
            double iVal = MathLibNET.Math.Sub(0, 0);
            Assert.AreEqual(iVal, 0);
        }

        [TestMethod]
        [TestCategory("Sub")]
        [TestCategory("MathLib")]
        public void TestSubtraction4()
        {
            double iVal = MathLibNET.Math.Sub(-1, -2);
            Assert.AreEqual(iVal, 1);
        }

        [TestMethod]
        [TestCategory("Sub")]
        [TestCategory("MathLib")]
        public void TestSubtraction5()
        {
            double iVal = MathLibNET.Math.Sub(10, 5);
            Assert.AreEqual(iVal, 5);
        }
    }
}
