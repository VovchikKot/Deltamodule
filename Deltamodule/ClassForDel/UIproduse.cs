using System;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Deltamodule
{
    class UIproduse
    {
        
            public Shape [] ReturunElement(int value)
            {

                Shape[] myShapes1 = new Rectangle[value];
                BitArray DatainBitArray = new BitArray(value);
                Random rand = new Random();

                double trueProbability = 0.5;




                for (int i = 0; i < value; i++)
                {
                    DatainBitArray[i] = rand.NextDouble() < trueProbability;
                }
                for (int i = 0; i < value; i++)
                {

                    myShapes1[i] = new Rectangle();
                    myShapes1[i].Width = 3;
                    myShapes1[i].Height = 3;
                    myShapes1[i].HorizontalAlignment = HorizontalAlignment.Left;

                    if (DatainBitArray[i] == true)
                    {

                        myShapes1[i].Fill = Brushes.Black;
                    }
                    else
                    {
                        myShapes1[i].Fill = Brushes.White;
                        myShapes1[i].Opacity = 0;
                    }

                }

                return myShapes1;

            }


     }
    
}
