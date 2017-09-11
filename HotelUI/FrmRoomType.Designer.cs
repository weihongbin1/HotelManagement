namespace Hotel.UI
{
    /// <summary>
    /// 房间类型管理
    /// </summary>
    partial class FrmRoomType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomType));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEditInfo = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rboNo = new System.Windows.Forms.RadioButton();
            this.rboYes = new System.Windows.Forms.RadioButton();
            this.nudBedNum = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.dgvTypeInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxEditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbCancel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(460, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Hotel.UI.Properties.Resources.新增;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(68, 22);
            this.tsbAdd.Text = "新增(&A)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = global::Hotel.UI.Properties.Resources.修改;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(69, 22);
            this.tsbUpdate.Text = "修改(&U)";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Hotel.UI.Properties.Resources.删除;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(69, 22);
            this.tsbDelete.Text = "删除(&D)";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = global::Hotel.UI.Properties.Resources.取消;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(68, 22);
            this.tsbCancel.Text = "取消(&C)";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::Hotel.UI.Properties.Resources.退出;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(67, 22);
            this.tsbExit.Text = "退出(&E)";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbRoomType);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 48);
            this.panel1.TabIndex = 2;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(106, 10);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(195, 20);
            this.cmbRoomType.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = global::Hotel.UI.Properties.Resources.查询选择1;
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(314, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型名称：";
            // 
            // gbxEditInfo
            // 
            this.gbxEditInfo.Controls.Add(this.btnEdit);
            this.gbxEditInfo.Controls.Add(this.rboNo);
            this.gbxEditInfo.Controls.Add(this.rboYes);
            this.gbxEditInfo.Controls.Add(this.nudBedNum);
            this.gbxEditInfo.Controls.Add(this.nudPrice);
            this.gbxEditInfo.Controls.Add(this.label5);
            this.gbxEditInfo.Controls.Add(this.label3);
            this.gbxEditInfo.Controls.Add(this.label4);
            this.gbxEditInfo.Controls.Add(this.label2);
            this.gbxEditInfo.Controls.Add(this.txtTypeName);
            this.gbxEditInfo.Enabled = false;
            this.gbxEditInfo.Location = new System.Drawing.Point(12, 359);
            this.gbxEditInfo.Name = "gbxEditInfo";
            this.gbxEditInfo.Size = new System.Drawing.Size(428, 93);
            this.gbxEditInfo.TabIndex = 3;
            this.gbxEditInfo.TabStop = false;
            this.gbxEditInfo.Text = "房间类型信息";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(323, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 68);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "新增";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rboNo
            // 
            this.rboNo.AutoSize = true;
            this.rboNo.Location = new System.Drawing.Point(130, 56);
            this.rboNo.Name = "rboNo";
            this.rboNo.Size = new System.Drawing.Size(35, 16);
            this.rboNo.TabIndex = 8;
            this.rboNo.Text = "无";
            this.rboNo.UseVisualStyleBackColor = true;
            // 
            // rboYes
            // 
            this.rboYes.AutoSize = true;
            this.rboYes.Checked = true;
            this.rboYes.Location = new System.Drawing.Point(81, 56);
            this.rboYes.Name = "rboYes";
            this.rboYes.Size = new System.Drawing.Size(35, 16);
            this.rboYes.TabIndex = 8;
            this.rboYes.TabStop = true;
            this.rboYes.Text = "有";
            this.rboYes.UseVisualStyleBackColor = true;
            // 
            // nudBedNum
            // 
            this.nudBedNum.Location = new System.Drawing.Point(243, 22);
            this.nudBedNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBedNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBedNum.Name = "nudBedNum";
            this.nudBedNum.Size = new System.Drawing.Size(63, 21);
            this.nudBedNum.TabIndex = 7;
            this.nudBedNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(243, 55);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(63, 21);
            this.nudPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "床位数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "是否有窗";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "类型名称";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(68, 21);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(117, 21);
            this.txtTypeName.TabIndex = 3;
            // 
            // dgvTypeInfo
            // 
            this.dgvTypeInfo.AllowUserToAddRows = false;
            this.dgvTypeInfo.AllowUserToDeleteRows = false;
            this.dgvTypeInfo.AllowUserToResizeRows = false;
            this.dgvTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTypeInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTypeInfo.Location = new System.Drawing.Point(13, 91);
            this.dgvTypeInfo.MultiSelect = false;
            this.dgvTypeInfo.Name = "dgvTypeInfo";
            this.dgvTypeInfo.ReadOnly = true;
            this.dgvTypeInfo.RowHeadersVisible = false;
            this.dgvTypeInfo.RowTemplate.Height = 23;
            this.dgvTypeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeInfo.Size = new System.Drawing.Size(428, 262);
            this.dgvTypeInfo.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TypeId";
            this.Column1.HeaderText = "类型编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TypeName";
            this.Column2.HeaderText = "类型名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeWindows";
            this.Column3.HeaderText = "是否有窗";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BedNum";
            this.Column4.HeaderText = "床位数";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TypePrice";
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiAdd,
            this.tmiUpdate,
            this.tmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // tmiAdd
            // 
            this.tmiAdd.Name = "tmiAdd";
            this.tmiAdd.Size = new System.Drawing.Size(100, 22);
            this.tmiAdd.Text = "新增";
            this.tmiAdd.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // tmiUpdate
            // 
            this.tmiUpdate.Name = "tmiUpdate";
            this.tmiUpdate.Size = new System.Drawing.Size(100, 22);
            this.tmiUpdate.Text = "修改";
            this.tmiUpdate.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // tmiDelete
            // 
            this.tmiDelete.Name = "tmiDelete";
            this.tmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tmiDelete.Text = "删除";
            this.tmiDelete.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // FrmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 465);
            this.Controls.Add(this.dgvTypeInfo);
            this.Controls.Add(this.gbxEditInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间类型管理";
            this.Load += new System.EventHandler(this.FrmRoomType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxEditInfo.ResumeLayout(false);
            this.gbxEditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEditInfo;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton rboNo;
        private System.Windows.Forms.RadioButton rboYes;
        private System.Windows.Forms.NumericUpDown nudBedNum;
        private System.Windows.Forms.DataGridView dgvTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tmiDelete;
    }
}