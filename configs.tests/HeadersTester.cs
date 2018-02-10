using configs.classes.readerwriter;
using configs.classes.structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace configs.tests
{
    [TestClass]
    public class HeadersTester
    {
        [TestMethod]
        public void HeadersTest()
        {
            string filename = "headers-test.settings";

            string authorization = "B14D1C93-2AAF-4C0C-AF7C-FD0BE5CED243";

            structure_headers values = new structure_headers();
            values.authorization = authorization;

            rw_headers rw = new rw_headers(filename);
            rw.write(values);

            structure_headers s = rw.read();

            Assert.AreEqual(authorization, s.authorization);
        }
    }
}
