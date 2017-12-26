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
    public class apiconfig : api_config
    {
        public apiconfig(string file)
        {
            this.file = file;
        }

        public override api read()
        {
            this.Touch(file);

            string json = File.ReadAllText(file);
            api f = JsonConvert.DeserializeObject<api>(json);
            if(null == f)
            {
                f = new api();
            }

            return f;
        }

        public override bool write(api f)
        {
            string json = JsonConvert.SerializeObject(f);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
