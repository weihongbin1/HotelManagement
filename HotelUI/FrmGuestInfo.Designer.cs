namespace Hotel.UI
{
    partial class FrmGuestInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuestInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxCheckOutInfo = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGuestInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxRoomId = new System.Windows.Forms.GroupBox();
            this.btnByRoomId = new System.Windows.Forms.Button();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.btnByName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRByName = new System.Windows.Forms.Button();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRByRoomId = new System.Windows.Forms.Button();
            this.txtRRoomId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxCheckOutInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestInfo)).BeginInit();
            this.gbxRoomId.SuspendLayout();
            this.gbxName.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 496);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxCheckOutInfo);
            this.tabPage1.Controls.Add(this.dgvGuestInfo);
            this.tabPage1.Controls.Add(this.gbxRoomId);
            this.tabPage1.Controls.Add(this.gbxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未结账";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxCheckOutInfo
            // 
            this.gbxCheckOutInfo.Controls.Add(this.btnCheckOut);
            this.gbxCheckOutInfo.Controls.Add(this.txtSum);
            this.gbxCheckOutInfo.Controls.Add(this.label6);
            this.gbxCheckOutInfo.Controls.Add(this.txtFoodTotal);
            this.gbxCheckOutInfo.Controls.Add(this.label5);
            this.gbxCheckOutInfo.Controls.Add(this.txtRoomTotal);
            this.gbxCheckOutInfo.Controls.Add(this.label4);
            this.gbxCheckOutInfo.Controls.Add(this.txtDeposit);
            this.gbxCheckOutInfo.Controls.Add(this.label3);
            this.gbxCheckOutInfo.Location = new System.Drawing.Point(8, 407);
            this.gbxCheckOutInfo.Name = "gbxCheckOutInfo";
            this.gbxCheckOutInfo.Size = new System.Drawing.Size(726, 57);
            this.gbxCheckOutInfo.TabIndex = 1;
            this.gbxCheckOutInfo.TabStop = false;
            this.gbxCheckOutInfo.Text = "退房信息";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Image = global::Hotel.UI.Properties.Resources.保存;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(609, 22);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(88, 23);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "  确认退房";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(496, 25);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 21);
            this.txtSum.TabIndex = 1;
            this.txtSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "应付：";
            // 
            // txtFoodTotal
            // 
            this.txtFoodTotal.Location = new System.Drawing.Point(349, 25);
            this.txtFoodTotal.Name = "txtFoodTotal";
            this.txtFoodTotal.Size = new System.Drawing.Size(100, 21);
            this.txtFoodTotal.TabIndex = 1;
            this.txtFoodTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "消费：";
            // 
            // txtRoomTotal
            // 
            this.txtRoomTotal.Location = new System.Drawing.Point(202, 25);
            this.txtRoomTotal.Name = "txtRoomTotal";
            this.txtRoomTotal.Size = new System.Drawing.Size(100, 21);
            this.txtRoomTotal.TabIndex = 1;
            this.txtRoomTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "押金：";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(55, 25);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 21);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "房款：";
            // 
            // dgvGuestInfo
            // 
            this.dgvGuestInfo.AllowUserToAddRows = false;
            this.dgvGuestInfo.AllowUserToDeleteRows = false;
            this.dgvGuestInfo.AllowUserToResizeRows = false;
            this.dgvGuestInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuestInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Id});
            this.dgvGuestInfo.Location = new System.Drawing.Point(8, 68);
            this.dgvGuestInfo.MultiSelect = false;
            this.dgvGuestInfo.Name = "dgvGuestInfo";
            this.dgvGuestInfo.ReadOnly = true;
            this.dgvGuestInfo.RowHeadersVisible = false;
            this.dgvGuestInfo.RowTemplate.Height = 23;
            this.dgvGuestInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestInfo.Size = new System.Drawing.Size(726, 335);
            this.dgvGuestInfo.TabIndex = 1;
            this.dgvGuestInfo.Click += new System.EventHandler(this.dgvGuestInfo_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomId";
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "房间编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CardNo";
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "身份证";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "手机";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SexStr";
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "性别";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Deposit";
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "押金";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ArrivalDate";
            this.Column7.FillWeight = 120F;
            this.Column7.HeaderText = "入住时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // gbxRoomId
            // 
            this.gbxRoomId.Controls.Add(this.btnByRoomId);
            this.gbxRoomId.Controls.Add(this.txtRoomId);
            this.gbxRoomId.Controls.Add(this.label2);
            this.gbxRoomId.Location = new System.Drawing.Point(374, 6);
            this.gbxRoomId.Name = "gbxRoomId";
            this.gbxRoomId.Size = new System.Drawing.Size(360, 57);
            this.gbxRoomId.TabIndex = 1;
            this.gbxRoomId.TabStop = false;
            this.gbxRoomId.Text = "按房间号查询";
            // 
            // btnByRoomId
            // 
            this.btnByRoomId.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.btnByRoomId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByRoomId.Location = new System.Drawing.Point(252, 20);
            this.btnByRoomId.Name = "btnByRoomId";
            this.btnByRoomId.Size = new System.Drawing.Size(75, 23);
            this.btnByRoomId.TabIndex = 1;
            this.btnByRoomId.Text = "查询";
            this.btnByRoomId.UseVisualStyleBackColor = true;
            this.btnByRoomId.Click += new System.EventHandler(this.btnByRoomId_Click);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(94, 22);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(137, 21);
            this.txtRoomId.TabIndex = 0;
            this.txtRoomId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "房间编号：";
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.btnByName);
            this.gbxName.Controls.Add(this.txtName);
            this.gbxName.Controls.Add(this.label1);
            this.gbxName.Location = new System.Drawing.Point(8, 6);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(360, 57);
            this.gbxName.TabIndex = 0;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "按姓名查询";
            // 
            // btnByName
            // 
            this.btnByName.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.btnByName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByName.Location = new System.Drawing.Point(238, 23);
            this.btnByName.Name = "btnByName";
            this.btnByName.Size = new System.Drawing.Size(75, 23);
            this.btnByName.TabIndex = 1;
            this.btnByName.Text = "查询";
            this.btnByName.UseVisualStyleBackColor = true;
            this.btnByName.Click += new System.EventHandler(this.btnByName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.dgvRecord);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已结账";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
            this.dgvRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecord.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.dataGridViewTextBoxColumn8});
            this.dgvRecord.Location = new System.Drawing.Point(7, 68);
            this.dgvRecord.MultiSelect = false;
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(726, 396);
            this.dgvRecord.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRByName);
            this.groupBox1.Controls.Add(this.txtRName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按姓名查询";
            // 
            // btnRByName
            // 
            this.btnRByName.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.btnRByName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRByName.Location = new System.Drawing.Point(238, 23);
            this.btnRByName.Name = "btnRByName";
            this.btnRByName.Size = new System.Drawing.Size(75, 23);
            this.btnRByName.TabIndex = 1;
            this.btnRByName.Text = "查询";
            this.btnRByName.UseVisualStyleBackColor = true;
            this.btnRByName.Click += new System.EventHandler(this.btnRByName_Click);
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(80, 25);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(137, 21);
            this.txtRName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRByRoomId);
            this.groupBox2.Controls.Add(this.txtRRoomId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按房间号查询";
            // 
            // btnRByRoomId
            // 
            this.btnRByRoomId.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.btnRByRoomId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRByRoomId.Location = new System.Drawing.Point(252, 20);
            this.btnRByRoomId.Name = "btnRByRoomId";
            this.btnRByRoomId.Size = new System.Drawing.Size(75, 23);
            this.btnRByRoomId.TabIndex = 1;
            this.btnRByRoomId.Text = "查询";
            this.btnRByRoomId.UseVisualStyleBackColor = true;
            this.btnRByRoomId.Click += new System.EventHandler(this.btnRByRoomId_Click);
            // 
            // txtRRoomId
            // 
            this.txtRRoomId.Location = new System.Drawing.Point(94, 22);
            this.txtRRoomId.Name = "txtRRoomId";
            this.txtRRoomId.Size = new System.Drawing.Size(137, 21);
            this.txtRRoomId.TabIndex = 0;
            this.txtRRoomId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomId_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "房间编号：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(734, 59);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomId";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "房间编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CardNo";
            this.dataGridViewTextBoxColumn3.FillWeight = 110F;
            this.dataGridViewTextBoxColumn3.HeaderText = "身份证";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.FillWeight = 70F;
            this.dataGridViewTextBoxColumn4.HeaderText = "手机";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SexStr";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "性别";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Deposit";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "押金";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ArrivalDate";
            this.dataGridViewTextBoxColumn7.FillWeight = 110F;
            this.dataGridViewTextBoxColumn7.HeaderText = "入住时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LeaveDate";
            this.Column8.FillWeight = 110F;
            this.Column8.HeaderText = "退房时间";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RoomTotal";
            this.Column9.FillWeight = 40F;
            this.Column9.HeaderText = "房款";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "FoodTotal";
            this.Column10.FillWeight = 40F;
            this.Column10.HeaderText = "消费";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // FrmGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGuestInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客信息查询";
            this.Load += new System.EventHandler(this.FrmGuestInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxCheckOutInfo.ResumeLayout(false);
            this.gbxCheckOutInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestInfo)).EndInit();
            this.gbxRoomId.ResumeLayout(false);
            this.gbxRoomId.PerformLayout();
            this.gbxName.ResumeLayout(false);
            this.gbxName.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvGuestInfo;
        private System.Windows.Forms.GroupBox gbxName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxCheckOutInfo;
        private System.Windows.Forms.GroupBox gbxRoomId;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnByRoomId;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnByName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRByName;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRByRoomId;
        private System.Windows.Forms.TextBox txtRRoomId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}