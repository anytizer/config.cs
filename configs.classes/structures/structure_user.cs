using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.structures
{
    public class structure_user
    {
        public structure id;
        public structure username;
        public structure password;

        public structure_user()
        {
            id = new structure()
            {
                id = new Guid("C3FF708E-47DA-4ED3-A5A6-4CA8F1DE340B"),
                name = "id",
                value = "id",
            };

            username = new structure()
            {
                id = new Guid("4BAD7647-9E9B-4D13-B2D2-9186FACE12E2"),
                name = "username",
                value = "username",
            };

            password = new structure()
            {
                id = new Guid("FD83348C-26B1-4C22-920A-E091986795C9"),
                name = "password",
                value = "password",
            };
        }
    }
}
