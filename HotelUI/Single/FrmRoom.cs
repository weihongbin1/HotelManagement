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
            int index = BindingType(roomType.GetRoomTypeId(id));
            cmbType.SelectedIndex = index;
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
    }
}
