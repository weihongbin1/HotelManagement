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

namespace Hotel.UI
{
    public partial class FrmFoods : Form
    {
        FrmFoodsComm foodsComm = new FrmFoodsComm();

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmFoods()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FrmFoods_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            ShowFoodsInfo(txtFoodName.Text.Trim());
        }

        /// <summary>
        /// 展示食品信息
        /// </summary>
        private void ShowFoodsInfo()
        {
            List<FoodList> fl = foodsComm.GetFood();
            dgvFoodInfo.DataSource = fl;
        }

        /// <summary>
        /// 筛选食品信息
        /// </summary>
        private void ShowFoodsInfo(string name)
        {
            List<FoodList> fl = foodsComm.GetFood(name);
            dgvFoodInfo.DataSource = fl;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initialize()
        {
            tsbAdd.Enabled = true;
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
            tmiAdd.Enabled = true;
            tmiUpdate.Enabled = true;
            tmiDelete.Enabled = true;
            txtFoodName.Clear();
            dgvFoodInfo.Enabled = true;
            gbxEditInfo.Enabled = false;
            txtName.Clear();
            txtUnit.Clear();
            nudPrice.Value = 0;
            btnEdit.Text = string.Empty;
            ShowFoodsInfo();
        }

        #region 工具栏事件
        /// <summary>
        /// 工具栏新增
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            gbxEditInfo.Enabled = true;
            btnEdit.Text = "新增";
            dgvFoodInfo.Enabled = false;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
            tmiUpdate.Enabled = false;
            tmiDelete.Enabled = false;
            txtName.Focus();
        }

        /// <summary>
        /// 工具栏修改
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            gbxEditInfo.Enabled = true;
            btnEdit.Text = "修改";
            dgvFoodInfo.Enabled = false;
            tsbAdd.Enabled = false;
            tsbDelete.Enabled = false;
            tmiAdd.Enabled = false;
            tmiDelete.Enabled = false;
            txtName.Text = dgvFoodInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtUnit.Text = dgvFoodInfo.SelectedRows[0].Cells[2].Value.ToString();
            nudPrice.Value = Convert.ToDecimal(dgvFoodInfo.SelectedRows[0].Cells[3].Value);
            txtName.Focus();
        }

        /// <summary>
        /// 工具栏 删除
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string id = dgvFoodInfo.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvFoodInfo.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("确定要删除" + name, "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (foodsComm.JudgeFoodsOrders(id))
                {
                    MessageBox.Show("有" + name + "相关的订单，要删除" + name + "商品，请先删除该商品相关的订单！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (foodsComm.DeleteFoods(id))
                    {
                        MessageBox.Show("删除成功");
                        Initialize();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }

        }

        /// <summary>
        /// 工具栏取消
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        /// <summary>
        /// 工具栏退出
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 右键菜单事件
        /// <summary>
        /// 右键菜单新增
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiAdd_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(sender, e);
        }

        /// <summary>
        /// 右键菜单修改
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiUpdate_Click(object sender, EventArgs e)
        {
            tsbUpdate_Click(sender, e);
        }

        /// <summary>
        /// 右键菜单删除
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void tmiDelete_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender, e);
        }
        #endregion

        /// <summary>
        /// 编辑按钮单击事件
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Trim().Equals("新增"))
            {
                AddFoods();
            }
            else
            {
                UpdateFoods();
            }
        }

        /// <summary>
        /// 新增商品
        /// </summary>
        private void AddFoods()
        {
            if (Nonempty())
            {
                FoodList food = new FoodList() { FoodName = txtName.Text.Trim(), Unit = txtUnit.Text.Trim(), Price = Convert.ToDouble(nudPrice.Value) };
                MessageBox.Show("增加成功，商品编号为：" + foodsComm.AddFoods(food));
                Initialize();
            }
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        private void UpdateFoods()
        {
            if (Nonempty())
            {
               
                int id = Convert.ToInt32(dgvFoodInfo.SelectedRows[0].Cells[0].Value);
                FoodList food = new FoodList() { FoodId = id, FoodName = txtName.Text.Trim(), Unit = txtUnit.Text.Trim(), Price = Convert.ToDouble(nudPrice.Value) };
                if (foodsComm.UpdateFoods(food))
                {
                    MessageBox.Show("修改成功");
                    Initialize();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }

        }

        /// <summary>
        /// 输入非空判断
        /// </summary>
        /// <returns>是否为空</returns>
        private bool Nonempty()
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("商品名称不能为空");
                txtName.Focus();
                return false;
            }
            else if (txtUnit.Text.Trim().Length == 0)
            {
                MessageBox.Show("商品单位不能为空");
                txtUnit.Focus();
                return false;
            }
            else if (nudPrice.Value == 0)
            {
                MessageBox.Show("单价不能为0");
                nudPrice.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
