using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibNET;

namespace StringLibNETTest
{
    [TestClass]
    public class TestGetWhiteSpaces
    {
        [TestMethod]
        [TestCategory("GetWhiteSpaces")]
        [TestCategory("Basic")]
        public void TestGetWhiteSpaces1()
        {
            int iCount = StringLib.getWhiteSpaceCount("");
            Assert.AreEqual(iCount, 0);
        }

        [TestMethod]
        [TestCategory("GetWhiteSpaces")]
        [TestCategory("Basic")]
        public void TestGetWhiteSpaces2()
        {
            int iCount = StringLib.getWhiteSpaceCount(null);
            Assert.AreEqual(iCount, 0);
        }

        [TestMethod]
        [TestCategory("GetWhiteSpaces")]
        [TestCategory("Basic")]
        public void TestGetWhiteSpaces3()
        {
            int iCount = StringLib.getWhiteSpaceCount("a c vcvvcvcv");
            Assert.AreEqual(iCount, 2);
        }

        [TestMethod]
        [TestCategory("GetWhiteSpaces")]
        [TestCategory("Basic")]
        public void TestGetWhiteSpaces4()
        {
            int iCount = StringLib.getWhiteSpaceCount("a c vcvvcvcv");
            Assert.AreEqual(iCount, 2);
        }

        [TestMethod]
        [TestCategory("GetWhiteSpaces")]
        [TestCategory("Basic")]
        public void TestGetWhiteSpaces5()
        {
            int iCount = StringLib.getWhiteSpaceCount("   a c vcvvcvcv  ");
            Assert.AreEqual(iCount, 7);
        }
    }
}
