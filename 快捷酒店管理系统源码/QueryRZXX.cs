using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class QueryRZXX : Form
    {
        public QueryRZXX()
        {
            InitializeComponent();
        }

        private void initDg()
        {
            //查询显示员工列表
            this.dataGridView1.DataSource = db.Get("SELECT  房间入住.入住代码,预定代码,  房间信息.房号,  客房类型.类型名称,房间信息.楼层,  房间信息.单价,  房间入住.入住日期,  客户.姓名, 客户.性别,  客户.证件类型,  客户.证件号码,  房间入住.预入住天数, 房间入住.退房日期,  房间入住.房款,  房间入住.经办人 FROM  房间信息 INNER JOIN 客房类型 ON  房间信息.类型代码 =  客房类型.类型代码 INNER JOIN 房间入住 ON  房间信息.房间代码 =  房间入住.房间代码 INNER JOIN 客户 ON 房间入住.客户代码 = 客户.客户代码 where 入住日期 between '" + dateTimePicker1.Value.ToShortDateString() + "' and '" + dateTimePicker2.Value.ToShortDateString() + "' ");
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            initDg();
        }
    }
}