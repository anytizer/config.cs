using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs
{
    public abstract class mconfig : iconfigwriter
    {
        public abstract mysql read();
        public abstract bool write(mysql m);
    }
}
