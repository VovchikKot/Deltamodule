using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltamodule
{
    class ReadToNewFile
    {

        public byte [] ReadDataFromFile(string fileopename)
        {
            byte [] fileopendatainbits ;
            fileopendatainbits = File.ReadAllBytes(fileopename);
            return fileopendatainbits;
        }

        public void WriteDataInFile(byte [] fileopendatainbits, string filewriteName)
        {
           
            File.WriteAllBytes(filewriteName, fileopendatainbits);
        }

      
    }
}
