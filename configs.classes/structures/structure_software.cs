using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.structures
{
    public class structure_software
    {
        public structure id;
        public structure notes;

        public structure_software()
        {
            id = new structure() {
                id = new Guid("2527E307-FA43-4811-B220-D79B04859AF9"),
                name = "id",
                value = "id",
            };

            notes = new structure()
            {
                id = new Guid("2D417700-2B38-4FBD-B5AB-E6EB82F32F17"),
                name = "notes",
                value = "notes",
            };
        }
    }
}
