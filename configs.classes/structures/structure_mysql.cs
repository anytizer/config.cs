using System;

namespace configs.classes.structures
{
    public class structure_mysql
    {
        public structure host;
        public structure port;
        public structure username;
        public structure password;
        public structure database;

        public structure_mysql()
        {
            host = new structure()
            {
                id = new Guid("9474AB3B-717B-46CC-9915-C843DA66DDC5"),
                name = "host",
                value = "localhost",
            };

            port = new structure()
            {
                id = new Guid("C04075C6-EEA4-45AD-8AD8-EAF2977A1818"),
                name = "port",
                value = "3306",
            };

            username = new structure()
            {
                id = new Guid("5665E34B-B6E6-41C5-A7F2-B30E502373FE"),
                name = "username",
                value = "root",
            };

            password = new structure()
            {
                id = new Guid("6827C47A-4A65-41C8-87AC-94F61E96B63F"),
                name = "password",
                value = "password",
            };

            database = new structure()
            {
                id = new Guid("7A33CB80-31FD-46F2-814D-5CFAB89F345D"),
                name = "database",
                value = "database",
            };
        }
    }
}
