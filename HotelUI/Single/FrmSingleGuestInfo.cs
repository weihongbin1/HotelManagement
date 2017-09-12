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
    public partial class FrmSingleGuestInfo : Form
    {
        /// <summary>
        /// 实例化命令类
        /// </summary>
        FrmGuestInfoComm guestInfoComm = new FrmGuestInfoComm();

        /// <summary>
        ///房间编号
        /// </summary>
        public string RoomId { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmSingleGuestInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载信息
        /// </summary>
        private void LoadInfo()
        {
            GuestRecord guest = guestInfoComm.SLoadOrder(RoomId);
            txtName.Text = guest.Name;
            txtId.Text = guest.CardNo;
            txtPhone.Text = guest.Phone;
            txtSex.Text = guest.SexStr;
            txtDeposit.Text = guest.Deposit.ToString();
            txtArrivalDate.Text = guest.ArrivalDate.ToString();
            string gid = guest.ID.ToString();
            CheckOutInfo outInfo = guestInfoComm.CheckOutInfo(gid);
            txtRoomTotal.Text = outInfo.RoomTotal.ToString();
            txtFoodTotal.Text = outInfo.FoodTotal.ToString();
            txtMoney.Text = outInfo.TotalAmount.ToString();

        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmSingleGuestInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            guestInfoComm.SCheckOut(txtRoomTotal.Text.Trim(),txtFoodTotal.Text.Trim(),RoomId);
            MessageBox.Show("退房成功");
            this.Close();
        }
    }
}
