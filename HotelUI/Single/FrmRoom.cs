using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI.Single
{
    /// <summary>
    /// 指定房间修改
    /// </summary>
    public partial class FrmRoom : Form
    {
        /// <summary>
        /// 实例化类
        /// </summary>
        FrmRoomComm roomType = new FrmRoomComm();

        /// <summary>
        /// 房间ID
        /// </summary>
        public string id;

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmRoom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单击取消按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            RoomInfo room = roomType.GetRoomTypeId(id);
            int index = BindingType(room.RoomRype);
            cmbType.SelectedIndex = index;
            BindingState(Convert.ToInt32(room.RoomState));
        }

        /// <summary>
        /// 绑定房间类型
        /// </summary>
        /// <param name="TypeId">房间类型ID</param>
        /// <returns>房间类型索引</returns>
        private int BindingType(string TypeId)
        {
            List<RoomTypeList> l = roomType.GetTypeList();
            cmbType.DataSource = l;
            cmbType.DisplayMember = "TypeName";
            cmbType.ValueMember = "TypeID";
            int index = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].TypeID.Equals(TypeId))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// 绑定房间状态
        /// </summary>
        /// <param name="stateId">状态ID</param>
        private void BindingState(int stateId)
        {
            if (stateId == 1)
            {
                rboCheck.Checked = true;
            }
            else if (stateId == 2)
            {
                rboFree.Checked = true;
            }
            else
            {
                rboRepair.Checked = true;
            }
        }

        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        /// <summary>
        /// 修改房间信息
        /// </summary>
        private void UpdateInfo()
        {
            int typeId = Convert.ToInt32(cmbType.SelectedValue);
            int state;
            if (rboCheck.Checked==true)
            {
                state = 1;
            }
            else if (rboFree.Checked==true)
            {
                state = 2;
            }
            else
            {
                state = 3;
            }
            Room r = new Room() { RoomId = Convert.ToInt32(this.id), RoomStateId= state, RoomTypeId= typeId };
            if (roomType.UpdateRoomInfo(r))
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
