using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmFJYDEdit : Form
    {
        public frmFJYDEdit()
        {
            InitializeComponent();
        }
        

        private void btnFJ_Click(object sender, EventArgs e)
        {

            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "frmFJYDEdit.txtFJXX";
            frm.TableName = "房间信息";
            frm.CurForm = this;
            frm.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {

            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "frmFJYDEdit.txtKHXX";
            frm.TableName = "客户信息";
            frm.CurForm = this;
            frm.ShowDialog();
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtKHXX.Tag.ToString() == "" || this.txtFJXX.Tag.ToString() == "")
            {
                MessageBox.Show("房间或客户不能为空");
                return;
            }
            DataTable dt;
            dt = db.Get("select * from 房间预定 where ((开始日期 between '" + datKSRQ.Value.ToShortDateString() + "' and '" + datJSRQ.Value.ToShortDateString() + "' ) or  (截至日期 between '" + datKSRQ.Value.ToShortDateString() + "' and '" + datJSRQ.Value.ToShortDateString() + "' )) and 房间代码=" + txtFJXX.Tag + "");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("此房间的预定时间重复,不能预定!");
                return;
            }

            db.Exec(" INSERT INTO [房间预定] ([房间代码] ,[客户代码] ,[开始日期] ,[截至日期] ,[经办人] ) VALUES (" + txtFJXX.Tag.ToString() + "," + txtKHXX.Tag.ToString() + ",'" + datKSRQ.Value.ToShortDateString() + "','" + datJSRQ.Value.ToShortDateString() + "','" + txtJBR.Text + "')");
            MessageBox.Show("房间预定完成");
            Close();
        }
    }
}