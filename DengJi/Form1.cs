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

namespace DengJi
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// 数据集实例化
        /// </summary>
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //性别索引
            cbxSex.SelectedIndex = 0;
            //绑定房间类型
            BangDing();
            //绑定房价编号
            BingDingRoom(cbxType.SelectedValue.ToString());
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        }
        /// <summary>
        /// 点击事件
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 绑定房间类型
        /// </summary>
        private void BangDing()
        {
            //select [TypeName]+ case when [列名]=值 then ' 对应名称' 
            //when[列名] = 值 then ' 对应名称'end AS Name,[TypeId]
            string sql = string.Format(@"select [TypeName]+case when [TypeWindow]=0 then ' | 无窗' 
                when [TypeWindow]=1 then ' | 有窗'end  AS Name,[TypeId]
                from [dbo].[RoomType]");
            SqlDataReader a = DBHerper.Reader(sql);

            //类比  RoomType[] A = new RoomType[10];
            List<RoomType> list = new List<RoomType>();

            while (a.Read())
            {
                RoomType type = new RoomType() { RoomName = a[0].ToString(), TypeId = a[1].ToString() };
                list.Add(type);
              
            }
            a.Close();
            this.cbxType.DataSource = list;
            this.cbxType.ValueMember = "TypeId";
            this.cbxType.DisplayMember = "RoomName";
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>是否为空</returns>
        private bool fk()
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


        /// <summary>
        /// 绑定房间
        /// </summary>
        private void BingDingRoom(string typeId)
        {
            //SQL命令
            string sql = string.Format(@"select [RoomId],[TypePrice]
                from [dbo].[Room] R,[dbo].[RoomType] T
                where(R.RoomTypeId=T.TypeId) and([RoomTypeId]='{0}' and [RoomStateId]='2')", typeId);
            //执行命令 获取Adapter对象
            SqlDataAdapter a = DBHerper.Adapter(sql);
            //判断数据集的表是否为空
            if (ds.Tables["bma"] != null)
            {
                ds.Tables["bma"].Clear();
            }
            //填充数据集的表
            a.Fill(ds, "bma");
            //绑定数据集的表
            cbxRoom.DataSource = ds.Tables["bma"];
            //绑定显示值
            cbxRoom.DisplayMember = "RoomId";
            //绑定隐藏值
            cbxRoom.ValueMember = "TypePrice";

        }
        /// <summary>
        /// 改变房间单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void cbxType_Click(object sender, EventArgs e)
        {
            //获取房间类型选中项的Value
            string judge = cbxType.SelectedValue.ToString();
            //绑定房间号
            BingDingRoom(judge);
        }
    }
}
