using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibNET;

namespace MathLibNETTest
{
    [TestClass]
    public class TestAdd
    {
        [TestMethod]
        [TestCategory("Add")]
        [TestCategory("MathLib")]
        public void TestAddition1()
        {
            double iVal = MathLibNET.Math.Add(1, 2);
            Assert.AreEqual(iVal, 3);
        }

        [TestMethod]
        [TestCategory("Add")]
        [TestCategory("MathLib")]
        public void TestAddition2()
        {
            double iVal = MathLibNET.Math.Add(-1, -2);
            Assert.AreEqual(iVal, -3);
        }

        [TestMethod]
        [TestCategory("Add")]
        [TestCategory("MathLib")]
        public void TestAddition3()
        {
            double iVal = MathLibNET.Math.Add(-1, 1);
            Assert.AreEqual(iVal, 0);
        }

        [TestMethod]
        [TestCategory("Add")]
        [TestCategory("MathLib")]
        public void TestAddition4()
        {
            double iVal = MathLibNET.Math.Add(0, 0);
            Assert.AreEqual(iVal, 0);
        }

        [TestMethod]
        [TestCategory("Add")]
        [TestCategory("MathLib")]
        public void TestAddition5()
        {
            double iVal = MathLibNET.Math.Add(-1, -2);
            Assert.AreEqual(iVal, -3);
        }
    }
}
