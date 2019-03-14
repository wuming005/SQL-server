using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class FrmFjEdit : Form
    {
        public FrmFjEdit()
        {
            InitializeComponent();
        }

        //窗体属性
        private string mID = "";
        private string mPID = "";
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
        public string PID
        {
            set
            {
                mPID = value.Trim();
            }
            get
            {
                return mPID;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //显示选择的住户信息
            frmSelectInfo frm = new frmSelectInfo();
            frm.Flag = "FrmFjEdit.txtLXDM";
            frm.TableName = "客房类型";
            frm.CurForm = this;
            frm.ShowDialog();
            DataTable dt = new DataTable();
            if (mPID == "")
            {
                return;
            }
            dt = db.Get("SELECT * frOM 客房类型  where  类型代码=" + mPID + "");
            if (dt.Rows.Count > 0)
            {
                txtLXDM.Text = dt.Rows[0]["类型名称"].ToString();
                txtLXDM.Tag = dt.Rows[0]["类型代码"].ToString();
            }
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //删除当前的住户报修
            db.Exec("delete  房间信息  where 房间代码=" + mID + "");
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //校验信息
            if (txtFH.Text == "")
            {
                MessageBox.Show("房号不能为空");
                return;
            }
            //根据不同的标志添加 或修改住户报修信息
            if (mID == "")
            {
 
                db.Exec("INSERT INTO [房间信息] ( [房号] ,[类型代码] ,[楼层] ,[单价] ,[房间电话] ,[房间备注] ,[房屋状态] ) VALUES ('"+txtFH.Text+"',"+mPID+",'"+txtLC.Text+"',"+txtDJ.Text+",'"+txtFJDH.Text+"','"+txtBZ.Text+"','空闲')");
            }
            else
            {
                db.Exec("UPDATE [房间信息] set [类型代码] = " + mPID + ",[楼层] ='" + txtLC.Text + "',[单价] = " + txtDJ.Text + ",[房间电话] = '" + txtFJDH.Text + "',[房间备注] ='" + txtBZ.Text + "' where 房间代码=" + mID + " ");

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
                dt = db.Get("SELECT * FROM dbo.房间信息 INNER JOIN dbo.客房类型 ON dbo.房间信息.类型代码 = dbo.客房类型.类型代码  where  房间代码=" + mID + "");
                if (dt.Rows.Count > 0)
                {
                    txtFH.ReadOnly = true;
                    txtFH.Text = dt.Rows[0]["房号"].ToString();
                    txtLXDM.Text = dt.Rows[0]["类型名称"].ToString();
                    txtLC.Text = dt.Rows[0]["楼层"].ToString();
                    txtDJ.Text = dt.Rows[0]["单价"].ToString();
                    mPID = dt.Rows[0]["类型代码"].ToString();
                    txtFJDH.Text = dt.Rows[0]["房间电话"].ToString();
                    txtBZ.Text = dt.Rows[0]["房间备注"].ToString();
                    txtFWZT.Text = dt.Rows[0]["房屋状态"].ToString();
                    
                }
            }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}