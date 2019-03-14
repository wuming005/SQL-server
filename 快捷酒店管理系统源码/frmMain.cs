using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CloseMdiForm()
        {
            //检索并关闭所有的mdi子窗体
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
                
            }
        }


        private void BaseSubMenu1_Click(object sender, EventArgs e)
        {
            //调用窗体
            frmFWLX frm = new frmFWLX();
            frm.ShowDialog();
        }

        private void BaseSubMenu2_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmFJList frm = new frmFJList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BusSubMenu1_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmKhList frm = new frmKhList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 预定客房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmFJYDList frm = new frmFJYDList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 客房入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmKFRZList frm = new frmKFRZList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 客房结款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            TFList frm = new TFList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QuerySubMenu1_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            QueryKFXX frm = new QueryKFXX();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QuerySubMenu2_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            QueryKhxx frm = new QueryKhxx();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QuerySubMenu3_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            QueryYdxx frm = new QueryYdxx();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            QueryRZXX frm = new QueryRZXX();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SysSubMenu1_Click(object sender, EventArgs e)
        {
            //调用窗体
            frmUserList frm = new frmUserList();
            frm.ShowDialog();
        }


        private void frmMain_Activated(object sender, EventArgs e)
        {
            //根据登录的不同用户设置权限菜单
          
                BaseMenu.Enabled = true;
                SysMenu.Enabled = true;
                toolStripButton1.Enabled = true;
            
        }

        private void TButton6_Click(object sender, EventArgs e)
        {
            //调用窗体
            Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void TButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否确认退出", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //结束程序
                Application.Exit();
            }   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmFJList frm = new frmFJList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TButton2_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            frmKFRZList frm = new frmKFRZList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TButton3_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            TFList frm = new TFList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TButton5_Click(object sender, EventArgs e)
        {
 
            CloseMdiForm();
            updatePwd frm = new updatePwd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseMdiForm();
            updatePwd frm = new updatePwd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            //调用窗体
            Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否确认退出", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //结束程序
                Application.Exit();
            }   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}