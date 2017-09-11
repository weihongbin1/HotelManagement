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
        public string RoomId = "2133";
        /// <summary>
        /// 构造 方法
        /// </summary>
        public FrmSingleMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmSingleMain_Load(object sender, EventArgs e)
        {
            this.Text = RoomId + "房间";
        }

        /// <summary>
        /// 单击状态类型
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void pbxRoom_Click(object sender, EventArgs e)
        {
            FrmRoom frmRoom = new FrmRoom() { id=this.RoomId};
            frmRoom.ShowDialog();
        }
    }
}
