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

            string json = File.ReadAllText(file);
            structure_user f = JsonConvert.DeserializeObject<structure_user>(json);
            if(null == f)
            {
                f = new structure_user();
            }

            return f;
        }

        public override bool write(structure_user f)
        {
            string json = JsonConvert.SerializeObject(f);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
