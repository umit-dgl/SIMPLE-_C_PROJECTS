using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.a
{
    public partial class Form1 : Form
    {
        int tek = 0, cift = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = Convert.ToInt32(txtgoster.Text);
            if (say % 2 == 0)
            {
                lblcift.Text += say.ToString() + " ";
                cift += say;
            }
            else
            {
                lbltek.Text += say.ToString() + " ";
                tek += say;
            }

            txtgoster.Text = "";
            label5.Text = " Çiftlerin Toplamı:   " + cift + " teklerin toplamı:   " + tek;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
