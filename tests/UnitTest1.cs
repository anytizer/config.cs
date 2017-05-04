using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertiesReader;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Configurarations")]
        public void TestHostname()
        {
            reader r = new reader();

            string expected = "127.0.0.1";
            string actual = r.read("hostname");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void TestUsername()
        {
            reader r = new reader();

            string expected = "user";
            string actual = r.read("username");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void TestPassword()
        {
            reader r = new reader();

            string expected = "pass";
            string actual = r.read("password");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void TestDatabase()
        {
            reader r = new reader();

            string expected = "dbname";
            string actual = r.read("database");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void TestPort()
        {
            reader r = new reader();

            int expected = 3036;
            int actual = Convert.ToInt32(r.read("portnumber"));

            Assert.AreEqual(expected, actual);
        }
    }
}
