using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_ftp : config_ftp
    {
        public rw_ftp(string file)
        {
            this.filename = file;
        }

        public override structure_ftp read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_ftp s = JsonConvert.DeserializeObject<structure_ftp>(json);
            if (null == s)
            {
                s = new structure_ftp();
            }

            return s;
        }

        public override bool write(structure_ftp s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
