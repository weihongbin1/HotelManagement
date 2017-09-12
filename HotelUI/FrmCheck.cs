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
        /// 实例化入住登录命令
        /// </summary>
        FrmCheckComm checkComm = new FrmCheckComm();

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmCheck()

        #region 输入限制
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }
        #endregion

        /// <summary>
        /// 加载事件
        /// </summary>
        private void FrmCheck_Load(object sender, EventArgs e)
        {
            cbxSex.SelectedIndex = 0;
            BindingRoomType();
            cbxType_Click(sender,e);
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
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
            if (txeName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txeName.Focus();
                return false;
            }
            else if (txtNum.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入身份证号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNum.Focus();
                return false;

            }
            else if (txtPhone.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入联系电话！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPhone.Focus();
                return false;
            }
            else if (Convert.ToDouble(txtMoney.Text.Trim()) <= Convert.ToDouble((cbxRoom.SelectedValue)))
            {
                MessageBox.Show("押金不能低于当前房价！");
                txtMoney.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
