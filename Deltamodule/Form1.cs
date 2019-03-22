using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Media;
using System.Windows.Shapes;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using MessageBox = System.Windows.Forms.MessageBox;

using System.Windows.Forms.Integration;

namespace Deltamodule
{
    public partial class Form1 : Form
    {
        

        private int z=0;
        public string direcopen;
        public string direcsave;
        
        
        public  Form1(string x, string y)
        {
          
           InitializeComponent();
           direcopen = x;
           direcsave = y;
        }
        public  int Z { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked==true&checkBox2.Checked==false)
            {
                #region ReadWriteSomeDataFromFile

                
                ReadandWriteSomeBytes RWriteSomeBytes = new ReadandWriteSomeBytes();
                BitArray bitfromfile = RWriteSomeBytes.ReadSomeDataFromFile(direcopen, Convert.ToInt16(textBox2.Text));
                Akf akfforbits = new Akf();
                int[] ResultofAkf = new int[bitfromfile.Length];
                ResultofAkf = akfforbits.shifter(bitfromfile, shift.Right);
                int[] graph = new Int32[bitfromfile.Length];
                for (int i = 0; i < bitfromfile.Length; i++)
                {
                    graph[i] = i;
                }

                chart1.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
                chart1.Series[0].Points.DataBindXY(graph, ResultofAkf);
                Z = 12;

                //#region ReadandWriteallFile
                //ReadWriteFile RWFile = new ReadWriteFile();
                //BitArray bitfromfile = RWFile.ReadDataFromFile(direcopen);
                //Akf akfforbits = new Akf();
                //int[] ResultofAkf = new int[bitfromfile.Length / 8];
                //ResultofAkf = akfforbits.shifter(bitfromfile, shift.Right);
                //int [] graph = new Int32[bitfromfile.Length];
                //for (int i = 0; i < bitfromfile.Length; i++)
                //{
                //    graph[i] = i;
                //}

                //chart1.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
                //chart1.Series[0].Points.DataBindXY(graph, ResultofAkf);

                //Z = 12;

                #endregion

            }
            

            else if (checkBox1.Checked == false & checkBox2.Checked == true)
            {

                #region test firstContiniousSearch

                ReadandWriteSomeBytes RWriteSomeBytes = new ReadandWriteSomeBytes();
                BitArray bitfromfile =
                    RWriteSomeBytes.ReadSomeDataFromFile(direcopen, Convert.ToInt16(textBox2.Text) * 2);
                ContiniousSearch firstContiniousSearch = new ContiniousSearch();
                double[][] masresult = new double[2][]; //Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox1.Text)
                masresult = firstContiniousSearch.ContiniousSearchInBitArray(bitfromfile,
                    Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
                double[] resultofsearsh = new double[Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox1.Text)];
                double[] vagperiodu = new double[Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox1.Text)];
                resultofsearsh=masresult[0];
                vagperiodu=masresult[1];
                
                double[] masresalt1 = new double[resultofsearsh.Length];

                for (int i = 0; i < resultofsearsh.Length; i++)
                {
                    if (resultofsearsh[i] >= 0.25F)
                    {
                        masresalt1[i] = resultofsearsh[i];
                    }

                    if (resultofsearsh[i] < 0.25F)
                    {
                        masresalt1[i] = 0;
                    }


                }

                
                int[] graph = new int[resultofsearsh.Length];

                for (int i = 0; i < resultofsearsh.Length; i++)
                {
                    graph[i] = i;
                }

                chart1.Series[0].Points.DataBindXY(graph, masresalt1);
                
               
            }

             else if (checkBox1.Checked & checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                MessageBox.Show("Оберіть один із методів");
            }
            #endregion
            #region ReadWriteSomeDataFromFile




            //ReadandWriteSomeBytes RWriteSomeBytes = new ReadandWriteSomeBytes();
            //BitArray bitfromfile = RWriteSomeBytes.ReadSomeDataFromFile(direcopen, Convert.ToInt16(textBox2.Text));
            //Akf akfforbits = new Akf();
            //int[] ResultofAkf = new int[bitfromfile.Length];
            //ResultofAkf = akfforbits.shifter(bitfromfile, shift.Right);
            //int[] graph = new Int32[bitfromfile.Length];
            //for (int i = 0; i < bitfromfile.Length; i++)
            //{
            //    graph[i] = i;
            //}

            //chart1.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
            //chart1.Series[0].Points.DataBindXY(graph, ResultofAkf);

            //BitArray inverseArray = new BitArray(bitfromfile.Length);
            //RWriteSomeBytes.WriteSomeDataInFile();
            //Z = 12;

            #endregion









        }

        private void button2_Click(object sender, EventArgs e)
        {


            #region writeToNewFile
            ReadToNewFile fileReadWriteFile = new ReadToNewFile();
            fileReadWriteFile.WriteDataInFile(fileReadWriteFile.ReadDataFromFile(direcopen), direcsave);
            #endregion
            Z = 1280;
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z = 0;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
