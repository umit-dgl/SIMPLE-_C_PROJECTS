using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.a
{
    public partial class soru10 : Form
    {
        public soru10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtgoster_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            double kk, x = 1, f = 0;
            kk = Convert.ToDouble(txtgoster.Text);
            while (f < kk)
            {
                f = f + 1 / (x * x);
                x++;
            }
            label5.Text = "SAĞLAYAN KATSAYI :  " + f + "EN KÜÇÜK X DEĞERİ: " + (x - 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
