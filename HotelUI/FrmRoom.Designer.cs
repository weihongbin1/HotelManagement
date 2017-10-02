namespace Hotel.UI
{
    /// <summary>
    /// 房间管理
    /// </summary>
    partial class FrmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.rboFree = new System.Windows.Forms.RadioButton();
            this.rboCheck = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbxEditInfo = new System.Windows.Forms.GroupBox();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rboRepair = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.gbxEditInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.SuspendLayout();
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
            this.tmiAdd.Click += new System.EventHandler(this.tmiAdd_Click);
            // 
            // tmiUpdate
            // 
            this.tmiUpdate.Name = "tmiUpdate";
            this.tmiUpdate.Size = new System.Drawing.Size(100, 22);
            this.tmiUpdate.Text = "修改";
            this.tmiUpdate.Click += new System.EventHandler(this.tmiUpdate_Click);
            // 
            // tmiDelete
            // 
            this.tmiDelete.Name = "tmiDelete";
            this.tmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tmiDelete.Text = "删除";
            this.tmiDelete.Click += new System.EventHandler(this.tmiDelete_Click);
            // 
            // rboFree
            // 
            this.rboFree.AutoSize = true;
            this.rboFree.Checked = true;
            this.rboFree.Location = new System.Drawing.Point(281, 24);
            this.rboFree.Name = "rboFree";
            this.rboFree.Size = new System.Drawing.Size(47, 16);
            this.rboFree.TabIndex = 8;
            this.rboFree.TabStop = true;
            this.rboFree.Text = "空闲";
            this.rboFree.UseVisualStyleBackColor = true;
            // 
            // rboCheck
            // 
            this.rboCheck.AutoSize = true;
            this.rboCheck.Location = new System.Drawing.Point(232, 24);
            this.rboCheck.Name = "rboCheck";
            this.rboCheck.Size = new System.Drawing.Size(47, 16);
            this.rboCheck.TabIndex = 8;
            this.rboCheck.Text = "入住";
            this.rboCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "房间类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "房间状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "房间编号";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(68, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 21);
            this.txtID.TabIndex = 3;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // gbxEditInfo
            // 
            this.gbxEditInfo.Controls.Add(this.cbxRoomType);
            this.gbxEditInfo.Controls.Add(this.btnEdit);
            this.gbxEditInfo.Controls.Add(this.rboRepair);
            this.gbxEditInfo.Controls.Add(this.rboFree);
            this.gbxEditInfo.Controls.Add(this.rboCheck);
            this.gbxEditInfo.Controls.Add(this.label3);
            this.gbxEditInfo.Controls.Add(this.label4);
            this.gbxEditInfo.Controls.Add(this.label2);
            this.gbxEditInfo.Controls.Add(this.txtID);
            this.gbxEditInfo.Location = new System.Drawing.Point(12, 365);
            this.gbxEditInfo.Name = "gbxEditInfo";
            this.gbxEditInfo.Size = new System.Drawing.Size(428, 93);
            this.gbxEditInfo.TabIndex = 13;
            this.gbxEditInfo.TabStop = false;
            this.gbxEditInfo.Text = "房间信息维护";
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(68, 58);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(205, 20);
            this.cbxRoomType.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(334, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 38);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "新增";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rboRepair
            // 
            this.rboRepair.AutoSize = true;
            this.rboRepair.Location = new System.Drawing.Point(330, 24);
            this.rboRepair.Name = "rboRepair";
            this.rboRepair.Size = new System.Drawing.Size(47, 16);
            this.rboRepair.TabIndex = 8;
            this.rboRepair.Text = "维修";
            this.rboRepair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间编号：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRoomId);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 48);
            this.panel1.TabIndex = 12;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(123, 11);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(149, 21);
            this.txtRoomId.TabIndex = 0;
            this.txtRoomId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomId_KeyPress);
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
            this.toolStrip1.TabIndex = 11;
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
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.AllowUserToResizeRows = false;
            this.dgvRoomInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRoomInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRoomInfo.Location = new System.Drawing.Point(13, 97);
            this.dgvRoomInfo.MultiSelect = false;
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.ReadOnly = true;
            this.dgvRoomInfo.RowHeadersVisible = false;
            this.dgvRoomInfo.RowTemplate.Height = 23;
            this.dgvRoomInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomInfo.Size = new System.Drawing.Size(428, 262);
            this.dgvRoomInfo.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TypeID";
            this.Column1.FillWeight = 67.64281F;
            this.Column1.HeaderText = "房间编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StateName";
            this.Column2.FillWeight = 80.07291F;
            this.Column2.HeaderText = "房间状态";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeName";
            this.Column3.FillWeight = 152.2843F;
            this.Column3.HeaderText = "房间类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 465);
            this.Controls.Add(this.gbxEditInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvRoomInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息管理";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbxEditInfo.ResumeLayout(false);
            this.gbxEditInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tmiDelete;
        private System.Windows.Forms.RadioButton rboFree;
        private System.Windows.Forms.RadioButton rboCheck;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.GroupBox gbxEditInfo;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton rboRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}