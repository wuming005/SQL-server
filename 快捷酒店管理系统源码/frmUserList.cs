using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            //判断信息不能重复
            if (db.Get("select * from 用户 where 用户名 ='" + textBox1.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("用户名重复");
                textBox1.Text = "";
                return;
            }
            //保存新费用类型
            db.Exec("insert into 用户(用户名,密码) values('" + textBox1.Text + "','000000')");
            this.dataGridView1.DataSource = db.Get("select 用户名 from 用户 where 用户名<>'admin'");
            textBox1.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //删除当前选择的费用类型
            db.Exec("delete 用户 where 用户名='" + textBox1.Text + "'");
            textBox1.Text = "";
            this.dataGridView1.DataSource = db.Get("select 用户名 from 用户 where 用户名<>'admin'");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //显示当前选择的费用类型
            this.textBox1.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void FylxList_Load(object sender, EventArgs e)
        {
            //绑定费用类型列表
            this.dataGridView1.DataSource = db.Get("select 用户名 from 用户 where 用户名<>'admin'");
            this.dataGridView1.Columns[0].Width = dataGridView1.Width - 100;
        }
    }
}