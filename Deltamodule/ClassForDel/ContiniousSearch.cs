using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace Deltamodule
{
    class ContiniousSearch
    {
        public int countOK = 0;
        public int count1 = 0;
        public int count0 = 0;
        public double [][] ContiniousSearchInBitArray(BitArray inBitArray, int minvalue, int maxvalue)
        {
            double [][] resalt = new double[2][];
            resalt[0]=new double[maxvalue + minvalue];
            resalt[1]= new double[maxvalue + minvalue];
            double [] resultofsearsh = new double[maxvalue+minvalue];
            double[]  vagperiodu= new double[maxvalue + minvalue];

            for (int i = minvalue; i < maxvalue; i++)
                {
                countOK = 0;
                count1 = 0;
                count0 = 0;
                for (int k = minvalue; k <=i; k++)
                        {
                            if (inBitArray[k]==inBitArray[i+k])
                            {
                                countOK++;
                                
                            }
                            if (inBitArray[k] == true)
                            {
                                count1++;
                            }
                            //else if (inBitArray[k] == false)
                            //{
                            //    count0++;
                            //}

                }

                    resultofsearsh[i] = (double)countOK / i;
                    if (count1>0)
                    {
                       
                            vagperiodu[i] = (double)count1 /i;
                        
                    }

                    else
                    {
                        vagperiodu[i] = 0;
                    }
                    

                    
                    
                }

            resalt[0] = resultofsearsh;
            resalt[1] = vagperiodu;
            return  resalt;

        }

        

    }
}
