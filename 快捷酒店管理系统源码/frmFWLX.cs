using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmFWLX : Form
    {
        public frmFWLX()
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
            if (db.Get("select * from 客房类型 where 类型名称 ='" + textBox1.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("类型名称重复");
                textBox1.Text = "";
                return;
            }
            //保存新费用类型
            db.Exec("insert into 客房类型(类型名称) values('" + textBox1.Text + "')");
            this.dataGridView1.DataSource = db.Get("select * from 客房类型");
            textBox1.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //删除当前选择的费用类型
            db.Exec("delete 客房类型 where 类型名称='" + textBox1.Text + "'");
            textBox1.Text = "";
            this.dataGridView1.DataSource = db.Get("select * from 客房类型");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //显示当前选择的费用类型
            this.textBox1.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FylxList_Load(object sender, EventArgs e)
        {
            //绑定费用类型列表
            this.dataGridView1.DataSource = db.Get("select * from 客房类型");
            this.dataGridView1.Columns[1].Width = dataGridView1.Width - 100;
            this.dataGridView1.Columns[0].Visible = false;
        }
    }
}