using System;

namespace configs.classes.structures
{
    public class structure_software
    {
        public structure id;
        public structure notes;

        public structure_software()
        {
            id = new structure()
            {
                id = new Guid("2527E307-FA43-4811-B220-D79B04859AF9"),
                name = "id",
                value = "08B0F230-6501-4009-8F4D-DE5FBAAF2FB3",
            };

            notes = new structure()
            {
                id = new Guid("2D417700-2B38-4FBD-B5AB-E6EB82F32F17"),
                name = "notes",
                value = "My Software Identity",
            };
        }
    }
}
