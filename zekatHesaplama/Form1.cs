using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zekatHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double dolarAltinGr;
                double ZekatMiktari;
                double zekatAltinGr;
                double TLAltinGr;
                double toplamMalMiktariAltinGr;
                
                TLAltinGr = Convert.ToDouble(textBox1.Text) / 975;
                dolarAltinGr = Convert.ToDouble(textBox2.Text) / 52;

                toplamMalMiktariAltinGr = TLAltinGr + dolarAltinGr;



                if (toplamMalMiktariAltinGr >= 80.18)
                {
                    ZekatMiktari = (toplamMalMiktariAltinGr / 40) * 975;
                    MessageBox.Show("zekat miktarı=" + ZekatMiktari.ToString());
                }
                else
                {
                    MessageBox.Show("zekat vermek için paranız yeterli değil");
                    MessageBox.Show("Zekat vermenize gerek yoktur.");
                }
            }


        }
    }
}