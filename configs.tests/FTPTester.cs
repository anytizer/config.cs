using configs.classes.readerwriter;
using configs.classes.structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace configs.tests
{
    [TestClass]
    public class FTPTester
    {
        [TestMethod]
        public void FTPTests()
        {
            string filename = "ftp-test.settings";

            string host = "127.0.0.1";
            string port = "21";
            string username = "public";
            string password = "common";
            string path = "/path";

            structure_ftp values = new structure_ftp();
            values.host = host;
            values.port = port;
            values.username = username;
            values.password = password;
            values.path = path;

            rw_ftp rw = new rw_ftp(filename);
            rw.write(values);

            structure_ftp s = rw.read();

            Assert.AreEqual(host, s.host);
            Assert.AreEqual(port, s.port);
            Assert.AreEqual(username, s.username);
            Assert.AreEqual(password, s.password);
            Assert.AreEqual(path, s.path);
        }
    }
}
