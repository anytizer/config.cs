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

            string json = decrypt(File.ReadAllText(file));
            structure_mysql s = JsonConvert.DeserializeObject<structure_mysql>(json);
            if(null == s)
            {
                s = new structure_mysql();
            }

            return s;
        }

        public override bool write(structure_mysql s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText(file, encrypt(json));
            return true;
        }
    }
}
