using Hotel.DAL;
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
        /// 实例化命令类
        /// </summary>
        FrmSingleMainComm singleMainComm = new FrmSingleMainComm();

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

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmSingleMain_Load(object sender, EventArgs e)
        {
            this.Text = RoomId + "房间";
            int judge = singleMainComm.GetStatistics(this.RoomId);
            if (judge == 1)
            {
                panel1.Hide();
                panel3.Hide();
                this.ClientSize = new System.Drawing.Size(200, 400);
                panel2.Location = new Point(0, 0);
                panel4.Location = new Point(0, 200);
            }
            else if (judge == 2)
            {
                panel2.Hide();
                panel4.Hide();
                this.ClientSize = new System.Drawing.Size(200, 400);
            }
            else
            {
                panel2.Hide();
                panel3.Hide();
                panel4.Hide();
                this.ClientSize = new System.Drawing.Size(200, 200);
            }
        }

        /// <summary>
        /// 状态类型
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void pbxRoom_Click(object sender, EventArgs e)
        {
            FrmRoom frmRoom = new FrmRoom() { id = this.RoomId };
            frmRoom.ShowDialog();
        }

        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void pbxCheck_Click(object sender, EventArgs e)
        {
            FrmCheck check = new FrmCheck() { roomId = Convert.ToInt32(this.RoomId) };
            check.ShowDialog();
        }

        /// <summary>
        /// 人员信息
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void pbxSeeInfo_Click(object sender, EventArgs e)
        {
            FrmSingleGuestInfo guestInfo = new FrmSingleGuestInfo() {  RoomId=this.RoomId };
            guestInfo.ShowDialog();
        }
    }
}
