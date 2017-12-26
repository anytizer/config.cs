using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configs
{
    // @see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces

    public abstract class iconfigwriter
    {
        //public abstract T Parameters<T> { get; set; }

        public void Touch(string fileName)
        {
            FileStream s = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            s.Close();
            s.Dispose();
            File.SetLastWriteTimeUtc(fileName, DateTime.UtcNow);
        }
    }
}
