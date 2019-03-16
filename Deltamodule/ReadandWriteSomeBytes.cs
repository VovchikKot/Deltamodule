using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deltamodule
{
    class ReadandWriteSomeBytes
    {
        public BitArray  ReadSomeDataFromFile(string fileopename, int maxperiod)
        {
            string openName = fileopename;
            FileStream StreamReaderfordata = new FileStream(openName,FileMode.OpenOrCreate);
            byte [] SomeData = new byte[maxperiod/8];
            StreamReaderfordata.Read(SomeData, 0, SomeData.Length);
            StreamReaderfordata.Close();
            BitArray fileopendatainbits = new BitArray(SomeData);
            return fileopendatainbits;
        }

        public void WriteSomeDataInFile(BitArray fileopendatainbits, string filewriteName)
        {
            byte[] WriteByte = new byte[BitArrayToByteArray(fileopendatainbits).Length];
            WriteByte = BitArrayToByteArray(fileopendatainbits);
            FileStream WriteSomeDataInFile = new FileStream(filewriteName, FileMode.OpenOrCreate);
            WriteSomeDataInFile.Write(WriteByte,0,WriteByte.Length);
            WriteSomeDataInFile.Close();

        }
        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }
    }
}
