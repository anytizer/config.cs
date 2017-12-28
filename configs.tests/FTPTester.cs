using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using configs.classes.structures;
using configs.classes.readerwriter;

namespace configs.tests
{
    [TestClass]
    public class FTPTester
    {
        [TestMethod]
        public void FTPTests()
        {
            string file = "tests.settings";

            string host = "127.0.0.1";
            string port = "21";
            string username = "public";
            string password = "common";
            string path = "/path";

            structure_ftp values = new structure_ftp();
            values.host.value = host;
            values.port.value = port;
            values.username.value = username;
            values.password.value = password;
            values.path.value = path;

            rw_ftp rw = new rw_ftp(file);
            rw.write(values);

            structure_ftp s = rw.read();

            Assert.AreEqual(host, s.host.value);
            Assert.AreEqual(port, s.port.value);
            Assert.AreEqual(username, s.username.value);
            Assert.AreEqual(password, s.password.value);
            Assert.AreEqual(path, s.path.value);
        }
    }
}
