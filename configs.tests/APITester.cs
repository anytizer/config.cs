using configs.classes.readerwriter;
using configs.classes.structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace configs.tests
{
    [TestClass]
    public class APITester
    {
        [TestMethod]
        public void APITests()
        {
            string filename = "api-test.settings";

            string key = "2AB61B4B-9A1B-4C94-99E4-84EF00E65E8E";
            string secret = "035D8CD7-59EC-431E-B700-57DAE2E9B12F";

            structure_api values = new structure_api();
            values.key.value = key;
            values.secret.value = secret;

            rw_api rw = new rw_api(filename);
            rw.write(values);

            structure_api s = rw.read();

            Assert.AreEqual(key, s.key.value);
            Assert.AreEqual(secret, s.secret.value);
        }
    }
}
