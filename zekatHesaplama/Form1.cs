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
            double ZekatMiktari;
            double zekatAltinGr;
            zekatAltinGr = Convert.ToDouble(textBox1.Text) / 975;
            if (zekatAltinGr >= 80.18)
            {
                ZekatMiktari = (zekatAltinGr / 40) * 975;
                MessageBox.Show("zekat miktarı" + ZekatMiktari.ToString());
            }
            else
            {
                MessageBox.Show("zekat vermek için paranız yeterli değil");
            }
        }

    }
}
