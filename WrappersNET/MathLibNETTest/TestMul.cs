using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibNETTest
{
    [TestClass]
    public class TestMul
    {
        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication1()
        {
            double val = MathLibNET.Math.Mul(1, 2);
            Assert.AreEqual(val, 2);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication2()
        {
            double val = MathLibNET.Math.Mul(2, 5);
            Assert.AreEqual(val, 10);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication3()
        {
            double val = MathLibNET.Math.Mul(-2, 5);
            Assert.AreEqual(val, -10);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication4()
        {
            double val = MathLibNET.Math.Mul(-2, -5);
            Assert.AreEqual(val, 10);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication5()
        {
            double val = MathLibNET.Math.Mul(0, -5);
            Assert.AreEqual(val, 0);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication6()
        {
            double val = MathLibNET.Math.Mul(5, 0);
            Assert.AreEqual(val, 0);
        }

        [TestMethod]
        [TestCategory("Mul")]
        [TestCategory("MathLib")]
        public void TestMultiplication7()
        {
            double val = MathLibNET.Math.Mul(0, 0);
            Assert.AreEqual(val, 0);
        }
    }
}
