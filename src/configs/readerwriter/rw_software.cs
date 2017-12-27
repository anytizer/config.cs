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
    public class rw_software : config_software
    {
        public rw_software(string file)
        {
            this.file = file;
        }

        public override structure_software read()
        {
            this.Touch(file);

            string json = decrypt(File.ReadAllText(file));
            structure_software s = JsonConvert.DeserializeObject<structure_software>(json);
            if(null == s)
            {
                s = new structure_software();
            }

            return s;
        }

        public override bool write(structure_software s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText(file, encrypt(json));
            return true;
        }
    }
}
