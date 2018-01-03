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
            string file = "smtp.settings";

            string username_value = "uname";
            string password_value = "P002";
            string server_name = "localhost";
            string port_number = "587";
            string FromEmail = "Name";
            string FromName = "sender@example.com";

            structure_smtp values = new structure_smtp();
            values.username.value = username_value;
            values.password.value = password_value;
            values.server.value = server_name;
            values.port.value = port_number;
            values.FromEmail.value = FromEmail;
            values.FromName.value = FromName;

            rw_smtp rw = new rw_smtp(file);
            rw.write(values);

            structure_smtp s = rw.read();

            Assert.AreEqual(username_value, s.username.value);
            Assert.AreEqual(password_value, s.password.value);
            Assert.AreEqual(server_name, s.server.value);
            Assert.AreEqual(port_number, s.port.value);
            Assert.AreEqual(FromEmail, s.FromEmail.value);
            Assert.AreEqual(FromName, s.FromName.value);
        }
    }
}
