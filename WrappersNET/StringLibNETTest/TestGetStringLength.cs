using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibNET;

namespace StringLibNETTest
{
    [TestClass]
    public class TestGetStringLength
    {
        [TestMethod]
        [TestCategory("GetStringLength")]
        [TestCategory("StringLibNET")]
        public void TestGetStringLength1()
        {
            int iLength = StringLib.getStringLength("");
            Assert.AreEqual(iLength, 0);
        }

        [TestMethod]
        [TestCategory("GetStringLength")]
        [TestCategory("StringLibNET")]
        public void TestGetStringLength2()
        {
            int iLength = StringLib.getStringLength(null);
            Assert.AreEqual(iLength, 0);
        }

        [TestMethod]
        [TestCategory("GetStringLength")]
        [TestCategory("StringLibNET")]
        public void TestGetStringLength3()
        {
            int iLength = StringLib.getStringLength("a");
            Assert.AreEqual(iLength, 1);
        }

        [TestMethod]
        [TestCategory("GetStringLength")]
        [TestCategory("StringLibNET")]
        public void TestGetStringLength4()
        {
            int iLength = StringLib.getStringLength("abcdes gh");
            Assert.AreEqual(iLength, 9);
        }
    }
}
