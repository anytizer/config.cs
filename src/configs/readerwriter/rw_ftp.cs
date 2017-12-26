using configs.interfacing;
using configs.structures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.readerwriter
{
    public class rw_ftp : config_ftp
    {
        public rw_ftp(string file)
        {
            this.file = file;
        }

        public override structure_ftp read()
        {
            this.Touch(file);

            string json = File.ReadAllText(file);
            structure_ftp f = JsonConvert.DeserializeObject<structure_ftp>(json);
            if(null == f)
            {
                f = new structure_ftp();
            }

            return f;
        }

        public override bool write(structure_ftp f)
        {
            string json = JsonConvert.SerializeObject(f);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
