using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class TF : Form
    {
        public TF()
        {
            InitializeComponent();
        }
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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            db.Exec("update 	房间入住 set 退房日期='" + datJSRQ.Value.ToShortDateString() + "',房款=" + txtZFK.Text + " where 入住代码=" + mID + "");
            db.Exec("update 房间信息 set 房屋状态='空闲' where 房间代码=(select 房间代码 from 房间入住 where 入住代码=" + mID+ " )");
            MessageBox.Show("退房完成");
            this.Close();
        }

        private void ZhbxEdit_Load(object sender, EventArgs e)
        {
            if (mID != "")
            {
 
                DataTable dt;
                dt = db.Get("SELECT 房间入住.*, 房间信息.* FROM 房间入住 INNER JOIN 房间信息 ON 房间入住.房间代码 = 房间信息.房间代码 where 入住代码=" + mID + "");
                if (dt.Rows.Count > 0)
                {
                    this.txtKFRQ.Text = dt.Rows[0]["入住日期"].ToString();
                    this.txtYZTS.Text= dt.Rows[0]["预入住天数"].ToString();
                    this.txtFWJG.Text = dt.Rows[0]["单价"].ToString();

                }
            }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datJSRQ_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan   ts   =   datJSRQ.Value  -    Convert.ToDateTime(this.txtKFRQ.Text);
            this.txtSJTS.Text = ts.Days.ToString();
            this.txtZFK.Text = Convert.ToString(ts.Days * Convert.ToDouble(this.txtFWJG.Text));
        }
    }
}