namespace Hotel.UI
{
    /// <summary>
    /// 关于
    /// </summary>
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iltAbout = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.UI.Properties.Resources.a1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 168);
            this.label1.TabIndex = 1;
            this.label1.Text = "深圳市XXX国际酒店管理有限公司创立于XXX年，作为中国高档\r\n\r\n商务连锁酒店第一品牌，致力于为客户提供健康、舒适及良好\r\n\r\n的睡眠体验，在管理模式、人才梯队" +
    "、品牌培育、扩张发展、\r\n\r\n资本管理等方面处于全球酒店行业领先地位。\r\n                                           " +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = " 此产品版权归破冰小组团队所有，侵权必究";
            // 
            // iltAbout
            // 
            this.iltAbout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iltAbout.ImageStream")));
            this.iltAbout.TransparentColor = System.Drawing.Color.Transparent;
            this.iltAbout.Images.SetKeyName(0, "a1.jpg");
            this.iltAbout.Images.SetKeyName(1, "a2.jpg");
            this.iltAbout.Images.SetKeyName(2, "a3.jpg");
            this.iltAbout.Images.SetKeyName(3, "a4.jpg");
            this.iltAbout.Images.SetKeyName(4, "a5.jpg");
            this.iltAbout.Images.SetKeyName(5, "a6.jpg");
            this.iltAbout.Images.SetKeyName(6, "a7.jpg");
            this.iltAbout.Images.SetKeyName(7, "a8.jpg");
            this.iltAbout.Images.SetKeyName(8, "a9.jpg");
            this.iltAbout.Images.SetKeyName(9, "a10.jpg");
            this.iltAbout.Images.SetKeyName(10, "a11.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList iltAbout;
        private System.Windows.Forms.Timer timer1;
    }
}