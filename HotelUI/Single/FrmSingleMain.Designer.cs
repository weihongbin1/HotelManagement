namespace Hotel.UI.Single
{
    /// <summary>
    /// 指定主界面
    /// </summary>
    partial class FrmSingleMain
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
            this.pbxRoom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxFoods = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxCheck = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxSeeInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoods)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRoom
            // 
            this.pbxRoom.BackColor = System.Drawing.SystemColors.Control;
            this.pbxRoom.Image = global::Hotel.UI.Properties.Resources.gif_47_094;
            this.pbxRoom.Location = new System.Drawing.Point(22, 6);
            this.pbxRoom.Name = "pbxRoom";
            this.pbxRoom.Size = new System.Drawing.Size(150, 150);
            this.pbxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRoom.TabIndex = 1;
            this.pbxRoom.TabStop = false;
            this.pbxRoom.Click += new System.EventHandler(this.pbxRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbxRoom);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "状态类型";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbxFoods);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "订餐";
            // 
            // pbxFoods
            // 
            this.pbxFoods.BackColor = System.Drawing.SystemColors.Control;
            this.pbxFoods.Image = global::Hotel.UI.Properties.Resources.gif_47_052;
            this.pbxFoods.Location = new System.Drawing.Point(22, 6);
            this.pbxFoods.Name = "pbxFoods";
            this.pbxFoods.Size = new System.Drawing.Size(150, 150);
            this.pbxFoods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoods.TabIndex = 1;
            this.pbxFoods.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pbxCheck);
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "入住登记";
            // 
            // pbxCheck
            // 
            this.pbxCheck.BackColor = System.Drawing.SystemColors.Control;
            this.pbxCheck.Image = global::Hotel.UI.Properties.Resources.gif_47_030;
            this.pbxCheck.Location = new System.Drawing.Point(22, 6);
            this.pbxCheck.Name = "pbxCheck";
            this.pbxCheck.Size = new System.Drawing.Size(150, 150);
            this.pbxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCheck.TabIndex = 1;
            this.pbxCheck.TabStop = false;
            this.pbxCheck.Click += new System.EventHandler(this.pbxCheck_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pbxSeeInfo);
            this.panel4.Location = new System.Drawing.Point(200, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 200);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "人员查看";
            // 
            // pbxSeeInfo
            // 
            this.pbxSeeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pbxSeeInfo.Image = global::Hotel.UI.Properties.Resources.gif_47_106;
            this.pbxSeeInfo.Location = new System.Drawing.Point(22, 6);
            this.pbxSeeInfo.Name = "pbxSeeInfo";
            this.pbxSeeInfo.Size = new System.Drawing.Size(150, 150);
            this.pbxSeeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSeeInfo.TabIndex = 1;
            this.pbxSeeInfo.TabStop = false;
            this.pbxSeeInfo.Click += new System.EventHandler(this.pbxSeeInfo_Click);
            // 
            // FrmSingleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSingleMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoods)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCheck)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxFoods;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbxSeeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}