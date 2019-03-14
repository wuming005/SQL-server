using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmKFRZEDit : Form
    {
        public frmKFRZEDit()
        {
            InitializeComponent();
        }
        // 下载于www.51aspx.com
        private void btnFJ_Click(object sender, EventArgs e)
        {

            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "frmKFRZEDit.txtFJXX";
            frm.TableName = "房间信息";
            frm.CurForm = this;
            frm.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {

            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "frmKFRZEDit.txtKHXX";
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
            if (this.txtYDXX.Tag.ToString()!="")
            {
                db.Exec(" INSERT INTO [房间入住] ( [房间代码] ,[客户代码] ,[入住日期] ,[预定代码] ,[预入住天数] ,[经办人]  ) VALUES ("+txtFJXX.Tag+","+txtKHXX.Tag+",'"+txtRZRQ.Text+"',"+txtYDXX.Tag+","+txtYJTS.Text+",'"+txtJBR.Text+"')");

            }
            else
            {
                DataTable dt;
                dt = db.Get("select * from 房间预定 where ((开始日期 between '" + Convert.ToDateTime(txtRZRQ.Text).ToShortDateString() + "' and '" + Convert.ToDateTime(txtRZRQ.Text).AddDays(Convert.ToDouble(txtYJTS.Text)).ToShortDateString() + "' ) or  (截至日期 between '" + Convert.ToDateTime(txtRZRQ.Text).ToShortDateString() + "' and '" + Convert.ToDateTime(txtRZRQ.Text).AddDays(Convert.ToDouble(txtYJTS.Text)).ToShortDateString() + "' )) and 房间代码=" + txtFJXX.Tag + "");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("此房间已经预定或入住,不能入住!");
                    return;
                }
                db.Exec(" INSERT INTO [房间入住] ( [房间代码] ,[客户代码] ,[入住日期]  ,[预入住天数] ,[经办人] ) VALUES ("+txtFJXX.Tag+","+txtKHXX.Tag+",'"+txtRZRQ.Text+"',"+txtYJTS.Text+",'"+txtJBR.Text+"')");

            }
            db.Exec("update 房间信息 set 房屋状态='住人' where 房间代码=" + txtFJXX.Tag + "");
            MessageBox.Show("办理入住完成");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "frmKFRZEDit.txtYDXX";
            frm.TableName = "预定信息";
            frm.CurForm = this;
            frm.ShowDialog();
            DataTable dt = new DataTable();
            if (this.txtYDXX.Tag != null)
            {
                dt = db.Get("SELECT 客户代码, 姓名, 性别, 随行人数, 证件类型, 证件号码, 民族, 籍贯, 地址, 电话, 备注 FROM dbo.客户 where 客户代码=(select 客户代码 from 房间预定 where 预定代码=" + txtYDXX.Tag.ToString() + ")");
                if (dt.Rows.Count > 0)
                {
                    txtKHXX.Text = "姓名：" + dt.Rows[0]["姓名"].ToString() + "\r\n性别：" + dt.Rows[0]["性别"].ToString() + "\r\n证件类型：" + dt.Rows[0]["证件类型"].ToString() + "\r\n证件号码：" + dt.Rows[0]["证件号码"].ToString();
                    txtKHXX.Tag = dt.Rows[0]["客户代码"].ToString();
 
                }
                dt = db.Get("SELECT 房间信息.房间代码, 房间信息.房号, 房间信息.楼层,       房间信息.单价, 房间信息.房间电话, 房间信息.房间备注,       房间信息.房屋状态, 客房类型.类型名称 FROM 房间信息 INNER JOIN       客房类型 ON 房间信息.类型代码 = 客房类型.类型代码 where 房间代码=(select 房间代码 from 房间预定 where 预定代码=" + txtYDXX.Tag.ToString() + ")");
                if (dt.Rows.Count > 0)
                {
                    txtFJXX.Text = "房号：" + dt.Rows[0]["房号"].ToString() + "\r\n楼层：" + dt.Rows[0]["楼层"].ToString() + "\r\n单价：" + dt.Rows[0]["单价"].ToString() + "\r\n房型：" + dt.Rows[0]["类型名称"].ToString();
                    txtFJXX.Tag = dt.Rows[0]["房间代码"].ToString();
                }
            }
        }

        private void frmKFRZEDit_Load(object sender, EventArgs e)
        {
            toolStripButton2_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.txtYDXX.Text = "";
            this.txtYDXX.Tag = "";
            this.txtKHXX.Text = "";
            this.txtKHXX.Tag = "";
            this.txtFJXX.Text = "";
            this.txtFJXX.Tag = "";
            txtRZRQ.Text = DateTime.Now.ToShortDateString();
        }
    }
}