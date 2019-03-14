namespace 酒店管理
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SysSubMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TButton3 = new System.Windows.Forms.ToolStripButton();
            this.TButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TButton5 = new System.Windows.Forms.ToolStripButton();
            this.TButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TButton2 = new System.Windows.Forms.ToolStripButton();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BusSubMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.预定客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房入住ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房结款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseSubMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseSubMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.BaseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.QueryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuerySubMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuerySubMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuerySubMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.toolStrip1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // SysMenu
            // 
            this.SysMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SysSubMenu1});
            this.SysMenu.Name = "SysMenu";
            this.SysMenu.Size = new System.Drawing.Size(81, 24);
            this.SysMenu.Text = "系统管理";
            // 
            // SysSubMenu1
            // 
            this.SysSubMenu1.Name = "SysSubMenu1";
            this.SysSubMenu1.Size = new System.Drawing.Size(181, 26);
            this.SysSubMenu1.Text = "用户信息管理";
            this.SysSubMenu1.Click += new System.EventHandler(this.SysSubMenu1_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // TButton3
            // 
            this.TButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TButton3.Name = "TButton3";
            this.TButton3.Size = new System.Drawing.Size(43, 28);
            this.TButton3.Text = "退房";
            this.TButton3.Click += new System.EventHandler(this.TButton3_Click);
            // 
            // TButton7
            // 
            this.TButton7.Image = ((System.Drawing.Image)(resources.GetObject("TButton7.Image")));
            this.TButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TButton7.Name = "TButton7";
            this.TButton7.Size = new System.Drawing.Size(97, 28);
            this.TButton7.Text = "退出系统";
            this.TButton7.Click += new System.EventHandler(this.TButton7_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // TButton5
            // 
            this.TButton5.Image = ((System.Drawing.Image)(resources.GetObject("TButton5.Image")));
            this.TButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TButton5.Name = "TButton5";
            this.TButton5.Size = new System.Drawing.Size(97, 28);
            this.TButton5.Text = "修改密码";
            this.TButton5.Click += new System.EventHandler(this.TButton5_Click);
            // 
            // TButton6
            // 
            this.TButton6.Image = ((System.Drawing.Image)(resources.GetObject("TButton6.Image")));
            this.TButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TButton6.Name = "TButton6";
            this.TButton6.Size = new System.Drawing.Size(97, 28);
            this.TButton6.Text = "重新登录";
            this.TButton6.Click += new System.EventHandler(this.TButton6_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.TButton2,
            this.TButton3,
            this.toolStripSeparator3,
            this.TButton5,
            this.TButton6,
            this.TButton7,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 28);
            this.toolStripButton1.Text = "客房信息管理";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TButton2
            // 
            this.TButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TButton2.Name = "TButton2";
            this.TButton2.Size = new System.Drawing.Size(43, 28);
            this.TButton2.Text = "开房";
            this.TButton2.Click += new System.EventHandler(this.TButton2_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // BusMenu
            // 
            this.BusMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BusSubMenu1,
            this.toolStripMenuItem7,
            this.预定客房ToolStripMenuItem,
            this.客房入住ToolStripMenuItem,
            this.客房结款ToolStripMenuItem});
            this.BusMenu.Name = "BusMenu";
            this.BusMenu.Size = new System.Drawing.Size(111, 24);
            this.BusMenu.Text = "业务信息管理";
            // 
            // BusSubMenu1
            // 
            this.BusSubMenu1.Name = "BusSubMenu1";
            this.BusSubMenu1.Size = new System.Drawing.Size(181, 26);
            this.BusSubMenu1.Text = "客户信息管理";
            this.BusSubMenu1.Click += new System.EventHandler(this.BusSubMenu1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(178, 6);
            // 
            // 预定客房ToolStripMenuItem
            // 
            this.预定客房ToolStripMenuItem.Name = "预定客房ToolStripMenuItem";
            this.预定客房ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.预定客房ToolStripMenuItem.Text = "预定客房";
            this.预定客房ToolStripMenuItem.Click += new System.EventHandler(this.预定客房ToolStripMenuItem_Click);
            // 
            // 客房入住ToolStripMenuItem
            // 
            this.客房入住ToolStripMenuItem.Name = "客房入住ToolStripMenuItem";
            this.客房入住ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.客房入住ToolStripMenuItem.Text = "客房入住";
            this.客房入住ToolStripMenuItem.Click += new System.EventHandler(this.客房入住ToolStripMenuItem_Click);
            // 
            // 客房结款ToolStripMenuItem
            // 
            this.客房结款ToolStripMenuItem.Name = "客房结款ToolStripMenuItem";
            this.客房结款ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.客房结款ToolStripMenuItem.Text = "客房结款";
            this.客房结款ToolStripMenuItem.Click += new System.EventHandler(this.客房结款ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem14.Text = "重新登录";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.重新登录ToolStripMenuItem.Text = "退出程序";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // BaseSubMenu1
            // 
            this.BaseSubMenu1.Name = "BaseSubMenu1";
            this.BaseSubMenu1.Size = new System.Drawing.Size(181, 26);
            this.BaseSubMenu1.Text = "客房类别管理";
            this.BaseSubMenu1.Click += new System.EventHandler(this.BaseSubMenu1_Click);
            // 
            // BaseSubMenu2
            // 
            this.BaseSubMenu2.Name = "BaseSubMenu2";
            this.BaseSubMenu2.Size = new System.Drawing.Size(181, 26);
            this.BaseSubMenu2.Text = "客房信息管理";
            this.BaseSubMenu2.Click += new System.EventHandler(this.BaseSubMenu2_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseMenu,
            this.BusMenu,
            this.QueryMenu,
            this.SysMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(871, 28);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "基础信息管理";
            // 
            // BaseMenu
            // 
            this.BaseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseSubMenu1,
            this.BaseSubMenu2,
            this.toolStripMenuItem4,
            this.修改密码ToolStripMenuItem,
            this.toolStripMenuItem14,
            this.重新登录ToolStripMenuItem});
            this.BaseMenu.Name = "BaseMenu";
            this.BaseMenu.Size = new System.Drawing.Size(111, 24);
            this.BaseMenu.Text = "基础信息管理";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(178, 6);
            // 
            // QueryMenu
            // 
            this.QueryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuerySubMenu1,
            this.QuerySubMenu2,
            this.toolStripMenuItem1,
            this.QuerySubMenu3,
            this.toolStripMenuItem13,
            this.toolStripMenuItem9});
            this.QueryMenu.Name = "QueryMenu";
            this.QueryMenu.Size = new System.Drawing.Size(111, 24);
            this.QueryMenu.Text = "查询信息管理";
            // 
            // QuerySubMenu1
            // 
            this.QuerySubMenu1.Name = "QuerySubMenu1";
            this.QuerySubMenu1.Size = new System.Drawing.Size(181, 26);
            this.QuerySubMenu1.Text = "客房信息查询";
            this.QuerySubMenu1.Click += new System.EventHandler(this.QuerySubMenu1_Click);
            // 
            // QuerySubMenu2
            // 
            this.QuerySubMenu2.Name = "QuerySubMenu2";
            this.QuerySubMenu2.Size = new System.Drawing.Size(181, 26);
            this.QuerySubMenu2.Text = "客户信息查询";
            this.QuerySubMenu2.Click += new System.EventHandler(this.QuerySubMenu2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // QuerySubMenu3
            // 
            this.QuerySubMenu3.Name = "QuerySubMenu3";
            this.QuerySubMenu3.Size = new System.Drawing.Size(181, 26);
            this.QuerySubMenu3.Text = "预定信息查询";
            this.QuerySubMenu3.Click += new System.EventHandler(this.QuerySubMenu3_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem13.Text = "入住信息查询";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(871, 469);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "快捷酒店客房管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem SysMenu;
        private System.Windows.Forms.ToolStripMenuItem SysSubMenu1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TButton3;
        private System.Windows.Forms.ToolStripButton TButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TButton5;
        private System.Windows.Forms.ToolStripButton TButton6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusMenu;
        private System.Windows.Forms.ToolStripMenuItem BusSubMenu1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem 预定客房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房入住ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房结款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaseSubMenu1;
        private System.Windows.Forms.ToolStripMenuItem BaseSubMenu2;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem BaseMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem QueryMenu;
        private System.Windows.Forms.ToolStripMenuItem QuerySubMenu1;
        private System.Windows.Forms.ToolStripMenuItem QuerySubMenu2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuerySubMenu3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripButton TButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Diagnostics.EventLog eventLog1;
    }
}