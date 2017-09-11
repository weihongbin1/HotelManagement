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
    public partial class FrmRoomType : Form
    {
        /// <summary>
        /// 实例化类型命令对象
        /// </summary>
        FrmRoomTypeComm typeComm = new FrmRoomTypeComm();

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmRoomType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmRoomType_Load(object sender, EventArgs e)
        {
            Binding();
            dgvTypeInfo.AutoGenerateColumns = false;
            BindingInfo();
            EditClear();
        }

        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string type = cmbRoomType.Text.Trim();
            BindingInfo(type);
        }

        #region 工具栏按钮事件
        /// <summary>
        /// 工具栏新增按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Text = "新增";
            gbxEditInfo.Enabled = true;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
            tmiUpdate.Enabled = false;
            tmiDelete.Enabled = false;
        }

        /// <summary>
        /// 工具栏修改按钮单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            btnEdit.Text = "修改";
            gbxEditInfo.Enabled = true;
            LoadInfo();
            tsbAdd.Enabled = false;
            tsbDelete.Enabled = false;
            tmiAdd.Enabled = false;
            tmiDelete.Enabled = false;
            dgvTypeInfo.Enabled = false;
        }

        /// <summary>
        /// 工具栏删除按钮单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string id = dgvTypeInfo.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvTypeInfo.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult r = MessageBox.Show("确定是否要删除" + name + "类型", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (typeComm.JudgeTypeId(id))
                {
                    MessageBox.Show("有" + name + "类型的房间，要删除" + name + "类型，请先删除该类型房间！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (typeComm.DeleteType(id))
                    {
                        MessageBox.Show("删除成功");
                        Binding();
                        BindingInfo();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }

        /// <summary>
        /// 工具栏取消按钮单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            EditClear();
        }

        /// <summary>
        /// 工具栏退出按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 右击菜单按钮事件
        /// <summary>
        /// 右击菜单新增按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(sender, e);
        }

        /// <summary>
        /// 右击菜单修改按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbUpdate_Click(sender, e);
        }

        /// <summary>
        /// 右击菜单删除按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender, e);
        }
        #endregion

        /// <summary>
        /// 编辑的新增按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("新增"))
            {
                AddType();
            }
            else
            {
                UpdateInfo();
            }
        }

        /// <summary>
        /// 新增房间类型
        /// </summary>
        private void AddType()
        {
            if (txtTypeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入房间类型");
            }
            else if (nudPrice.Value == 0)
            {
                MessageBox.Show("价格不能为0");
            }
            else
            {
                bool window;
                if (rboYes.Checked == true)
                {
                    window = true;
                }
                else
                {
                    window = false;
                }
                RoomType type = new RoomType() { TypeName = txtTypeName.Text.Trim(), TypeWindow = window, BedNum = Convert.ToInt32(nudBedNum.Value), TypePrice = Convert.ToDouble(nudPrice.Value) };
                MessageBox.Show("新增房间类型成功！新增的房间类型编号为:" + typeComm.AddType(type));
                EditClear();
                BindingInfo();
                tsbUpdate.Enabled = true;
                tsbDelete.Enabled = true;
                tmiUpdate.Enabled = true;
                tmiDelete.Enabled = true;
            }

        }

        /// <summary>
        /// 加载要修改的信息
        /// </summary>
        private void LoadInfo()
        {
            txtTypeName.Text = dgvTypeInfo.SelectedRows[0].Cells[1].Value.ToString();
            object window = dgvTypeInfo.SelectedRows[0].Cells[2].Value;
            if (window.Equals("有"))
            {
                rboYes.Checked = true;
            }
            else
            {
                rboNo.Checked = true;
            }
            nudBedNum.Value = Convert.ToDecimal(dgvTypeInfo.SelectedRows[0].Cells[3].Value);
            nudPrice.Value = Convert.ToDecimal(dgvTypeInfo.SelectedRows[0].Cells[4].Value);

        }

        /// <summary>
        /// 修改房间类型信息
        /// </summary>
        private void UpdateInfo()
        {
            if (txtTypeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间类型不能为空");
            }
            else if (nudPrice.Value == 0)
            {
                MessageBox.Show("价格不能为0");
            }
            else
            {
                object id = dgvTypeInfo.SelectedRows[0].Cells[0].Value;
                bool window;
                if (rboYes.Checked == true)
                {
                    window = true;
                }
                else
                {
                    window = false;
                }
                RoomType type = new RoomType() { TypeName = txtTypeName.Text.Trim(), TypeWindow = window, BedNum = Convert.ToInt32(nudBedNum.Value), TypePrice = Convert.ToDouble(nudPrice.Value), TypeId = Convert.ToInt32(id) };
                if (typeComm.UpdateType(type))
                {
                    MessageBox.Show("修改成功");
                    EditClear();
                    BindingInfo();
                    tsbAdd.Enabled = true;
                    tsbDelete.Enabled = true;
                    tmiAdd.Enabled = true;
                    tmiDelete.Enabled = true;
                    dgvTypeInfo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("修改失败");
                    txtTypeName.Focus();
                }
            }
        }

        /// <summary>
        /// 编辑信息初始化
        /// </summary>
        private void EditClear()
        {
            gbxEditInfo.Enabled = false;
            txtTypeName.Clear();
            nudBedNum.Value = 1;
            nudPrice.Value = 0;
            rboYes.Checked = true;
            btnEdit.Text = string.Empty;
            Binding();
            tsbAdd.Enabled = true;
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
            tmiAdd.Enabled = true;
            tmiUpdate.Enabled = true;
            tmiDelete.Enabled = true;
            dgvTypeInfo.Enabled = true;
        }

        /// <summary>
        /// 绑定房间类型
        /// </summary>
        private void Binding()
        {
            List<string> l = typeComm.Querys();
            l.Insert(0, "全部");
            cmbRoomType.DataSource = l;
            cmbRoomType.DisplayMember = "TypeName";
        }

        /// <summary>
        /// 绑定房间类型信息
        /// </summary>
        private void BindingInfo()
        {
            List<RoomType> l = typeComm.QueryInfo();
            dgvTypeInfo.DataSource = l;
        }

        /// <summary>
        /// 绑定房间类型信息并筛选
        /// </summary>
        private void BindingInfo(string type)
        {
            List<RoomType> l = typeComm.QueryInfo();
            if (type.Equals("全部"))
            {
                dgvTypeInfo.DataSource = l;
            }
            else
            {
                List<RoomType> newL = new List<RoomType>();
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i].Equals(null))
                    {
                        break;
                    }
                    else
                    {
                        if (l[i].TypeName.Equals(type))
                        {
                            newL.Add(l[i]);
                        }
                    }
                }
                dgvTypeInfo.DataSource = newL;
            }

        }

      
    }
}
