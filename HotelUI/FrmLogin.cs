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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

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
                //初始化对象
                Admin admin = new Admin() { Admins = name, Pwd = pwd };
                //实例化命令类
                FrmLoginComm loginComm = new FrmLoginComm();
                //检查用户名和密码是否正确
                if (loginComm.Check(admin))
                {
                    //登录成功
                    MessageBox.Show("登录成功");
                }
                else
                {
                    //用户名或密码错误
                    MessageBox.Show("用户名或密码错误");
                }
            }
        }

    }
}
