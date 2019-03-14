using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class updatePwd : Form
    {
        public updatePwd()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            {
                //修改密码
                if (textBox1.Text != textBox2.Text)
                {
                    MessageBox.Show("密码不一致");
                    return;
                }
                db.Exec("update 用户 set 密码='" + textBox1.Text + "' where 用户名='" + db.strID + "'");
                MessageBox.Show("修改成功,下次使用");
                this.Close();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //关闭
            this.Close();
        }
    }
}