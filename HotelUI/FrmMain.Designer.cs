namespace Hotel.UI
{
    /// <summary>
    /// 主窗体自动生成代码
    /// </summary>
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tspInfo = new System.Windows.Forms.ToolStrip();
            this.tsbDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWeek = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLogOn = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxStatistics = new System.Windows.Forms.GroupBox();
            this.txtCheckRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepair = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTypeList = new System.Windows.Forms.GroupBox();
            this.tvwRoomType = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxState = new System.Windows.Forms.GroupBox();
            this.lvwRoomInfo = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Window = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomStateId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsRoomInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgsRoomState = new System.Windows.Forms.ImageList(this.components);
            this.imgsMinState = new System.Windows.Forms.ImageList(this.components);
            this.tspFunction = new System.Windows.Forms.ToolStrip();
            this.tsbType = new System.Windows.Forms.ToolStripButton();
            this.tsbRoom = new System.Windows.Forms.ToolStripButton();
            this.tsbFoods = new System.Windows.Forms.ToolStripButton();
            this.tsbStatistics = new System.Windows.Forms.ToolStripButton();
            this.tsbCheckIn = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbLock = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tspInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxStatistics.SuspendLayout();
            this.gbxTypeList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxState.SuspendLayout();
            this.cmsRoomInfo.SuspendLayout();
            this.tspFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspInfo
            // 
            this.tspInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tspInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.tspInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDate,
            this.toolStripSeparator1,
            this.tsbWeek,
            this.toolStripSeparator2,
            this.tsbUser,
            this.toolStripSeparator3,
            this.tsbLogOn});
            this.tspInfo.Location = new System.Drawing.Point(0, 652);
            this.tspInfo.Name = "tspInfo";
            this.tspInfo.Size = new System.Drawing.Size(230, 25);
            this.tspInfo.TabIndex = 1;
            this.tspInfo.Text = "toolStrip2";
            // 
            // tsbDate
            // 
            this.tsbDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDate.Image")));
            this.tsbDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDate.Name = "tsbDate";
            this.tsbDate.Size = new System.Drawing.Size(56, 22);
            this.tsbDate.Text = "当前时间";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbWeek
            // 
            this.tsbWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbWeek.Image = ((System.Drawing.Image)(resources.GetObject("tsbWeek.Image")));
            this.tsbWeek.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWeek.Name = "tsbWeek";
            this.tsbWeek.Size = new System.Drawing.Size(32, 22);
            this.tsbWeek.Text = "星期";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUser
            // 
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(56, 22);
            this.tsbUser.Text = "登录用户";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLogOn
            // 
            this.tsbLogOn.Name = "tsbLogOn";
            this.tsbLogOn.Size = new System.Drawing.Size(56, 22);
            this.tsbLogOn.Text = "登录时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单SToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单SToolStripMenuItem
            // 
            this.菜单SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xiuToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.菜单SToolStripMenuItem.Name = "菜单SToolStripMenuItem";
            this.菜单SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.菜单SToolStripMenuItem.Text = "菜单(&S)";
            // 
            // xiuToolStripMenuItem
            // 
            this.xiuToolStripMenuItem.Name = "xiuToolStripMenuItem";
            this.xiuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xiuToolStripMenuItem.Text = "修改密码(&U)";
            this.xiuToolStripMenuItem.Click += new System.EventHandler(this.xiuToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmAbout.Text = "关于(&A)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.gbxStatistics);
            this.panel1.Controls.Add(this.gbxTypeList);
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 521);
            this.panel1.TabIndex = 4;
            // 
            // gbxStatistics
            // 
            this.gbxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStatistics.Controls.Add(this.txtCheckRate);
            this.gbxStatistics.Controls.Add(this.label6);
            this.gbxStatistics.Controls.Add(this.txtRepair);
            this.gbxStatistics.Controls.Add(this.label5);
            this.gbxStatistics.Controls.Add(this.txtFree);
            this.gbxStatistics.Controls.Add(this.label4);
            this.gbxStatistics.Controls.Add(this.txtCheck);
            this.gbxStatistics.Controls.Add(this.label3);
            this.gbxStatistics.Controls.Add(this.txtRoomNum);
            this.gbxStatistics.Controls.Add(this.label2);
            this.gbxStatistics.Controls.Add(this.txtType);
            this.gbxStatistics.Controls.Add(this.label1);
            this.gbxStatistics.Location = new System.Drawing.Point(12, 269);
            this.gbxStatistics.Name = "gbxStatistics";
            this.gbxStatistics.Size = new System.Drawing.Size(198, 249);
            this.gbxStatistics.TabIndex = 1;
            this.gbxStatistics.TabStop = false;
            this.gbxStatistics.Text = "房间统计";
            // 
            // txtCheckRate
            // 
            this.txtCheckRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCheckRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheckRate.Location = new System.Drawing.Point(81, 216);
            this.txtCheckRate.Name = "txtCheckRate";
            this.txtCheckRate.ReadOnly = true;
            this.txtCheckRate.Size = new System.Drawing.Size(97, 26);
            this.txtCheckRate.TabIndex = 11;
            this.txtCheckRate.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "入住率：";
            // 
            // txtRepair
            // 
            this.txtRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair.BackColor = System.Drawing.Color.Yellow;
            this.txtRepair.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRepair.Location = new System.Drawing.Point(81, 177);
            this.txtRepair.Name = "txtRepair";
            this.txtRepair.ReadOnly = true;
            this.txtRepair.Size = new System.Drawing.Size(97, 26);
            this.txtRepair.TabIndex = 9;
            this.txtRepair.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "维  修：";
            // 
            // txtFree
            // 
            this.txtFree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFree.BackColor = System.Drawing.Color.Green;
            this.txtFree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFree.Location = new System.Drawing.Point(81, 138);
            this.txtFree.Name = "txtFree";
            this.txtFree.ReadOnly = true;
            this.txtFree.Size = new System.Drawing.Size(97, 26);
            this.txtFree.TabIndex = 7;
            this.txtFree.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "空  闲：";
            // 
            // txtCheck
            // 
            this.txtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheck.BackColor = System.Drawing.Color.Red;
            this.txtCheck.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCheck.Location = new System.Drawing.Point(81, 100);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(97, 26);
            this.txtCheck.TabIndex = 5;
            this.txtCheck.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "入  住：";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomNum.BackColor = System.Drawing.Color.Gray;
            this.txtRoomNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoomNum.Location = new System.Drawing.Point(81, 58);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.ReadOnly = true;
            this.txtRoomNum.Size = new System.Drawing.Size(97, 26);
            this.txtRoomNum.TabIndex = 3;
            this.txtRoomNum.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "房间数：";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(81, 19);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(97, 26);
            this.txtType.TabIndex = 1;
            this.txtType.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "类  型：";
            // 
            // gbxTypeList
            // 
            this.gbxTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTypeList.Controls.Add(this.tvwRoomType);
            this.gbxTypeList.Location = new System.Drawing.Point(12, 3);
            this.gbxTypeList.Name = "gbxTypeList";
            this.gbxTypeList.Size = new System.Drawing.Size(198, 260);
            this.gbxTypeList.TabIndex = 0;
            this.gbxTypeList.TabStop = false;
            this.gbxTypeList.Text = "房间类型列表";
            // 
            // tvwRoomType
            // 
            this.tvwRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwRoomType.Location = new System.Drawing.Point(6, 20);
            this.tvwRoomType.Name = "tvwRoomType";
            this.tvwRoomType.Size = new System.Drawing.Size(186, 234);
            this.tvwRoomType.TabIndex = 0;
            this.tvwRoomType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwRoomType_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gbxState);
            this.panel2.Location = new System.Drawing.Point(225, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 521);
            this.panel2.TabIndex = 0;
            // 
            // gbxState
            // 
            this.gbxState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxState.BackColor = System.Drawing.SystemColors.Control;
            this.gbxState.Controls.Add(this.lvwRoomInfo);
            this.gbxState.Location = new System.Drawing.Point(4, 8);
            this.gbxState.Name = "gbxState";
            this.gbxState.Size = new System.Drawing.Size(864, 510);
            this.gbxState.TabIndex = 1;
            this.gbxState.TabStop = false;
            this.gbxState.Text = "状态图";
            // 
            // lvwRoomInfo
            // 
            this.lvwRoomInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRoomInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwRoomInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.RoomType,
            this.Window,
            this.RoomStateId});
            this.lvwRoomInfo.ContextMenuStrip = this.cmsRoomInfo;
            this.lvwRoomInfo.FullRowSelect = true;
            this.lvwRoomInfo.GridLines = true;
            this.lvwRoomInfo.LargeImageList = this.imgsRoomState;
            this.lvwRoomInfo.Location = new System.Drawing.Point(6, 15);
            this.lvwRoomInfo.MultiSelect = false;
            this.lvwRoomInfo.Name = "lvwRoomInfo";
            this.lvwRoomInfo.Size = new System.Drawing.Size(852, 489);
            this.lvwRoomInfo.SmallImageList = this.imgsMinState;
            this.lvwRoomInfo.TabIndex = 0;
            this.lvwRoomInfo.UseCompatibleStateImageBehavior = false;
            this.lvwRoomInfo.Click += new System.EventHandler(this.lvwRoomInfo_Click);
            // 
            // number
            // 
            this.number.Text = "房间编号";
            this.number.Width = 98;
            // 
            // RoomType
            // 
            this.RoomType.Text = "房间类型";
            this.RoomType.Width = 122;
            // 
            // Window
            // 
            this.Window.DisplayIndex = 3;
            this.Window.Text = "是否有窗";
            this.Window.Width = 105;
            // 
            // RoomStateId
            // 
            this.RoomStateId.DisplayIndex = 2;
            this.RoomStateId.Text = "房间状态";
            this.RoomStateId.Width = 90;
            // 
            // cmsRoomInfo
            // 
            this.cmsRoomInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视图ToolStripMenuItem});
            this.cmsRoomInfo.Name = "cmsRoomInfo";
            this.cmsRoomInfo.Size = new System.Drawing.Size(101, 26);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.详细信息ToolStripMenuItem,
            this.平铺ToolStripMenuItem,
            this.列表ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 平铺ToolStripMenuItem
            // 
            this.平铺ToolStripMenuItem.Name = "平铺ToolStripMenuItem";
            this.平铺ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.平铺ToolStripMenuItem.Text = "平铺";
            this.平铺ToolStripMenuItem.Click += new System.EventHandler(this.平铺ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // imgsRoomState
            // 
            this.imgsRoomState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsRoomState.ImageStream")));
            this.imgsRoomState.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsRoomState.Images.SetKeyName(0, "yizhu.jpg");
            this.imgsRoomState.Images.SetKeyName(1, "weizhu.jpg");
            this.imgsRoomState.Images.SetKeyName(2, "huai.jpg");
            // 
            // imgsMinState
            // 
            this.imgsMinState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsMinState.ImageStream")));
            this.imgsMinState.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsMinState.Images.SetKeyName(0, "yizhu.jpg");
            this.imgsMinState.Images.SetKeyName(1, "weizhu.jpg");
            this.imgsMinState.Images.SetKeyName(2, "huai.jpg");
            // 
            // tspFunction
            // 
            this.tspFunction.AutoSize = false;
            this.tspFunction.BackgroundImage = global::Hotel.UI.Properties.Resources.banner;
            this.tspFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspFunction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbType,
            this.tsbRoom,
            this.tsbFoods,
            this.tsbStatistics,
            this.tsbCheckIn,
            this.tsbQuery,
            this.tsbLock,
            this.tsbExit});
            this.tspFunction.Location = new System.Drawing.Point(0, 25);
            this.tspFunction.Name = "tspFunction";
            this.tspFunction.Size = new System.Drawing.Size(1105, 100);
            this.tspFunction.TabIndex = 3;
            this.tspFunction.Text = "toolStrip1";
            // 
            // tsbType
            // 
            this.tsbType.AutoSize = false;
            this.tsbType.Image = global::Hotel.UI.Properties.Resources.gif_47_064;
            this.tsbType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbType.Name = "tsbType";
            this.tsbType.Size = new System.Drawing.Size(60, 99);
            this.tsbType.Text = "类型管理";
            this.tsbType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbType.Click += new System.EventHandler(this.tsbType_Click);
            // 
            // tsbRoom
            // 
            this.tsbRoom.AutoSize = false;
            this.tsbRoom.Image = global::Hotel.UI.Properties.Resources.gif_47_094;
            this.tsbRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoom.Name = "tsbRoom";
            this.tsbRoom.Size = new System.Drawing.Size(60, 99);
            this.tsbRoom.Text = "房间管理";
            this.tsbRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRoom.Click += new System.EventHandler(this.tsbRoom_Click);
            // 
            // tsbFoods
            // 
            this.tsbFoods.AutoSize = false;
            this.tsbFoods.Image = global::Hotel.UI.Properties.Resources.gif_47_052;
            this.tsbFoods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFoods.Name = "tsbFoods";
            this.tsbFoods.Size = new System.Drawing.Size(60, 99);
            this.tsbFoods.Text = "餐饮维护";
            this.tsbFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFoods.Click += new System.EventHandler(this.tsbFoods_Click);
            // 
            // tsbStatistics
            // 
            this.tsbStatistics.AutoSize = false;
            this.tsbStatistics.Image = global::Hotel.UI.Properties.Resources.gif_47_027;
            this.tsbStatistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatistics.Name = "tsbStatistics";
            this.tsbStatistics.Size = new System.Drawing.Size(60, 99);
            this.tsbStatistics.Text = "收入统计";
            this.tsbStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbStatistics.Click += new System.EventHandler(this.tsbStatistics_Click);
            // 
            // tsbCheckIn
            // 
            this.tsbCheckIn.AutoSize = false;
            this.tsbCheckIn.Image = global::Hotel.UI.Properties.Resources.gif_47_030;
            this.tsbCheckIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckIn.Name = "tsbCheckIn";
            this.tsbCheckIn.Size = new System.Drawing.Size(60, 99);
            this.tsbCheckIn.Text = "入住登记";
            this.tsbCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCheckIn.Click += new System.EventHandler(this.tsbCheckIn_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.AutoSize = false;
            this.tsbQuery.Image = global::Hotel.UI.Properties.Resources.gif_47_106;
            this.tsbQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(60, 99);
            this.tsbQuery.Text = "顾客查询";
            this.tsbQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbLock
            // 
            this.tsbLock.AutoSize = false;
            this.tsbLock.Image = global::Hotel.UI.Properties.Resources.gif_47_035;
            this.tsbLock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLock.Name = "tsbLock";
            this.tsbLock.Size = new System.Drawing.Size(60, 99);
            this.tsbLock.Text = "锁定";
            this.tsbLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLock.Click += new System.EventHandler(this.tsbLock_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.AutoSize = false;
            this.tsbExit.Image = global::Hotel.UI.Properties.Resources.叉叉;
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(60, 99);
            this.tsbExit.Text = "退出";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tspFunction);
            this.Controls.Add(this.tspInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tspInfo.ResumeLayout(false);
            this.tspInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbxStatistics.ResumeLayout(false);
            this.gbxStatistics.PerformLayout();
            this.gbxTypeList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbxState.ResumeLayout(false);
            this.cmsRoomInfo.ResumeLayout(false);
            this.tspFunction.ResumeLayout(false);
            this.tspFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspInfo;
        private System.Windows.Forms.ToolStripLabel tsbDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsbWeek;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsbUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsbLogOn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip tspFunction;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbType;
        private System.Windows.Forms.ToolStripButton tsbRoom;
        private System.Windows.Forms.ToolStripButton tsbFoods;
        private System.Windows.Forms.ToolStripButton tsbStatistics;
        private System.Windows.Forms.ToolStripButton tsbCheckIn;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbLock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbxStatistics;
        private System.Windows.Forms.TextBox txtCheckRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRepair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTypeList;
        private System.Windows.Forms.TreeView tvwRoomType;
        private System.Windows.Forms.GroupBox gbxState;
        private System.Windows.Forms.ImageList imgsRoomState;
        private System.Windows.Forms.ImageList imgsMinState;
        private System.Windows.Forms.ContextMenuStrip cmsRoomInfo;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平铺ToolStripMenuItem;
        private System.Windows.Forms.ListView lvwRoomInfo;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader RoomType;
        private System.Windows.Forms.ColumnHeader Window;
        private System.Windows.Forms.ColumnHeader RoomStateId;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
    }
}