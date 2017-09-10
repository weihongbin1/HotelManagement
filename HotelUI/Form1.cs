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
using Hotel.BLL;
using System.Data.SqlClient;

namespace Hotel.UI
{
    /// <summary>
    /// 测试使用
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 测试使用
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        TreeNode node;




        private void Form1_Load(object sender, EventArgs e)
        {
           List();

        }

       
        private void List()
        {
            string all = "全部";
            node = treeView1.Nodes.Add(all);
            string sql = string.Format(@"SELECT TypeName FROM roomtype
            WHERE TypeWindow=1");

           SqlDataReader  r = DBHerper.Reader(sql);
            while (r.Read())
            {
                string a = r[0].ToString();
                node.Nodes.Add(a);
            }
            r.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            txtNewPwd.Text = encrypt.EncryotPwd(txtPwd.Text.ToString().Trim());
        }
    }
}
