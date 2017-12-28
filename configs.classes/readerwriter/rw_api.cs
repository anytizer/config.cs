using configs.classes.interfacing;
using configs.classes.structures;
using Newtonsoft.Json;
using System.IO;

namespace configs.classes.readerwriter
{
    public class rw_api : config_api
    {
        public rw_api(string file)
        {
            this.filename = file;
        }

        public override structure_api read()
        {
            this.Touch(filename);

            string json = File.ReadAllText(filename);
            json = decrypt(json);

            structure_api s = JsonConvert.DeserializeObject<structure_api>(json);
            if (null == s)
            {
                s = new structure_api();
            }

            return s;
        }

        public override bool write(structure_api s)
        {
            string json = JsonConvert.SerializeObject(s);
            json = encrypt(json);

            File.WriteAllText(filename, json);
            return true;
        }
    }
}
