using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmKhList : Form
    {
        public frmKhList()
        {
            InitializeComponent();
        }

        private void initDg()
        {
            //查询显示住户列表
            this.dataGridView1.DataSource = db.Get("SELECT * FROM dbo.客户");
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //调用窗体
            frmKhEdit frm = new frmKhEdit();
            frm.ShowDialog();
            initDg();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //调用窗体
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }
            frmKhEdit frm = new frmKhEdit();
            frm.ID = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm.ShowDialog();
            initDg();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ZhList_Activated(object sender, EventArgs e)
        {
            //窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void ZhList_Load(object sender, EventArgs e)
        {
            initDg();
        }

    }
}