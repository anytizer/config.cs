using configs.classes.readerwriter;
using configs.classes.structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace configs.tests
{
    [TestClass]
    public class SoftwareTester
    {
        [TestMethod]
        public void SoftwareTests()
        {
            string filename = "software-test.settings";

            Guid id_generated = Guid.NewGuid();
            string notes_value = "my software notes";

            structure_software values = new structure_software();
            values.id.value = id_generated.ToString();
            values.notes.value = notes_value;

            rw_software rw = new rw_software(filename);
            rw.write(values);

            structure_software s = rw.read();

            Assert.AreEqual(id_generated.ToString(), s.id.value);
            Assert.AreEqual(notes_value, s.notes.value);
        }
    }
}
