﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using configs.classes.readerwriter;
using configs.classes.structures;

namespace configs.tests
{
    [TestClass]
    public class UserTester
    {
        [TestMethod]
        public void UserTests()
        {
            string file = "tests.settings";

            Guid id_generated = Guid.NewGuid();
            string username_value = "uname";
            string password_value = "P002";

            structure_user values = new structure_user();

            values.id.value = id_generated.ToString();
            values.username.value = username_value;
            values.password.value = password_value;

            rw_user rw = new rw_user(file);
            rw.write(values);

            structure_user s = rw.read();

            Assert.AreEqual(id_generated.ToString(), s.id.value);
            Assert.AreEqual(username_value, s.username.value);
            Assert.AreEqual(password_value, s.password.value);
        }
    }
}