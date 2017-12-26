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

            string json = File.ReadAllText(file);
            structure_api f = JsonConvert.DeserializeObject<structure_api>(json);
            if(null == f)
            {
                f = new structure_api();
            }

            return f;
        }

        public override bool write(structure_api f)
        {
            string json = JsonConvert.SerializeObject(f);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
