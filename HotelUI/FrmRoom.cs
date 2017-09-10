﻿using System;
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
    public partial class FrmRoom : Form
    {
        FrmRoomComm roomComm = new FrmRoomComm();
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

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            BindingType();
            BindingRoomInfo();
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
        /// 绑定房间类型
        /// </summary>
        private void BindingType()
        {
           List<RoomTypeList> list= roomComm.GetTypeList();
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

        
    }
}