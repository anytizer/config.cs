using System;

namespace configs.classes.structures
{
    public class structure_api
    {
        private structure _key;
        private structure _secret;

        public string key { get { return _key.value; } set { _key.value = value; } }
        public string secret { get { return _secret.value; } set { _secret.value = value; } }

        public structure_api()
        {
            _key = new structure()
            {
                id = new Guid("0AA0C665-C07E-458E-9A4F-DD638E7578B1"),
                name = "key",
                value = "927B71A8-68DA-474F-B9AB-A9852DF14AAB",
            };

            _secret = new structure()
            {
                id = new Guid("C2E3483D-C14C-46A7-ABC3-DF65DE698384"),
                name = "secret",
                value = "314609BE-EF94-41A9-905F-BBFD7EDBCD6C",
            };
        }
    }
}
