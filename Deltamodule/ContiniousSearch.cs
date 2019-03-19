using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Deltamodule
{
    class ContiniousSearch
    {
        public int countOK = 0;
        public double [] ContiniousSearchInBitArray(BitArray inBitArray, int minvalue, int maxvalue)
        {
            double [] resultofsearsh = new double[maxvalue-minvalue]; 

            for (int i = minvalue; i <= maxvalue; i++)
                {
                countOK = 0;
                for (int k = 0; k < i; k++)
                        {
                            if (inBitArray[k]==inBitArray[i+k])
                            {
                                countOK++;
                            }
                        
                        }

                    resultofsearsh[i] = countOK / i;
                }

            return resultofsearsh;

        }

        

    }
}
