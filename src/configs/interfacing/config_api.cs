using configs.readerwriter;
using configs.structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.interfacing
{
    public abstract class config_api : iconfigwriter
    {
        public abstract structure_api read();
        public abstract bool write(structure_api f);
    }
}
