using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel.DAL;

namespace Hotel.UI
{

    public partial class FrmCheck : Form
    {

        /// <summary>
        /// 房间编号
        /// </summary>
        public int roomId { get; set; }

        /// <summary>
        /// 输入提示--常量
        /// </summary>
        private const string Prompt = "输入提示";

        /// <summary>
        /// 实例化入住登录命令
        /// </summary>
        FrmCheckComm checkComm = new FrmCheckComm();

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmCheck()
        {
            InitializeComponent();
        }

        #region 输入限制
        /// <summary>
        /// 限制手机号码输入只能是0-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }
        /// <summary>
        /// 限制押金输入只能是0-9和点 . 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }
        /// <summary>
        /// 限制身份证输入只能是0-9和大写X和小写x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点 ,88代表大写X,120代表小写x
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 88) && (e.KeyChar != 120))
                e.Handled = true;
        }
        #endregion

        /// <summary>
        /// 加载事件
        /// </summary>
        private void FrmCheck_Load(object sender, EventArgs e)
        {
            if (this.roomId != 0)
            {
                cbxRoom.Hide();
                cbxType.Hide();
                lblRoomId.Hide();
                lblRoomType.Hide();
            }
            BindingRoomType();
            cbxType_Click(sender, e);
            dtpArrivalDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        /// <summary>
        /// 改变房间单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void cbxType_Click(object sender, EventArgs e)
        {
            BindingRoom(cbxType.SelectedValue.ToString());
        }

        /// <summary>
        /// 绑定房间类型
        /// </summary>
        private void BindingRoomType()
        {
            List<RoomType> list = checkComm.BindingRoomType();
            this.cbxType.DataSource = list;
            this.cbxType.ValueMember = "TypeId";
            this.cbxType.DisplayMember = "TypeName";
        }

        /// <summary>
        /// 绑定房间
        /// </summary>
        private void BindingRoom(string typeId)
        {
            List<Room> list = checkComm.BindingRoom(typeId);
            cbxRoom.DataSource = list;
            cbxRoom.DisplayMember = "RoomId";
            cbxRoom.ValueMember = "TypePrice";
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>是否为空</returns>
        private bool NonEmpty()
        {
            if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return false;
            }
            else if (txtNum.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入身份证号！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNum.Focus();
                return false;
            }
            else if (txtNum.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证输入非法！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNum.Focus();
                return false;
            }
            else if (txtPhone.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入联系电话！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPhone.Focus();
                return false;
            }
            else if (txtPhone.Text.Trim().Length != 11)
            {
                MessageBox.Show("联系电话输入非法！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPhone.Focus();
                return false;
            }
            else if (txtMoney.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入押金！", Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMoney.Focus();
                return false;
            }
            else if (Convert.ToDouble(txtMoney.Text.Trim()) <= Convert.ToDouble((cbxRoom.SelectedValue)))
            {
                MessageBox.Show("押金不能低于当前房价,当前房价"+ cbxRoom.SelectedValue, Prompt, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMoney.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 确定事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        /// <summary>
        /// 登记订单
        /// </summary>
        private void Register()
        {
            if (NonEmpty())
            {
                string name = txtName.Text.Trim();
                string cardNo = txtNum.Text.Trim();
                string phone = txtPhone.Text.Trim();
                //日期格式化
                string arrivalDateStr = dtpArrivalDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                //性别
                bool sex = true;
                if (rboMale.Checked == true)
                {
                    sex = true;
                }
                else
                {
                    sex = false;
                }
                //为单个房间登记入住判断（不讲）
                if (roomId == 0)
                {
                    roomId = Convert.ToInt32(cbxRoom.Text.Trim());
                }
                //押金
                double money = Convert.ToDouble(txtMoney.Text.Trim());
                //客户信息对象初始化
                GuestInfo info = new GuestInfo() { Name = name, CardNo = cardNo, Phone = phone, Sex = sex };
                // 客户信息ID
                string guestId = string.Empty;
                if (checkComm.CheckExist(cardNo))
                {
                    guestId = checkComm.UpdateGuestInfo(info);
                }
                else
                {
                    guestId = checkComm.AddGuestInfo(info);
                }
                //订单对象初始化
                GuestRecord guest = new GuestRecord() { GuestID = Convert.ToInt32(guestId), Deposit = money, ArrivalDateStr = arrivalDateStr, RoomId = roomId };
                checkComm.AddOrder(guest);
                MessageBox.Show("登记成功");
                Initialize();
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initialize()
        {
            txtName.Clear();
            txtNum.Clear();
            txtPhone.Clear();
            txtMoney.Clear();
            dtpArrivalDate.ResetText();
            rboMale.Checked = true;
            cbxType.SelectedIndex = 0;
            cbxRoom.SelectedIndex = 0;
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Initialize();
        }


    }
}
