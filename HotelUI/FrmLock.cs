using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAL;

namespace Hotel.UI
{
    public partial class FrmLock : Form
    {
        /// <summary>
        /// 管理员ID
        /// </summary>
        public string id;
        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmLock()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 钥匙单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            Validates();
        }

        /// <summary>
        /// 密码验证
        /// </summary>
        private void Validates()
        {
            FrmLoginComm loginComm = new FrmLoginComm();
            if (txtPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("密码不能为空！","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtPwd.Focus();
            }
            else
            {
                Admin admin = new Admin() { Admins=this.id, Pwd=txtPwd.Text.Trim()};
                if (loginComm.Check(admin))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误，请重新输入！","输入提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPwd.Clear();
                    txtPwd.Focus();
                }
            }
        }

        private void FrmLock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }
    }
}
