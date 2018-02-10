using System;

namespace configs.classes.structures
{
    public class structure_headers
    {
        private structure _authorization;
        public string authorization { get { return _authorization.value; } set { _authorization.value = value; } }

        public structure_headers()
        {
            /**
             * HTTP_X_AUTHORIZATION
             * HTTP_X_TOKEN
             */
            _authorization = new structure()
            {
                id = new Guid("6C7D7A9D-6484-40BD-8482-D42AD007F927"),
                name = "authorization",
                value = "F7D56A93-FABD-42E7-9500-D3CF9717F37B",
            };
        }
    }
}
