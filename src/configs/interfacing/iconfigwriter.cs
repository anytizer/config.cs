using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs.interfacing
{
    // @see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces

    public abstract class iconfigwriter
    {
        //public abstract T Parameters<T> { get; set; }
        public string file = "filename.settings";

        public void Touch(string fileName)
        {
            FileStream s = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            s.Close();
            s.Dispose();
            File.SetLastWriteTimeUtc(fileName, DateTime.UtcNow);
        }

        public string encrypt(string s)
        {
            return s;
        }

        public string decrypt(string s)
        {
            return s;
        }
    }
}
