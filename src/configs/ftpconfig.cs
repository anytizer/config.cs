using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs
{
    public class ftpconfig : fconfig
    {
        string file = "ftp.settings";
        public ftpconfig(string file)
        {
            this.file = file;
        }

        public override ftp read()
        {
            this.Touch(file);

            string json = File.ReadAllText(file);
            ftp f = JsonConvert.DeserializeObject<ftp>(json);
            if(null == f)
            {
                f = new ftp();
            }

            return f;
        }

        public override bool write(ftp f)
        {
            string json = JsonConvert.SerializeObject(f);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
