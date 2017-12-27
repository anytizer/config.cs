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
    public class rw_api : config_api
    {
        public rw_api(string file)
        {
            this.file = file;
        }

        public override structure_api read()
        {
            this.Touch(file);

            string json = decrypt(File.ReadAllText(file));
            structure_api s = JsonConvert.DeserializeObject<structure_api>(json);
            if(null == s)
            {
                s = new structure_api();
            }

            return s;
        }

        public override bool write(structure_api s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText(file, encrypt(json));
            return true;
        }
    }
}
