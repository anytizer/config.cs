using configs.classes.structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.interfacing
{
    public abstract class config_software : iconfigwriter
    {
        public abstract structure_software read();
        public abstract bool write(structure_software s);
    }
}
