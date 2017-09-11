namespace Hotel.UI.Single
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rboRepair = new System.Windows.Forms.RadioButton();
            this.rboFree = new System.Windows.Forms.RadioButton();
            this.rboCheck = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间类型：";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(96, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(145, 20);
            this.cmbType.TabIndex = 1;
            // 
            // rboRepair
            // 
            this.rboRepair.AutoSize = true;
            this.rboRepair.Location = new System.Drawing.Point(194, 64);
            this.rboRepair.Name = "rboRepair";
            this.rboRepair.Size = new System.Drawing.Size(47, 16);
            this.rboRepair.TabIndex = 10;
            this.rboRepair.Text = "维修";
            this.rboRepair.UseVisualStyleBackColor = true;
            // 
            // rboFree
            // 
            this.rboFree.AutoSize = true;
            this.rboFree.Location = new System.Drawing.Point(145, 64);
            this.rboFree.Name = "rboFree";
            this.rboFree.Size = new System.Drawing.Size(47, 16);
            this.rboFree.TabIndex = 11;
            this.rboFree.Text = "空闲";
            this.rboFree.UseVisualStyleBackColor = true;
            // 
            // rboCheck
            // 
            this.rboCheck.AutoSize = true;
            this.rboCheck.Checked = true;
            this.rboCheck.Location = new System.Drawing.Point(96, 64);
            this.rboCheck.Name = "rboCheck";
            this.rboCheck.Size = new System.Drawing.Size(47, 16);
            this.rboCheck.TabIndex = 12;
            this.rboCheck.TabStop = true;
            this.rboCheck.Text = "入住";
            this.rboCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "房间状态：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(41, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "取消";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 147);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rboRepair);
            this.Controls.Add(this.rboFree);
            this.Controls.Add(this.rboCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间管理";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RadioButton rboRepair;
        private System.Windows.Forms.RadioButton rboFree;
        private System.Windows.Forms.RadioButton rboCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}