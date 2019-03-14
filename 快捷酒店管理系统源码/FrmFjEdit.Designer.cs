namespace 酒店管理
{
    partial class FrmFjEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label 修理结果Label;
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtLXDM = new System.Windows.Forms.TextBox();
            this.txtDJ = new System.Windows.Forms.TextBox();
            this.txtFH = new System.Windows.Forms.TextBox();
            this.txtLC = new System.Windows.Forms.TextBox();
            this.txtFWZT = new System.Windows.Forms.TextBox();
            this.txtFJDH = new System.Windows.Forms.TextBox();
            this.txtBZ = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            修理结果Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(231, 185);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(59, 12);
            label12.TabIndex = 292;
            label12.Text = "房屋状态:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(15, 185);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(59, 12);
            label11.TabIndex = 290;
            label11.Text = "房间电话:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 12);
            label2.TabIndex = 289;
            label2.Text = "房屋备注:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 98);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 12);
            label6.TabIndex = 280;
            label6.Text = "楼层:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(232, 69);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 12);
            label5.TabIndex = 278;
            label5.Text = "房屋类型:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 12);
            label4.TabIndex = 275;
            label4.Text = "房号:";
            // 
            // 修理结果Label
            // 
            修理结果Label.AutoSize = true;
            修理结果Label.Location = new System.Drawing.Point(232, 98);
            修理结果Label.Name = "修理结果Label";
            修理结果Label.Size = new System.Drawing.Size(35, 12);
            修理结果Label.TabIndex = 273;
            修理结果Label.Text = "单价:";
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = null;
            this.BindingNavigator.CountItem = null;
            this.BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.BindingNavigatorSaveItem});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = null;
            this.BindingNavigator.MoveLastItem = null;
            this.BindingNavigator.MoveNextItem = null;
            this.BindingNavigator.MovePreviousItem = null;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = null;
            this.BindingNavigator.Size = new System.Drawing.Size(465, 25);
            this.BindingNavigator.TabIndex = 283;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "保存";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorSaveItem.Text = "取消";
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.BindingNavigatorSaveItem_Click);
            // 
            // txtLXDM
            // 
            this.txtLXDM.Location = new System.Drawing.Point(297, 63);
            this.txtLXDM.Name = "txtLXDM";
            this.txtLXDM.ReadOnly = true;
            this.txtLXDM.Size = new System.Drawing.Size(99, 21);
            this.txtLXDM.TabIndex = 279;
            // 
            // txtDJ
            // 
            this.txtDJ.Location = new System.Drawing.Point(297, 94);
            this.txtDJ.Name = "txtDJ";
            this.txtDJ.Size = new System.Drawing.Size(138, 21);
            this.txtDJ.TabIndex = 274;
            // 
            // txtFH
            // 
            this.txtFH.Location = new System.Drawing.Point(77, 63);
            this.txtFH.Name = "txtFH";
            this.txtFH.Size = new System.Drawing.Size(138, 21);
            this.txtFH.TabIndex = 276;
            // 
            // txtLC
            // 
            this.txtLC.Location = new System.Drawing.Point(77, 95);
            this.txtLC.Name = "txtLC";
            this.txtLC.Size = new System.Drawing.Size(138, 21);
            this.txtLC.TabIndex = 282;
            // 
            // txtFWZT
            // 
            this.txtFWZT.Location = new System.Drawing.Point(300, 179);
            this.txtFWZT.Name = "txtFWZT";
            this.txtFWZT.ReadOnly = true;
            this.txtFWZT.Size = new System.Drawing.Size(138, 21);
            this.txtFWZT.TabIndex = 293;
            // 
            // txtFJDH
            // 
            this.txtFJDH.Location = new System.Drawing.Point(77, 179);
            this.txtFJDH.Name = "txtFJDH";
            this.txtFJDH.Size = new System.Drawing.Size(138, 21);
            this.txtFJDH.TabIndex = 291;
            // 
            // txtBZ
            // 
            this.txtBZ.Location = new System.Drawing.Point(77, 124);
            this.txtBZ.Multiline = true;
            this.txtBZ.Name = "txtBZ";
            this.txtBZ.Size = new System.Drawing.Size(358, 42);
            this.txtBZ.TabIndex = 288;
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(401, 63);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(34, 23);
            this.btn.TabIndex = 296;
            this.btn.Text = "...";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmFjEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 245);
            this.ControlBox = false;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.BindingNavigator);
            this.Controls.Add(this.txtLXDM);
            this.Controls.Add(this.txtDJ);
            this.Controls.Add(this.txtFH);
            this.Controls.Add(this.txtLC);
            this.Controls.Add(this.txtFWZT);
            this.Controls.Add(label12);
            this.Controls.Add(this.txtFJDH);
            this.Controls.Add(label11);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtBZ);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(修理结果Label);
            this.Name = "FrmFjEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息";
            this.Load += new System.EventHandler(this.ZhbxEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        public System.Windows.Forms.TextBox txtLXDM;
        private System.Windows.Forms.TextBox txtDJ;
        public System.Windows.Forms.TextBox txtFH;
        public System.Windows.Forms.TextBox txtLC;
        private System.Windows.Forms.TextBox txtFWZT;
        private System.Windows.Forms.TextBox txtFJDH;
        private System.Windows.Forms.TextBox txtBZ;
        private System.Windows.Forms.Button btn;

    }
}