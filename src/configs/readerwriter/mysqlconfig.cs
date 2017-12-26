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
    public class mysqlconfig : mconfig
    {
        public mysqlconfig(string file)
        {
            this.file = file;
        }

        public override mysql read()
        {
            this.Touch(file);

            string json = File.ReadAllText(file);
            mysql m = JsonConvert.DeserializeObject<mysql>(json);
            if(null == m)
            {
                m = new mysql();
            }

            return m;
        }

        public override bool write(mysql m)
        {
            string json = JsonConvert.SerializeObject(m);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
