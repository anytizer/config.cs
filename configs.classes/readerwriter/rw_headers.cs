using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_headers : config_headers
    {
        public rw_headers(string file)
        {
            this.filename = file;
        }

        public override structure_headers read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_headers s = JsonConvert.DeserializeObject<structure_headers>(json);
            if (null == s)
            {
                s = new structure_headers();
            }

            return s;
        }

        public override bool write(structure_headers s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
