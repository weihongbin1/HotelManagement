using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = iltAbout.Images[i];
            i++;
            if (i==11)
            {
                i = 0;
            }
        }
    }
}
