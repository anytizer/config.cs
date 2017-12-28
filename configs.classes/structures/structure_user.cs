using System;

namespace configs.classes.structures
{
    public class structure_user
    {
        public structure username;
        public structure password;

        public structure_user()
        {
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
