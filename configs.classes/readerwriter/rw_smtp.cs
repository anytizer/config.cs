using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_smtp : config_smtp
    {
        public rw_smtp(string file)
        {
            this.filename = file;
        }

        public override structure_smtp read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_smtp s = JsonConvert.DeserializeObject<structure_smtp>(json);
            if (null == s)
            {
                s = new structure_smtp();
            }

            return s;
        }

        public override bool write(structure_smtp s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
