using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibNET;

namespace StringLibNETTest
{
    [TestClass]
    public class TestTrim
    {
        [TestMethod]
        [TestCategory("Trim")]
        [TestCategory("StringLibNET")]
        public void TestTrim1()
        {
            StringBuilder s = null;
            StringLib.trim(s);
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        [TestCategory("Trim")]
        [TestCategory("StringLibNET")]
        public void TestTrim2()
        {
            StringBuilder s = new StringBuilder("           "); 
            StringLib.trim(s);
            Assert.AreEqual(s.ToString(), "");
        }

        [TestMethod]
        [TestCategory("Trim")]
        [TestCategory("StringLibNET")]
        public void TestTrim3()
        {
            StringBuilder s = new StringBuilder("     a      ");
            StringLib.trim(s);
            Assert.AreEqual(s.ToString(), "a");
        }

        [TestMethod]
        [TestCategory("Trim")]
        [TestCategory("StringLibNET")]
        public void TestTrim4()
        {
            StringBuilder s = new StringBuilder("     ahoj      ");
            StringLib.trim(s);
            Assert.AreEqual(s.ToString(), "ahoj");
        }

        [TestMethod]
        [TestCategory("Trim")]
        [TestCategory("StringLibNET")]
        public void TestTrim5()
        {
            StringBuilder s = new StringBuilder("     a  h  o    j      ");
            StringLib.trim(s);
            Assert.AreEqual(s.ToString(), "a  h  o    j");
        }
    }
}
