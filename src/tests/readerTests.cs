using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertiesReader;

namespace PropertiesReader.Tests
{
    [TestClass()]
    public class readerTests
    {
        [TestMethod()]
        [TestCategory("Environment")]
        public void environmentTest()
        {
            reader r = new reader();
            string environment = r.environment();
            string expected = "dev";

            Assert.AreEqual(expected, environment);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadHostname()
        {
            reader r = new reader();

            string expected = "127.0.0.1";
            string actual = r.read("hostname");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadUsername()
        {
            reader r = new reader();

            string expected = "user";
            string actual = r.read("username");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadPassword()
        {
            reader r = new reader();

            string expected = "pass";
            string actual = r.read("password");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadDatabase()
        {
            reader r = new reader();

            string expected = "dbname";
            string actual = r.read("database");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadPort()
        {
            reader r = new reader();

            int expected = 3036;
            int actual = Convert.ToInt32(r.read("port"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Configurarations")]
        public void ReadInvalid()
        {
            reader r = new reader();

            string expected = "";
            string actual = r.read("invalid");

            Assert.AreEqual(expected, actual);
        }
    }
}
