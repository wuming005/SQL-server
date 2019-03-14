using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmFJList : Form
    {
        public frmFJList()
        {
            InitializeComponent();
        }

        private void initDg()
        {
            //查询显示住户列表
            this.dataGridView1.DataSource = db.Get("SELECT 房间信息.房间代码, 房间信息.房号, 房间信息.楼层, 房间信息.房间电话, 房间信息.单价, 房间信息.房间备注, 房间信息.房屋状态, 客房类型.类型名称 FROM 房间信息 INNER JOIN 客房类型 ON 房间信息.类型代码 = 客房类型.类型代码");
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //调用窗体
            FrmFjEdit frm = new FrmFjEdit();
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
            FrmFjEdit frm = new FrmFjEdit();
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