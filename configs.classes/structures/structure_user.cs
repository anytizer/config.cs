using System;

namespace configs.classes.structures
{
    public class structure_user
    {
        private structure _username;
        private structure _password;

        public string username { get { return _username.value; } set { _username.value = value; } }
        public string password { get { return _password.value; } set { _password.value = value; } }

        public structure_user()
        {
            _username = new structure()
            {
                id = new Guid("4BAD7647-9E9B-4D13-B2D2-9186FACE12E2"),
                name = "username",
                value = "username",
            };

            _password = new structure()
            {
                id = new Guid("FD83348C-26B1-4C22-920A-E091986795C9"),
                name = "password",
                value = "password",
            };
        }
    }
}
