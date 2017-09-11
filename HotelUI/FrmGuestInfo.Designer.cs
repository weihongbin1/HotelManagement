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
            this.dgvGuestInfo = new System.Windows.Forms.DataGridView();
            this.gbxRoomId = new System.Windows.Forms.GroupBox();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxCheckOutInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestInfo)).BeginInit();
            this.gbxRoomId.SuspendLayout();
            this.gbxName.SuspendLayout();
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
            this.gbxCheckOutInfo.Controls.Add(this.button3);
            this.gbxCheckOutInfo.Controls.Add(this.textBox6);
            this.gbxCheckOutInfo.Controls.Add(this.label6);
            this.gbxCheckOutInfo.Controls.Add(this.textBox5);
            this.gbxCheckOutInfo.Controls.Add(this.label5);
            this.gbxCheckOutInfo.Controls.Add(this.textBox4);
            this.gbxCheckOutInfo.Controls.Add(this.label4);
            this.gbxCheckOutInfo.Controls.Add(this.textBox3);
            this.gbxCheckOutInfo.Controls.Add(this.label3);
            this.gbxCheckOutInfo.Location = new System.Drawing.Point(8, 407);
            this.gbxCheckOutInfo.Name = "gbxCheckOutInfo";
            this.gbxCheckOutInfo.Size = new System.Drawing.Size(726, 57);
            this.gbxCheckOutInfo.TabIndex = 1;
            this.gbxCheckOutInfo.TabStop = false;
            this.gbxCheckOutInfo.Text = "退房信息";
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
            this.Column7});
            this.dgvGuestInfo.Location = new System.Drawing.Point(8, 68);
            this.dgvGuestInfo.MultiSelect = false;
            this.dgvGuestInfo.Name = "dgvGuestInfo";
            this.dgvGuestInfo.ReadOnly = true;
            this.dgvGuestInfo.RowHeadersVisible = false;
            this.dgvGuestInfo.RowTemplate.Height = 23;
            this.dgvGuestInfo.Size = new System.Drawing.Size(726, 335);
            this.dgvGuestInfo.TabIndex = 1;
            // 
            // gbxRoomId
            // 
            this.gbxRoomId.Controls.Add(this.button2);
            this.gbxRoomId.Controls.Add(this.textBox2);
            this.gbxRoomId.Controls.Add(this.label2);
            this.gbxRoomId.Location = new System.Drawing.Point(374, 6);
            this.gbxRoomId.Name = "gbxRoomId";
            this.gbxRoomId.Size = new System.Drawing.Size(360, 57);
            this.gbxRoomId.TabIndex = 0;
            this.gbxRoomId.TabStop = false;
            this.gbxRoomId.Text = "按房间号查询";
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.button1);
            this.gbxName.Controls.Add(this.textBox1);
            this.gbxName.Controls.Add(this.label1);
            this.gbxName.Location = new System.Drawing.Point(8, 6);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(360, 57);
            this.gbxName.TabIndex = 0;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "按姓名查询";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已结账";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(238, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Hotel.UI.Properties.Resources.查询选择;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(252, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 21);
            this.textBox2.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "房款：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 21);
            this.textBox3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Image = global::Hotel.UI.Properties.Resources.保存;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(609, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "  确认退房";
            this.button3.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 21);
            this.textBox4.TabIndex = 1;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(349, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 21);
            this.textBox5.TabIndex = 1;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(496, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 21);
            this.textBox6.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "房间编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 130F;
            this.Column3.HeaderText = "身份证";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 92.978F;
            this.Column4.HeaderText = "手机";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "性别";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "押金";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 92.978F;
            this.Column7.HeaderText = "入住时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FrmGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}