using hashing.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.classes.interfacing
{
    // @see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces

    public abstract class iconfigwriter
    {
        //public abstract T Parameters<T> { get; set; }
        public string file = "filename.settings";

        /**
         * Determine if the configuration file should be unreadable
         */
        private bool protection = true;

        /**
         * Makes sure that at least a blank file exists.
         * @see http://man7.org/linux/man-pages/man1/touch.1.html
         */
        public void Touch(string fileName)
        {
            FileStream s = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            s.Close();
            //s.Dispose();
            File.SetLastWriteTimeUtc(fileName, DateTime.UtcNow);
        }

        public string encrypt(string s)
        {
            if(protection)
            {
                hasher h = new hasher();
                string s_encrypted = h.base64_encode(s);
                return s_encrypted;
            }
            else
            {
                return s;
            }
        }

        public string decrypt(string s)
        {
            if(protection)
            {
                hasher h = new hasher();
                string s_decrypted = h.base64_decode(s);
                return s_decrypted;
            }
            else
            {
                return s;
            }            
        }
    }
}
