using System;

namespace configs.classes.structures
{
    public class structure_ftp
    {
        private structure _host;
        private structure _port;
        private structure _username;
        private structure _password;
        private structure _path;

        public string host { get { return _host.value; } set { _host.value = value; } }
        public string port { get { return _port.value; } set { _port.value = value; } }
        public string username { get { return _username.value; } set { _username.value = value; } }
        public string password { get { return _password.value; } set { _password.value = value; } }
        public string path { get { return _path.value; } set { _path.value = value; } }

        public structure_ftp()
        {
            _host = new structure()
            {
                id = new Guid("450D1841-70F6-4982-A33B-4FB4B6AD5C98"),
                name = "host",
                value = "127.0.0.1",
            };

            _port = new structure()
            {
                id = new Guid("4058B586-05EA-4D30-A4A8-5DBDBA291680"),
                name = "port",
                value = "21",
            };

            _username = new structure()
            {
                id = new Guid("C2C5F7F5-FC81-4F8C-8FF1-2BA4C5803D45"),
                name = "username",
                value = "public",
            };

            _password = new structure()
            {
                id = new Guid("20EAB695-7A6D-48A4-B4D2-4CD0B6293659"),
                name = "password",
                value = "common",
            };

            _path = new structure()
            {
                id = new Guid("8BA5EE3E-839F-4708-9D13-8E25C17033C8"),
                name = "path",
                value = "/",
            };
        }
    }
}
