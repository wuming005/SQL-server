using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmKhEdit : Form
    {
        public frmKhEdit()
        {
            InitializeComponent();
        }

        //窗体属性
        private string mID = "";
        public string ID
        {
            set
            {
                mID = value.Trim();
            }
            get
            {
                return mID;
            }
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //删除当前的住户报修
            db.Exec("delete  客户  where 客户代码=" + mID + "");
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //校验信息
            if (txtXM.Text == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            //根据不同的标志添加 或修改住户报修信息
            if (mID == "")
            {

                db.Exec("insert into [客户]([姓名] ,[性别] ,[随行人数] ,[证件类型] ,[证件号码] ,[民族] ,[籍贯] ,[地址] ,[电话] ,[备注] ) VALUES ('"+txtXM.Text+"','"+cbXB.Text+"','"+txtSXRS.Text+"','"+cbZJLX.Text+"','"+txtZJHM.Text+"','"+ cbMZ.Text+"','"+txtJG.Text+"','"+txtDZ.Text+"','"+txtDH.Text+"','"+txtBZ.Text+"')");
            }
            else
            {
                db.Exec("UPDATE [客户] set [姓名] ='" + txtXM.Text + "',[性别] = '" + cbXB.Text + "',[随行人数] = '" + txtSXRS.Text + "',[证件类型] ='" + cbZJLX.Text + "',[证件号码] = '" + txtZJHM.Text + "',[民族] = '" + cbMZ.Text + "',[籍贯] ='" + txtJG.Text + "',[地址] = '" + txtDZ.Text + "',[电话] ='" + txtDH.Text + "',[备注] = '" + txtBZ.Text + "' WHERE 客户代码=" + mID + " ");

            }
            Close();
        }

        private void ZhbxEdit_Load(object sender, EventArgs e)
        {
            if (mID != "")
            {
                //显示当前的住户报修信息到窗体上
                bindingNavigatorDeleteItem.Enabled = true;
                DataTable dt;
                dt = db.Get("SELECT * FROM 客户  where  客户代码=" + mID + "");
                if (dt.Rows.Count > 0)
                {
                    txtXM.Text = dt.Rows[0]["姓名"].ToString();
                    txtDH.Text = dt.Rows[0]["性别"].ToString();
                    txtSXRS.Text = dt.Rows[0]["随行人数"].ToString();
                    cbZJLX.SelectedText = dt.Rows[0]["证件类型"].ToString();
                    txtZJHM.Text = dt.Rows[0]["证件号码"].ToString();
                    cbMZ.SelectedText= dt.Rows[0]["民族"].ToString();
                    txtJG.SelectedText = dt.Rows[0]["籍贯"].ToString();
                    txtDZ.Text = dt.Rows[0]["地址"].ToString();
                    txtDH.Text = dt.Rows[0]["电话"].ToString();
                    txtBZ.Text = dt.Rows[0]["备注"].ToString();                   

                }
            }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}