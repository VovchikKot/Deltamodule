using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            #region ReadandWriteallFile
            //ReadWriteFile RWFile = new ReadWriteFile();
            //BitArray bitfromfile = RWFile.ReadDataFromFile(direcopen);
            //Akf akfforbits = new Akf();
            //int[] ResultofAkf = new int[bitfromfile.Length / 8];
            //ResultofAkf = akfforbits.shifter(bitfromfile, shift.Right);
            //int[] graph = new Int32[bitfromfile.Length];
            //for (int i = 0; i < bitfromfile.Length; i++)
            //{
            //    graph[i] = i;
            //}

            //chart1.ChartAreas[0].AxisX.MinorGrid.Interval = 1;
            //chart1.Series[0].Points.DataBindXY(graph, ResultofAkf);
            //BitArray inverseArray = new BitArray(bitfromfile.Length);
            //inverseArray = bitfromfile.Not();
            //myFile.WriteDataInFile(inverseArray, direcsave);
            //Z = 12;
            //
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

            #region test firstContiniousSearch

            ReadandWriteSomeBytes RWriteSomeBytes = new ReadandWriteSomeBytes();
            BitArray bitfromfile = RWriteSomeBytes.ReadSomeDataFromFile(direcopen, Convert.ToInt16(textBox2.Text)*2);
            ContiniousSearch firstContiniousSearch = new ContiniousSearch();
            double [] masresult =new double[Convert.ToInt16(textBox2.Text)-Convert.ToInt16(textBox1.Text)];
            masresult = firstContiniousSearch.ContiniousSearchInBitArray(bitfromfile, Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
              

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Z = 47;
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z = 0;
            Close();
        }
    }
}
