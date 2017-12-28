using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_software : config_software
    {
        public rw_software(string file)
        {
            this.filename = file;
        }

        public override structure_software read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_software s = JsonConvert.DeserializeObject<structure_software>(json);
            if (null == s)
            {
                s = new structure_software();
            }

            return s;
        }

        public override bool write(structure_software s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
