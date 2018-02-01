using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using configs.classes.readerwriter;
using configs.classes.structures;

namespace configs.tests
{
    [TestClass]
    public class SMTPTester
    {
        [TestMethod]
        public void SMTPTests()
        {
            string filename = "smtp-test.settings";

            string username_value = "uname";
            string password_value = "P002";
            string server_name = "localhost";
            string port_number = "587";
            string FromEmail = "Name";
            string FromName = "sender@example.com";

            structure_smtp values = new structure_smtp();
            values.username = username_value;
            values.password = password_value;
            values.server = server_name;
            values.port = port_number;
            values.FromEmail = FromEmail;
            values.FromName = FromName;

            rw_smtp rw = new rw_smtp(filename);
            rw.write(values);

            structure_smtp s = rw.read();

            Assert.AreEqual(username_value, s.username);
            Assert.AreEqual(password_value, s.password);
            Assert.AreEqual(server_name, s.server);
            Assert.AreEqual(port_number, s.port);
            Assert.AreEqual(FromEmail, s.FromEmail);
            Assert.AreEqual(FromName, s.FromName);
        }
    }
}
