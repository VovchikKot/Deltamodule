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
        public BitArray ContiniousSearchInBitArray(BitArray inBitArray, int minvalue, int maxvalue)
        {
            

            for (int i = minvalue; i <= maxvalue; i++)
                {
                    for (int j = 1; j <=2*i; j++)
                    {
                        for (int k = 1; k <= i; k++)
                        {
                            if (inBitArray[j]==inBitArray[i+1])
                            {
                                countOK++;
                            }
                        
                        }
                        
                    }


                }


        }

        

    }
}
