namespace Hotel.UI
{
    /// <summary>
    /// 入住登记类
    /// </summary>
    partial class FrmCheck
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblFangJian = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblHM = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rboMale = new System.Windows.Forms.RadioButton();
            this.rboFeMale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboFeMale);
            this.groupBox1.Controls.Add(this.rboMale);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.dtpArrivalDate);
            this.groupBox1.Controls.Add(this.cbxType);
            this.groupBox1.Controls.Add(this.cbxRoom);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Controls.Add(this.lblFangJian);
            this.groupBox1.Controls.Add(this.labSex);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblHM);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记顾客信息";
            // 
            // btnRegister
            // 
            this.btnRegister.Image = global::Hotel.UI.Properties.Resources.保存;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(343, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "确定";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(92, 158);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(164, 21);
            this.dtpArrivalDate.TabIndex = 3;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(367, 76);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(164, 20);
            this.cbxType.TabIndex = 5;
            this.cbxType.DropDownClosed += new System.EventHandler(this.cbxType_Click);
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(367, 117);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(164, 20);
            this.cbxRoom.TabIndex = 5;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(367, 158);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(164, 21);
            this.txtMoney.TabIndex = 6;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 117);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 21);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(92, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(164, 21);
            this.txtNum.TabIndex = 1;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 21);
            this.textBox2.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间类型";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(327, 162);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(29, 12);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "押金";
            // 
            // lblFangJian
            // 
            this.lblFangJian.AutoSize = true;
            this.lblFangJian.Location = new System.Drawing.Point(327, 121);
            this.lblFangJian.Name = "lblFangJian";
            this.lblFangJian.Size = new System.Drawing.Size(29, 12);
            this.lblFangJian.TabIndex = 0;
            this.lblFangJian.Text = "房间";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(327, 39);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(29, 12);
            this.labSex.TabIndex = 0;
            this.labSex.Text = "性别";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(28, 162);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "入住时间 ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "联系电话";
            // 
            // lblHM
            // 
            this.lblHM.AutoSize = true;
            this.lblHM.Location = new System.Drawing.Point(34, 80);
            this.lblHM.Name = "lblHM";
            this.lblHM.Size = new System.Drawing.Size(53, 12);
            this.lblHM.TabIndex = 0;
            this.lblHM.Text = "身份号码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "客户姓名";
            // 
            // rboMale
            // 
            this.rboMale.AutoSize = true;
            this.rboMale.Checked = true;
            this.rboMale.Location = new System.Drawing.Point(383, 37);
            this.rboMale.Name = "rboMale";
            this.rboMale.Size = new System.Drawing.Size(35, 16);
            this.rboMale.TabIndex = 8;
            this.rboMale.TabStop = true;
            this.rboMale.Text = "男";
            this.rboMale.UseVisualStyleBackColor = true;
            // 
            // rboFeMale
            // 
            this.rboFeMale.AutoSize = true;
            this.rboFeMale.Location = new System.Drawing.Point(442, 37);
            this.rboFeMale.Name = "rboFeMale";
            this.rboFeMale.Size = new System.Drawing.Size(35, 16);
            this.rboFeMale.TabIndex = 8;
            this.rboFeMale.Text = "女";
            this.rboFeMale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Hotel.UI.Properties.Resources.取消;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(456, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 264);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客入住信息登记";
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblFangJian;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblHM;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rboFeMale;
        private System.Windows.Forms.RadioButton rboMale;
        private System.Windows.Forms.Button btnClear;
    }
}

