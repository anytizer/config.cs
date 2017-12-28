using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_user : config_user
    {
        public rw_user(string file)
        {
            this.filename = file;
        }

        public override structure_user read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_user s = JsonConvert.DeserializeObject<structure_user>(json);
            if (null == s)
            {
                s = new structure_user();
            }

            return s;
        }

        public override bool write(structure_user s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
