using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.structures
{
    public class structure_ftp
    {
        public structure host;
        public structure port;
        public structure username;
        public structure password;

        public structure_ftp()
        {
            host = new structure() {
                id = new Guid("450D1841-70F6-4982-A33B-4FB4B6AD5C98"),
                name = "host",
                value = "localhost",
            };

            port = new structure()
            {
                id = new Guid("4058B586-05EA-4D30-A4A8-5DBDBA291680"),
                name = "port",
                value = "21",
            };

            username = new structure()
            {
                id = new Guid("C2C5F7F5-FC81-4F8C-8FF1-2BA4C5803D45"),
                name = "username",
                value = "root",
            };

            password = new structure()
            {
                id = new Guid("20EAB695-7A6D-48A4-B4D2-4CD0B6293659"),
                name = "password",
                value = "password",
            };
        }
    }
}
