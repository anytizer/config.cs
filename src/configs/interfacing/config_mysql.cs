using configs.classes.structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.interfacing
{
    public abstract class config_mysql : iconfigwriter
    {
        public abstract structure_mysql read();
        public abstract bool write(structure_mysql s);
    }
}
