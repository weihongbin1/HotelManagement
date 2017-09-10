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
    public partial class FrmMain : Form
    {
        RoomStatistics statistics = new RoomStatistics();
        /// <summary>
        /// 实例化执行命令对象
        /// </summary>
        FrmMainComm mainComm = new FrmMainComm();
        /// <summary>
        /// 登录用户名
        /// </summary>
        public string Admin = "Admin";
        /// <summary>
        /// 主窗体构造方法
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsbUser.Text = "当前用户：" + Admin;
            tsbLogOn.Text = "登录时间：" + DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString();
            RenovateInfo();
        }

        

        #region 右击菜单事件

        /// <summary>
        /// 大图标单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwRoomInfo.View = View.LargeIcon;
        }

        /// <summary>
        /// 小图标单价事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwRoomInfo.View = View.SmallIcon;
        }

        /// <summary>
        /// 详细信息单机事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwRoomInfo.View = View.Details;
        }

        /// <summary>
        ///单击平铺 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwRoomInfo.View = View.Tile;
        }

        /// <summary>
        /// 单击列表
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwRoomInfo.View = View.List;
        }
        #endregion

        /// <summary>
        /// 刷新时间
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string week = string.Empty;
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    week = "星期一";
                    break;
                case "Tuesday":
                    week = "星期二";
                    break;
                case "Wednesday":
                    week = "星期三";
                    break;
                case "Thursday":
                    week = "星期四";
                    break;
                case "Friday":
                    week = "星期五";
                    break;
                case "Saturday":
                    week = "星期六";
                    break;
                case "Sunday":
                    week = "星期日";
                    break;
            }
            string date = "当前时间：" + DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString();
            tsbDate.Text = date;
            tsbWeek.Text = week;


        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void xiuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifyPwd modifyPwd = new FrmModifyPwd() { id = this.Admin };
            modifyPwd.ShowDialog();
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        /// <summary>
        /// 房间信息单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void lvwRoomInfo_Click(object sender, EventArgs e)
        {

            MessageBox.Show(lvwRoomInfo.SelectedItems[0].Text);
        }

        /// <summary>
        /// 改变选的内容后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwRoomType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string type = string.Empty;
            if (tvwRoomType.SelectedNode.Level != 0)
            {
                type = tvwRoomType.SelectedNode.Text;

            }
            if (lvwRoomInfo.Items != null)
            {
                lvwRoomInfo.Items.Clear();
            }
            ShowRoomInfo(type);
            FillStatistics();

        }

        /// <summary>
        /// 展示房间信息
        /// </summary>
        private void ShowRoomInfo()
        {
            statistics.Initial();
            List<RoomInfo> list = mainComm.GetRoomInfo();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem(list[i].Number);
                item.SubItems.Add(list[i].RoomRype);
                item.SubItems.Add(list[i].Window);
                item.SubItems.Add(list[i].RoomState);
                switch (list[i].RoomState)
                {
                    case "入住":
                        item.ImageIndex = 0;
                        statistics.Check++;
                        break;
                    case "空闲":
                        item.ImageIndex = 1;
                        statistics.Free++;
                        break;
                    case "维修":
                        item.ImageIndex = 2;
                        statistics.Repair++;
                        break;
                }
                lvwRoomInfo.Items.Add(item);
            }
            statistics.Type = "全部";
            statistics.RoomNum = list.Count;

        }

        /// <summary>
        /// 展示房间信息并筛选
        /// </summary>
        /// <param name="Type">房间类型</param>
        private void ShowRoomInfo(string Type)
        {
            statistics.Initial();
            List<RoomInfo> list = mainComm.GetRoomInfo();

            for (int i = 0; i < list.Count; i++)
            {
                if (Type.Equals(string.Empty))
                {
                    statistics.Type = "全部";
                }
                else
                {
                    statistics.Type = Type;
                    if (!list[i].RoomRype.Equals(Type))
                    {
                        continue;
                    }
                }
                ListViewItem item = new ListViewItem(list[i].Number);
                item.SubItems.Add(list[i].RoomRype);
                item.SubItems.Add(list[i].Window);
                item.SubItems.Add(list[i].RoomState);
                switch (list[i].RoomState)
                {
                    case "入住":
                        item.ImageIndex = 0;
                        statistics.Check++;
                        break;
                    case "空闲":
                        item.ImageIndex = 1;
                        statistics.Free++;
                        break;
                    case "维修":
                        item.ImageIndex = 2;
                        statistics.Repair++;
                        break;
                }
                lvwRoomInfo.Items.Add(item);
                statistics.RoomNum++;
            }
            

        }

       /// <summary>
       /// 填充房间统计
       /// </summary>
        private void FillStatistics()
        {
            txtType.Text = statistics.Type;
            txtRoomNum.Text = statistics.RoomNum.ToString();
            txtCheck.Text = statistics.Check.ToString();
            txtFree.Text = statistics.Free.ToString();
            txtRepair.Text = statistics.Repair.ToString();
            txtCheckRate.Text = ((statistics.Check * 1.0 / statistics.RoomNum) * 100).ToString("0.00")+"%";
        }

        /// <summary>
        ///更新房间信息
        /// </summary>
        private void RenovateInfo()
        {
            if (lvwRoomInfo.Items!=null)
            {
                lvwRoomInfo.Items.Clear();
            }
            ShowRoomInfo();
            if (tvwRoomType.Nodes!=null)
            {
                tvwRoomType.Nodes.Clear();
            }
            mainComm.ShowTreeView(tvwRoomType);
            tvwRoomType.ExpandAll();
            FillStatistics();
        }

        /// <summary>
        /// 锁定事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbLock_Click(object sender, EventArgs e)
        {
            FrmLock frmLock = new FrmLock();
            frmLock.id = this.Admin;
            frmLock.ShowDialog();
        }

        /// <summary>
        /// 菜单关于事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsmAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        /// <summary>
        /// 房间类型管理事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbType_Click(object sender, EventArgs e)
        {
            FrmRoomType roomType = new FrmRoomType();
            roomType.ShowDialog();
            RenovateInfo();


        }
    }
}
