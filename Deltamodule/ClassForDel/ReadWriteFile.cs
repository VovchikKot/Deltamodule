using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deltamodule
{
    class ReadWriteFile
    {
        public BitArray  ReadDataFromFile (string fileopename)
        {
            string openName = fileopename;
            BitArray fileopendatainbits= new BitArray(File.ReadAllBytes(openName));
            return fileopendatainbits;
        }

        public  void WriteDataInFile(BitArray fileopendatainbits, string filewriteName )
        {
            byte [] WriteByte = new byte[BitArrayToByteArray(fileopendatainbits).Length];
            WriteByte = BitArrayToByteArray(fileopendatainbits);
            
            File.WriteAllBytes(filewriteName, WriteByte);
        }

        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }
    }
}
