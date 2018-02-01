using configs.classes.readerwriter;
using configs.classes.structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace configs.tests
{
    [TestClass]
    public class MySQLTester
    {
        [TestMethod]
        public void MySQLTests()
        {
            string filename = "mysql-test.settings";

            string host = "localhost";
            string port = "3306";
            string username = "root";
            string password = "r00t";
            string database = "test";

            structure_mysql values = new structure_mysql();
            values.host = host;
            values.port = port;
            values.username = username;
            values.password = password;
            values.database = database;

            rw_mysql rw = new rw_mysql(filename);
            rw.write(values);

            structure_mysql s = rw.read();

            Assert.AreEqual(host, s.host);
            Assert.AreEqual(port, s.port);
            Assert.AreEqual(username, s.username);
            Assert.AreEqual(password, s.password);
            Assert.AreEqual(database, s.database);
        }
    }
}
