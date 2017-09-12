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
    /// <summary>
    /// 房间管理
    /// </summary>
    public partial class FrmRoom : Form
    {
        /// <summary>
        /// 实例化房间命令类
        /// </summary>
        FrmRoomComm roomComm = new FrmRoomComm();

        /// <summary>
        /// 需要修改的房间编号
        /// </summary>
        private string updateId;

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmRoom()
        {
            InitializeComponent();
        }

        #region 输入限制
        /// <summary>
        /// 输入限制只能是数字
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void txtRoomId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }

        /// <summary>
        /// 输入限制只能是数字
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //利用ASCII码处理办法、48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }
        #endregion

        #region 快捷菜单
        /// <summary>
        /// 快捷菜单新增
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiAdd_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(sender, e);
        }

        /// <summary>
        /// 快捷菜单修改
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiUpdate_Click(object sender, EventArgs e)
        {
            tsbUpdate_Click(sender, e);
        }

        /// <summary>
        /// 快捷菜单删除
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiDelete_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender, e);
        }
        #endregion

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            BindingType();
            InitilizeEdit();
        }

        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            gbxEditInfo.Enabled = true;
            dgvRoomInfo.Enabled = false;
            btnEdit.Text = "新增";
            tsbUpdate.Enabled = false;
            tmiUpdate.Enabled = false;
            tsbDelete.Enabled = false;
            tmiDelete.Enabled = false;
        }

        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            gbxEditInfo.Enabled = true;
            dgvRoomInfo.Enabled = false;
            tsbAdd.Enabled = false;
            tmiAdd.Enabled = false;
            tsbDelete.Enabled = false;
            tmiDelete.Enabled = false;
            btnEdit.Text = "修改";
            updateId = dgvRoomInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtID.Text = updateId;
            if (dgvRoomInfo.SelectedRows[0].Cells[2].Value.Equals("入住"))
            {
                rboCheck.Checked = true;
            }
            else if (dgvRoomInfo.SelectedRows[0].Cells[2].Value.Equals("空闲"))
            {
                rboFree.Checked = true;
            }
            else
            {
                rboRepair.Checked = true;
            }
            cbxRoomType.Text = dgvRoomInfo.SelectedRows[0].Cells[0].Value.ToString();
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string id = dgvRoomInfo.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult r = MessageBox.Show("确定是否要删除" + id + "房间", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (roomComm.JudgeRoom(id))
                {
                    MessageBox.Show("有" + id + "房间相关的订单，要删除" + id + "房间，请先删除该房间相关的订单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (roomComm.DeleteRoom(id))
                    {
                        MessageBox.Show("删除成功");
                        InitilizeEdit();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }

        /// <summary>
        /// 退出事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            InitilizeEdit();
        }

        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            ScreenRoomInfo();
        }

        /// <summary>
        /// 编辑区新增按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("新增"))
            {
                AddRoom();
            }
            else
            {
                UpdateRoom();
            }

        }

        /// <summary>
        /// 绑定房间类型
        /// </summary>
        private void BindingType()
        {
            List<RoomTypeList> list = roomComm.GetTypeList();
            cbxRoomType.DataSource = list;
            cbxRoomType.ValueMember = "TypeID";
            cbxRoomType.DisplayMember = "TypeName";
        }

        /// <summary>
        /// 绑定全部房间信息
        /// </summary>
        private void BindingRoomInfo()
        {
            List<RoomTypeList> list = roomComm.GetRoomInfo();
            dgvRoomInfo.DataSource = list;
        }

        /// <summary>
        /// 查询房间信息
        /// </summary>
        private void ScreenRoomInfo()
        {
            List<RoomTypeList> list = roomComm.GetRoomInfo(txtRoomId.Text.Trim().ToString());
            dgvRoomInfo.DataSource = list;
        }

        /// <summary>
        /// 初始化全部信息
        /// </summary>
        private void InitilizeEdit()
        {
            BindingRoomInfo();
            gbxEditInfo.Enabled = false;
            txtID.Text = string.Empty;
            rboCheck.Checked = true;
            cbxRoomType.ResetText();
            btnEdit.Text = string.Empty;
            dgvRoomInfo.Enabled = true;
            tsbAdd.Enabled = true;
            tmiAdd.Enabled = true;
            tsbUpdate.Enabled = true;
            tmiUpdate.Enabled = true;
            tsbDelete.Enabled = true;
            tmiDelete.Enabled = true;
        }

        /// <summary>
        /// 增加房间
        /// </summary>
        private void AddRoom()
        {

            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间名不能为空");
            }
            else
            {
                int state;
                if (rboCheck.Checked == true)
                {
                    state = 1;
                }
                else if (rboFree.Checked == true)
                {
                    state = 2;
                }
                else
                {
                    state = 3;
                }
                Room room = new Room() { RoomId = Convert.ToInt32(txtID.Text.Trim()), RoomStateId = state, RoomTypeId = Convert.ToInt32(cbxRoomType.SelectedValue) };
                if (roomComm.AddRoom(room))
                {
                    InitilizeEdit();
                    
                }
                else
                {
                    MessageBox.Show("添加失败，请确认是否房间名重名");
                    txtID.Focus();
                }
            }
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        private void UpdateRoom()
        {

            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间名不能为空");
            }
            else
            {
                int state;
                if (rboCheck.Checked == true)
                {
                    state = 1;
                }
                else if (rboFree.Checked == true)
                {
                    state = 2;
                }
                else
                {
                    state = 3;
                }
                Room room = new Room() { RoomId = Convert.ToInt32(txtID.Text.Trim()), RoomStateId = state, RoomTypeId = Convert.ToInt32(cbxRoomType.SelectedValue) };
                if (roomComm.UpdateRoom(room, updateId))
                {
                    InitilizeEdit();
                }
                else
                {
                    MessageBox.Show("修改失败，请确认是否房间名重名");
                    txtID.Focus();
                }
            }
        }


        

      
    }
}
