using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI.Single
{
    /// <summary>
    /// 指定房间修改
    /// </summary>
    public partial class FrmRoom : Form
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmRoom()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
