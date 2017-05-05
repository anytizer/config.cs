using PropertiesReader.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesReader
{
    public class reader
    {
        public string read(string index)
        {
            Settings s = new Settings();
            string value = "";

            try
            {
                switch (index)
                {
                    case "hostname":
                        value = s.hostname;
                        break;
                    case "database":
                        value = s.database;
                        break;
                    case "username":
                        value = s.username;
                        break;
                    case "password":
                        value = s.password;
                        break;
                    case "port":
                        value = s.port;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception)
            {
                value = "";
            }

            return value;
        }
    }
}
