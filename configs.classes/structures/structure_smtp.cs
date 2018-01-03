using System;

namespace configs.classes.structures
{
    public class structure_smtp
    {
        public structure username;
        public structure password;
        public structure server;
        public structure port;
        public structure FromEmail;
        public structure FromName;

        public structure_smtp()
        {
            username = new structure()
            {
                id = new Guid("CE69E2BB-F4EA-4F21-8028-0FF169AE75DC"),
                name = "username",
                value = "username",
            };

            password = new structure()
            {
                id = new Guid("12FAA87B-79E0-4063-A5DC-9AA68C4EBE34"),
                name = "password",
                value = "password",
            };

            server = new structure()
            {
                id = new Guid("8F076E52-91BA-41D8-AD87-E42B28D5C3A8"),
                name = "server",
                value = "smtp.gmail.com",
            };

            port = new structure()
            {
                id = new Guid("2516A070-49D2-461C-8692-1BB4D454D18A"),
                name = "port",
                value = "587",
            };

            FromEmail = new structure()
            {
                id = new Guid("F463F147-C519-4676-BED4-5B26FD980444"),
                name = "FromEmail",
                value = "sender@example.com",
            };

            FromName = new structure()
            {
                id = new Guid("FDE5521C-E624-4E5A-885C-61F070D2AEDF"),
                name = "FromName",
                value = "Sender",
            };
        }
    }
}
