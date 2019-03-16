using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace Deltamodule

{
    public enum shift
    {
        Right,
        Left
    }
    class Akf

    {
       public int [] shifter(BitArray inArray, shift shiftside )
        {
           
            // bool first = inArray[0];
            // bool last = inArray[inArray.Length - 1];
            BitArray inBitArray = new BitArray(inArray.Length);
            BitArray inBitArrayWithoutShift = new BitArray(inArray.Length);
            int count1 = 0;
            foreach (bool value in inArray)
            {
                inBitArrayWithoutShift[count1] = value;
                count1++;
            }

            int  [] R = new int[inArray.Length]; 

            if (shiftside == shift.Right)
            {
                for (int j = 0; j < inArray.Length; j++)
                {

                    bool last = inArray[inArray.Length - 1];

                    for (int i = 0; i < inArray.Length-1; i++)
                       
                    {
                        inBitArray[i + 1] = inArray[i];
                    }

                    inBitArray[0] = last;

                    int r = 0;
                    for (int i = 0; i < inArray.Length; i++)
                    {

                        if (inBitArrayWithoutShift[i] == inBitArray[i])
                        {
                            r++;
                        }

                        int count = 0;
                    foreach (bool value in inBitArray)
                    {
                        inArray[count] = value;
                        count++;
                    }

                   
                    }

                    R[j] = r;
                    // inArray.Length; 

                }

            }

            if (shiftside == shift.Left)
            {

                for (int j = 0; j < inArray.Length; j++)
                {

                    int r = 0;
                    bool first = inArray[0];
                    for (int i = inArray.Length - 1; i >= 1; i--)
                    {
                        

                        inBitArray[i - 1] = inArray[i];
                    }
                    inBitArray[inArray.Length-1] = first;

                    int count = 0;
                    foreach (bool value in inBitArray)
                    {
                        inArray[count] = value;
                        count++;
                    }

                    r = 0;
                    for (int i = 0; i < inArray.Length; i++)
                    {

                        if (inBitArrayWithoutShift[i] == inArray[i])
                        {
                            r++;
                        }
                    }
                    R[j] = r / inArray.Length;


                }
                //  inArray[0] = last;
                
            }


            return R;
        }
     

    }
}
