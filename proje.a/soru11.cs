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
    public partial class soru11 : Form
    {
        public soru11()
        {
            InitializeComponent();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            int topla = 0;
            int n = Convert.ToInt32(txtgoster.Text);
            for(int i =1; i <=n; i++)
            {
                topla += i * i;
            }
            label5.Text = "SONUÇ: " + topla;
        }
    }
}
