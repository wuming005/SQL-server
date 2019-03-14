using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //判断登录用户的信息是否正确
            DataTable dt = new DataTable();
            dt = db.Get("select * from 用户 where 用户名='" + textBox1.Text + "' and 密码='" + textBox2.Text + "'");
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frmMain frm = new frmMain();
                db.strID = textBox1.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("帐号或密码错误!");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //结束程序
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}