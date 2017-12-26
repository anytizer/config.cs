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
    public class rw_mysql : config_mysql
    {
        public rw_mysql(string file)
        {
            this.file = file;
        }

        public override structure_mysql read()
        {
            this.Touch(file);

            string json = File.ReadAllText(file);
            structure_mysql m = JsonConvert.DeserializeObject<structure_mysql>(json);
            if(null == m)
            {
                m = new structure_mysql();
            }

            return m;
        }

        public override bool write(structure_mysql m)
        {
            string json = JsonConvert.SerializeObject(m);
            File.WriteAllText(file, json);
            return true;
        }
    }
}
