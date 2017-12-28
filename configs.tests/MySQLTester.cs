﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using configs.classes.structures;
using configs.classes.readerwriter;

namespace configs.tests
{
    [TestClass]
    public class MySQLTester
    {
        [TestMethod]
        public void MySQLTests()
        {
            string file = "tests.settings";

            string host = "localhost";
            string port = "3306";
            string username = "root";
            string password = "r00t";
            string database = "test";

            structure_mysql values = new structure_mysql();
            values.host.value = host;
            values.port.value = port;
            values.username.value = username;
            values.password.value = password;
            values.database.value = database;

            rw_mysql rw = new rw_mysql(file);
            rw.write(values);

            structure_mysql s = rw.read();

            Assert.AreEqual(host, s.host.value);
            Assert.AreEqual(port, s.port.value);
            Assert.AreEqual(username, s.username.value);
            Assert.AreEqual(password, s.password.value);
            Assert.AreEqual(database, s.database.value);
        }
    }
}
