using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_mysql : config_mysql
    {
        public rw_mysql(string file)
        {
            this.filename = file;
        }

        public override structure_mysql read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_mysql s = JsonConvert.DeserializeObject<structure_mysql>(json);
            if (null == s)
            {
                s = new structure_mysql();
            }

            return s;
        }

        public override bool write(structure_mysql s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
