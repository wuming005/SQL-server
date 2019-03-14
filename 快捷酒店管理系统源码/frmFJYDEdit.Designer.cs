namespace 酒店管理
{
    partial class frmFJYDEdit
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnFJ = new System.Windows.Forms.Button();
            this.txtFJXX = new System.Windows.Forms.TextBox();
            this.txtJBR = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnKH = new System.Windows.Forms.Button();
            this.txtKHXX = new System.Windows.Forms.TextBox();
            this.datKSRQ = new System.Windows.Forms.DateTimePicker();
            this.datJSRQ = new System.Windows.Forms.DateTimePicker();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(12, 244);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(47, 12);
            label12.TabIndex = 310;
            label12.Text = "经办人:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(12, 211);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(59, 12);
            label11.TabIndex = 308;
            label11.Text = "开始日期:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 139);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 12);
            label6.TabIndex = 303;
            label6.Text = "客户信息:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 12);
            label4.TabIndex = 299;
            label4.Text = "房间信息:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(231, 211);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 12);
            label1.TabIndex = 316;
            label1.Text = "结束日期:";
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorSaveItem.Text = "取消";
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.BindingNavigatorSaveItem_Click);
            // 
            // btnFJ
            // 
            this.btnFJ.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFJ.Location = new System.Drawing.Point(401, 54);
            this.btnFJ.Name = "btnFJ";
            this.btnFJ.Size = new System.Drawing.Size(34, 21);
            this.btnFJ.TabIndex = 312;
            this.btnFJ.Text = "...";
            this.btnFJ.UseVisualStyleBackColor = true;
            this.btnFJ.Click += new System.EventHandler(this.btnFJ_Click);
            // 
            // txtFJXX
            // 
            this.txtFJXX.Location = new System.Drawing.Point(77, 54);
            this.txtFJXX.Multiline = true;
            this.txtFJXX.Name = "txtFJXX";
            this.txtFJXX.Size = new System.Drawing.Size(318, 75);
            this.txtFJXX.TabIndex = 300;
            // 
            // txtJBR
            // 
            this.txtJBR.Location = new System.Drawing.Point(77, 241);
            this.txtJBR.Name = "txtJBR";
            this.txtJBR.Size = new System.Drawing.Size(138, 21);
            this.txtJBR.TabIndex = 309;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "预定";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = null;
            this.BindingNavigator.CountItem = null;
            this.BindingNavigator.DeleteItem = null;
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.BindingNavigatorSaveItem});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = null;
            this.BindingNavigator.MoveLastItem = null;
            this.BindingNavigator.MoveNextItem = null;
            this.BindingNavigator.MovePreviousItem = null;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = null;
            this.BindingNavigator.Size = new System.Drawing.Size(455, 25);
            this.BindingNavigator.TabIndex = 305;
            // 
            // btnKH
            // 
            this.btnKH.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Location = new System.Drawing.Point(401, 135);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(34, 21);
            this.btnKH.TabIndex = 314;
            this.btnKH.Text = "...";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // txtKHXX
            // 
            this.txtKHXX.Location = new System.Drawing.Point(77, 135);
            this.txtKHXX.Multiline = true;
            this.txtKHXX.Name = "txtKHXX";
            this.txtKHXX.Size = new System.Drawing.Size(318, 64);
            this.txtKHXX.TabIndex = 313;
            // 
            // datKSRQ
            // 
            this.datKSRQ.Location = new System.Drawing.Point(77, 207);
            this.datKSRQ.Name = "datKSRQ";
            this.datKSRQ.Size = new System.Drawing.Size(138, 21);
            this.datKSRQ.TabIndex = 315;
            // 
            // datJSRQ
            // 
            this.datJSRQ.Location = new System.Drawing.Point(296, 207);
            this.datJSRQ.Name = "datJSRQ";
            this.datJSRQ.Size = new System.Drawing.Size(138, 21);
            this.datJSRQ.TabIndex = 317;
            // 
            // frmFJYDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 292);
            this.ControlBox = false;
            this.Controls.Add(this.datJSRQ);
            this.Controls.Add(label1);
            this.Controls.Add(this.datKSRQ);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.txtKHXX);
            this.Controls.Add(this.btnFJ);
            this.Controls.Add(this.txtFJXX);
            this.Controls.Add(this.txtJBR);
            this.Controls.Add(label12);
            this.Controls.Add(label11);
            this.Controls.Add(label6);
            this.Controls.Add(this.BindingNavigator);
            this.Controls.Add(label4);
            this.Name = "frmFJYDEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定房间信息";
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnFJ;
        public System.Windows.Forms.TextBox txtFJXX;
        private System.Windows.Forms.TextBox txtJBR;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator BindingNavigator;
        private System.Windows.Forms.Button btnKH;
        public System.Windows.Forms.TextBox txtKHXX;
        private System.Windows.Forms.DateTimePicker datKSRQ;
        private System.Windows.Forms.DateTimePicker datJSRQ;
    }
}