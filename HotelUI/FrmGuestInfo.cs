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

namespace Hotel.UI
{
    /// <summary>
    /// 顾客记录查询类
    /// </summary>
    public partial class FrmGuestInfo : Form
    {
        /// <summary>
        /// 实例化命令类
        /// </summary>
        FrmGuestInfoComm guestInfoComm = new FrmGuestInfoComm();

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmGuestInfo()
        {
            InitializeComponent();
            dgvGuestInfo.AutoGenerateColumns = false;
            dgvRecord.AutoGenerateColumns = false;

        }

        #region 输入限制
        private void txtRoomId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }
        #endregion

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmGuestInfo_Load(object sender, EventArgs e)
        {
            LoadOrder();
            CheckOutInfo();
            LoadRecord();
        }

        /// <summary>
        /// 加载客户记录(未结账)
        /// </summary>
        private void LoadOrder()
        {
            List<GuestRecord> list = guestInfoComm.LoadOrder();
            dgvGuestInfo.DataSource = list;
        }

        /// <summary>
        /// 筛选订单--按姓名查询
        /// </summary>
        /// <param name="name">客户姓名</param>
        private void ScreenOrder(string name)
        {
            List<GuestRecord> list = guestInfoComm.ScreenOrder(name);
            dgvGuestInfo.DataSource = list;
        }

        /// <summary>
        /// 筛选订单--按房间编号查询
        /// </summary>
        /// <param name="roomID">房间编号</param>
        private void ScreenOrder(int roomID)
        {
            List<GuestRecord> list = guestInfoComm.ScreenOrder(roomID);
            dgvGuestInfo.DataSource = list;
        }

        /// <summary>
        /// 按姓名筛选订单
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnByName_Click(object sender, EventArgs e)
        {
            ScreenOrder(txtName.Text.Trim());
        }

        /// <summary>
        /// 按房间ID筛选订单
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnByRoomId_Click(object sender, EventArgs e)
        {
            if (txtRoomId.Text.Trim().Length == 0)
            {
                LoadOrder();
            }
            else
            {
                ScreenOrder(Convert.ToInt32(txtRoomId.Text.Trim()));
            }
        }

        /// <summary>
        /// 信息单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void dgvGuestInfo_Click(object sender, EventArgs e)
        {
            CheckOutInfo();
        }

        /// <summary>
        /// 退房信息
        /// </summary>
        private void CheckOutInfo()
        {
            string id = dgvGuestInfo.SelectedRows[0].Cells["ID"].Value.ToString();
            CheckOutInfo outInfo = guestInfoComm.CheckOutInfo(id);
            txtDeposit.Text = outInfo.Deposit.ToString();
            txtRoomTotal.Text = outInfo.RoomTotal.ToString();
            txtFoodTotal.Text = outInfo.FoodTotal.ToString();
            txtSum.Text = outInfo.TotalAmount.ToString();
        }

        /// <summary>
        /// 确认退房
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        /// <summary>
        /// 退房
        /// </summary>
        private void CheckOut()
        {
            if (guestInfoComm.CheckOut(txtRoomTotal.Text.Trim(), txtFoodTotal.Text.Trim(), dgvGuestInfo.SelectedRows[0].Cells["ID"].Value.ToString()))
            {
                MessageBox.Show("退房成功");
                LoadOrder();
            }
            else
            {
                MessageBox.Show("退房失败");
            }
        }

        /// <summary>
        /// 加载记录
        /// </summary>
        private void LoadRecord()
        {
            List<GuestRecord> list = guestInfoComm.LoadRecord();
            dgvRecord.DataSource = list;
        }

        /// <summary>
        /// 筛选记录--按姓名筛选
        /// </summary>
        /// <param name="name">姓名</param>
        private void ScreenRecord(string name)
        {
            List<GuestRecord> list = guestInfoComm.ScreenRecord(name);
            dgvRecord.DataSource = list;
        }

        /// <summary>
        /// 筛选记录--按房间编号筛选
        /// </summary>
        /// <param name="RoomId">房间编号</param>
        private void ScreenRecord(int RoomId)
        {
            List<GuestRecord> list = guestInfoComm.ScreenRecord(RoomId);
            dgvRecord.DataSource = list;
        }

        /// <summary>
        /// 按姓名筛选记录
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnRByName_Click(object sender, EventArgs e)
        {
            ScreenRecord(txtRName.Text.Trim());
        }

        /// <summary>
        ///   按房间ID筛选记录
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnRByRoomId_Click(object sender, EventArgs e)
        {
            if (txtRRoomId.Text.Trim().Length == 0)
            {
                guestInfoComm.LoadRecord();
            }
            else
            {
                ScreenRecord(Convert.ToInt32(txtRRoomId.Text.Trim()));
            }
        }
    }
}
