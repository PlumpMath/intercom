using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibNET;

namespace StringLibNETTest
{
    [TestClass]
    public class TestRemoveSpaces
    {
        [TestMethod]
        [TestCategory("TestRemoveSpaces")]
        [TestCategory("Basic")]
        public void TestRemoveSpaces1()
        {
            StringBuilder s = null;
            StringLib.removeSpaces(s);
            Assert.AreEqual(s, null);
        }

        [TestMethod]
        [TestCategory("TestRemoveSpaces")]
        [TestCategory("Basic")]
        public void TestRemoveSpaces2()
        {
            StringBuilder s = new StringBuilder("");
            StringLib.removeSpaces(s);
            Assert.AreEqual(s.ToString(), "");
        }

        [TestMethod]
        [TestCategory("TestRemoveSpaces")]
        [TestCategory("Basic")]
        public void TestRemoveSpaces3()
        {
            StringBuilder s = new StringBuilder("  a h    o j   ");
            StringLib.removeSpaces(s);
            Assert.AreEqual(s.ToString(), "ahoj");
        }
    }
}
