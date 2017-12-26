using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.structures
{
    public class structure_api
    {
        public structure key;
        public structure secret;

        public structure_api()
        {
            key = new structure() {
                id = new Guid("0AA0C665-C07E-458E-9A4F-DD638E7578B1"),
                name = "host",
                value = "localhost",
            };

            secret = new structure()
            {
                id = new Guid("C2E3483D-C14C-46A7-ABC3-DF65DE698384"),
                name = "port",
                value = "3306",
            };
        }
    }
}
