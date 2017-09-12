namespace Hotel.UI.Single
{
    /// <summary>
    /// 单个房间信息
    /// </summary>
    partial class FrmSingleGuestInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoomTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Location = new System.Drawing.Point(86, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(184, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(110, 309);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "退房";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtArrivalDate.Location = new System.Drawing.Point(86, 177);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.ReadOnly = true;
            this.txtArrivalDate.Size = new System.Drawing.Size(184, 21);
            this.txtArrivalDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "入住时间";
            // 
            // txtFoodTotal
            // 
            this.txtFoodTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFoodTotal.Location = new System.Drawing.Point(86, 243);
            this.txtFoodTotal.Name = "txtFoodTotal";
            this.txtFoodTotal.ReadOnly = true;
            this.txtFoodTotal.Size = new System.Drawing.Size(184, 21);
            this.txtFoodTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "消费";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMoney.Location = new System.Drawing.Point(86, 276);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(184, 21);
            this.txtMoney.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "应付";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhone.Location = new System.Drawing.Point(86, 78);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(184, 21);
            this.txtPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "联系电话";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.Location = new System.Drawing.Point(86, 45);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(184, 21);
            this.txtId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "身份证";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "性别";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSex.Location = new System.Drawing.Point(86, 111);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(184, 21);
            this.txtSex.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "押金";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDeposit.Location = new System.Drawing.Point(86, 144);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.Size = new System.Drawing.Size(184, 21);
            this.txtDeposit.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "房款";
            // 
            // txtRoomTotal
            // 
            this.txtRoomTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRoomTotal.Location = new System.Drawing.Point(86, 210);
            this.txtRoomTotal.Name = "txtRoomTotal";
            this.txtRoomTotal.ReadOnly = true;
            this.txtRoomTotal.Size = new System.Drawing.Size(184, 21);
            this.txtRoomTotal.TabIndex = 4;
            // 
            // FrmSingleGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 344);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFoodTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSingleGuestInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客信息";
            this.Load += new System.EventHandler(this.FrmSingleGuestInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRoomTotal;
    }
}