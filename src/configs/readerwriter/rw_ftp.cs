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

            string json = decrypt(File.ReadAllText(file));
            structure_ftp s = JsonConvert.DeserializeObject<structure_ftp>(json);
            if(null == s)
            {
                s = new structure_ftp();
            }

            return s;
        }

        public override bool write(structure_ftp s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText(file, encrypt(json));
            return true;
        }
    }
}
