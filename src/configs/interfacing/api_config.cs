using configs.readerwriter;
using configs.structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.interfacing
{
    public abstract class api_config : iconfigwriter
    {
        public abstract api read();
        public abstract bool write(api f);
    }
}
