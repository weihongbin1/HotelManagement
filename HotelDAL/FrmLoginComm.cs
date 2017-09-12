using Hotel.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel.DAL
{
    /// <summary>
    ///登录窗体加载使用命令
    /// </summary>
    public class FrmLoginComm
    {
        /// <summary>
        /// 检查用户名和密码是否正确
        /// </summary>
        /// <param name="admin">管理员对象</param>
        /// <returns>是否正确</returns>
        public bool Check(Admin admin)
        {
            Encrypt encrypt = new Encrypt();
            string pwd = encrypt.EncryotPwd(admin.Pwd);
            string sql = string.Format(@"SELECT COUNT(*)
                FROM [dbo].[Admin]
                WHERE [Admins]='{0}' AND [Pwd]='{1}'", admin.Admins, pwd);
            try
            {
                int judge = Convert.ToInt32(DBHerper.Scalar(sql));
                if (judge == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin">管理员对象</param>
        /// <returns>修改是否成功</returns>
        public bool UpadtePwd(Admin admin)
        {
            Encrypt encrypt = new Encrypt();
            string pwd = encrypt.EncryotPwd(admin.Pwd);
            string sql = string.Format(@"UPDATE [dbo].[Admin]
                SET [Pwd]='{0}'
                WHERE [Admins]='{1}'", pwd, admin.Admins);
            try
            {
                int judge = DBHerper.NonQuery(sql);
                if (judge == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
