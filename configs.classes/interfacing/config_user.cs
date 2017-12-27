using configs.classes.structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.interfacing
{
    public abstract class config_user : iconfigwriter
    {
        public abstract structure_user read();
        public abstract bool write(structure_user s);
    }
}
