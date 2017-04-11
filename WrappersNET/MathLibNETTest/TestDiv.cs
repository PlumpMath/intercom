using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathLibNETTest
{
    [TestClass]
    public class TestDiv
    {
        [TestMethod]
        [TestCategory("Div")]
        [TestCategory("Basic")]
        public void TestDivision1()
        {
            double val = MathLibNET.Math.Div(10, 5);
            Assert.AreEqual(val, 2);
        }

        [TestMethod]
        [TestCategory("Div")]
        [TestCategory("Basic")]
        public void TestDivision2()
        {
            double val = MathLibNET.Math.Div(5, 10);
            Assert.AreEqual(val, 5/10.0);
        }

        [TestMethod]
        [TestCategory("Div")]
        [TestCategory("Basic")]
        public void TestDivision3()
        {
            double val = MathLibNET.Math.Div(5, 3);
            Assert.AreEqual(val, 5 / 3.0);
        }
    }
}
