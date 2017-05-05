using PropertiesReader;
using System;
using System.Runtime;

namespace PropertiesReader
{
    public class reader
    {
        public string read(string index)
        {
            settings s = new settings();
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

        public string environment()
        {
            string environment = null;
            string environment_temp = new environments().environment;

            switch (environment_temp.ToLower())
            {
                case "live":
                case "publish":
                case "prod":
                case "production":
                case "release":
                    environment = "live";
                    break;
                case "test":
                case "debug":
                case "staging":
                case "demo":
                    environment = "staging";
                    break;
                case "dev":
                case "lan":
                case "local":
                case "internal":
                    environment = "dev";
                    break;
                default:
                    environment = "dev";
                    break;
            }

            return environment;
        }
    }
}
