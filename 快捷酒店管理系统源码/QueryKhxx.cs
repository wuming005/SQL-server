using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class QueryKhxx : Form
    {
        public QueryKhxx()
        {
            InitializeComponent();
        }

        private void initDg()
        {
            //查询显示员工列表
            this.dataGridView1.DataSource = db.Get("SELECT * FROM dbo.客户 where 姓名 like'%" + textBox9.Text + "%' and 地址 like '%" + textBox10.Text + "%' ");
            this.dataGridView1.Columns[5].Width = 400;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //调用窗体
            initDg();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QueryYgList_Load(object sender, EventArgs e)
        {
            initDg();
        }

        private void QueryYgList_Activated(object sender, EventArgs e)
        {
            //窗体最大化
            this.WindowState = FormWindowState.Maximized;
        }

    }
}