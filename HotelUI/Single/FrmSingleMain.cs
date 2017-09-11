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
    public partial class FrmSingleMain : Form
    {
        /// <summary>
        /// 房间ID
        /// </summary>
        public string RoomId;
        /// <summary>
        /// 构造 方法
        /// </summary>
        public FrmSingleMain()
        {
            InitializeComponent();
        }
        private void FrmSingleMain_Load(object sender, EventArgs e)
        {
            this.Text = RoomId + "房间";
        }
    }
}
