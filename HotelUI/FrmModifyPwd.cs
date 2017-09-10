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
    public partial class FrmModifyPwd : Form
    {
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string id;
        /// <summary>
        /// 加密窗体构造方法
        /// </summary>
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void FrmModifyPwd_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnModify;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyPwd();
        }

        /// <summary>
        /// 非空判断与非法字符的判断
        /// </summary>
        /// <returns>是否符合规则</returns>
        private bool NonEmpty()
        {
            if (txtOldPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("原密码不能为空");
                txtOldPwd.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtOldPwd.Text.Trim(), "^[A-Za-z0-9]*$"))
            {
                MessageBox.Show("原密码输入非法");
                txtOldPwd.Focus();
                return false;
            }
            else if (txtPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入新密码");
                txtPwd.Focus();
                return false;

            }
            else if (!Regex.IsMatch(txtPwd.Text.Trim(), "^[A-Za-z0-9]*$"))
            {
                MessageBox.Show("您输入的是非法新密码");
                txtPwd.Focus();
                return false;
            }
            else if (txtNewPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请确认新密码");
                txtNewPwd.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtNewPwd.Text.Trim(), "^[A-Za-z0-9]*$"))
            {
                MessageBox.Show("确认新密码非法字符");
                txtNewPwd.Focus();
                return false;

            }
            else
            {
                if (!(txtNewPwd.Text.Trim().Equals(txtPwd.Text.Trim())))
                {
                    MessageBox.Show("两次密码不一致");
                    txtPwd.Focus();
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        private void ModifyPwd()
        {
            if (NonEmpty())
            {
                //初始化对象
                Admin admin = new Admin() { Admins=this.id, Pwd =txtOldPwd.Text.Trim()};
                //实例化
                FrmLoginComm loginComm = new FrmLoginComm();
                //判断原密码是否正确
                if (loginComm.Check(admin))
                {
                    //初始化对象
                    admin = new Admin() {Admins =this.id, Pwd =txtPwd.Text.Trim() };
                   //实例化
                    FrmLoginComm frmLoginComm = new FrmLoginComm();
                    //修改密码
                    if (frmLoginComm.UpadtePwd(admin))
                    {
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改密码失败");
                        txtOldPwd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("原密码输入有误");
                    txtOldPwd.Focus();
                }
            }
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            //if (NonEmpty())
            //{
            //    this.AcceptButton = this.btnModify;
            //}
            //else
            //{
            //    this.AcceptButton = null;
            //}
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
