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
    public class rw_user : config_user
    {
        public rw_user(string file)
        {
            this.file = file;
        }

        public override structure_user read()
        {
            this.Touch(file);

            string json = decrypt(File.ReadAllText(file));
            structure_user s = JsonConvert.DeserializeObject<structure_user>(json);
            if(null == s)
            {
                s = new structure_user();
            }

            return s;
        }

        public override bool write(structure_user s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText(file, encrypt(json));
            return true;
        }
    }
}
