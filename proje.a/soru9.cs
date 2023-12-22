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
    public partial class soru9 : Form
    {
        public soru9()
        {
            InitializeComponent();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            double f = 0;
            int n = Convert.ToInt32(txtgoster.Text);
            for (int i = 1; i<=n; i++)
            {
                f = f + 1 / Convert.ToDouble(i * i);

            }
            label5.Text = "Denklemin Sonucu: " + f;


        }
    }
}
