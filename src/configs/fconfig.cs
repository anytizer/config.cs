using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs
{
    public abstract class fconfig : iconfigwriter
    {
        public abstract ftp read();
        public abstract bool write(ftp f);
    }
}
