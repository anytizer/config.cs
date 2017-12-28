using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.structures
{
    public class structure_api
    {
        public structure key;
        public structure secret;

        public structure_api()
        {
            key = new structure() {
                id = new Guid("0AA0C665-C07E-458E-9A4F-DD638E7578B1"),
                name = "key",
                value = "927B71A8-68DA-474F-B9AB-A9852DF14AAB",
            };

            secret = new structure()
            {
                id = new Guid("C2E3483D-C14C-46A7-ABC3-DF65DE698384"),
                name = "secret",
                value = "314609BE-EF94-41A9-905F-BBFD7EDBCD6C",
            };
        }
    }
}
