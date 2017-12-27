using configs.readerwriter;
using configs.structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.interfacing
{
    public abstract class config_ftp : iconfigwriter
    {
        public abstract structure_ftp read();
        public abstract bool write(structure_ftp s);
    }
}
