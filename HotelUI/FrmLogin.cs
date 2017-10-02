using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace Hotel.UI
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// 登录窗体构造方法
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 非空判断以及输入是否合法
        /// </summary>
        /// <returns>是否符合规则</returns>
        private bool NonEmpty()
        {
            if (txtUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名");
                txtUser.Focus();
                return false;
            }//正则表达式解释：匹配字符串只能是A-Z、a-z、0-9 匹配出现任意次数
            else if (!Regex.IsMatch(txtUser.Text.Trim(), "^[A-Za-z0-9]*$"))
            {
                MessageBox.Show("请输入合法用户名");
                txtUser.Focus();
                return false;
            }
            else if (txtPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码");
                txtPwd.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtPwd.Text.Trim(), "^[A-Za-z0-9]*$"))
            {
                MessageBox.Show("请输入合法密码");
                txtPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// 登录
        /// </summary>
        private void Login()
        {
            if (NonEmpty())
            {
                string name = txtUser.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                Admin admin = new Admin() { Admins = name, Pwd = pwd };
                FrmLoginComm loginComm = new FrmLoginComm();
                if (loginComm.Check(admin))
                {
                    new FrmMain() { Admin = txtUser.Text.Trim() }.ShowDialog();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    //用户名或密码错误
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }


        /// <summary>
        /// 是否显示密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPwd.UseSystemPasswordChar = (checkBox1.Checked == true) ? false : true;
        }


    }
}
