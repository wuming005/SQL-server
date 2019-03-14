using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理
{
    public partial class frmSelectInfo : Form
    {
        public frmSelectInfo()
        {
            InitializeComponent();
        }
        //公用查询列表窗体属性
        private string mTableName = "";
        private string mFlag = "";
        private Form mCurForm;

        public string TableName
        {
            get
            {
                return mTableName;
            }
            set
            {
                mTableName = value.Trim();
            }

        }


        public string Flag
        {
            get
            {
                return mFlag;
            }
            set
            {
                mFlag = value.Trim();
            }

        }

        public Form CurForm
        {
            get
            {
                return mCurForm;
            }
            set
            {
                mCurForm = value;
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            //根据不同的标志 将选择的内容返回到指定的窗体上
            if (this.dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }
            switch (mFlag)
            {
                case "FrmFjEdit.txtLXDM":
                    //调用窗体
                    ((FrmFjEdit)mCurForm).PID = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    break;
                case "frmFJYDEdit.txtFJXX":
                    //调用窗体
                    ((frmFJYDEdit)mCurForm).txtFJXX.Text = "房号：" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\r\n楼层：" + this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\r\n单价：" + this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "\r\n房型：" + this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    ((frmFJYDEdit)mCurForm).txtFJXX.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    break;
                case "frmFJYDEdit.txtKHXX":
                    //调用窗体txtKHXX
                    ((frmFJYDEdit)mCurForm).txtKHXX.Text = "姓名：" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\r\n性别：" + this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\r\n证件类型：" + this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "\r\n证件号码：" + this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    ((frmFJYDEdit)mCurForm).txtKHXX.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    break;
                case "frmKFRZEDit.txtFJXX":
                    //调用窗体
                    ((frmKFRZEDit)mCurForm).txtFJXX.Text = "房号：" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\r\n楼层：" + this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\r\n单价：" + this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "\r\n房型：" + this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    ((frmKFRZEDit)mCurForm).txtFJXX.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    break;
                case "frmKFRZEDit.txtKHXX":
                    //调用窗体txtKHXX
                    ((frmKFRZEDit)mCurForm).txtKHXX.Text = "姓名：" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\r\n性别：" + this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "\r\n证件类型：" + this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "\r\n证件号码：" + this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    ((frmKFRZEDit)mCurForm).txtKHXX.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    break;
                case "frmKFRZEDit.txtYDXX":
                    //调用窗体txtKHXX
                    ((frmKFRZEDit)mCurForm).txtYDXX.Text = "开始日期：" + this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "\r\n截止日期：" + this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString() ;
                    ((frmKFRZEDit)mCurForm).txtYDXX.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    ((frmKFRZEDit)mCurForm).txtYJTS.Text = this.dataGridView1.SelectedRows[0].Cells[this.dataGridView1.ColumnCount-1].Value.ToString();
                    break; 
               
            }
            Close();
        }

        private void SelectInfo_Load(object sender, EventArgs e)
        {
            //根据传递的不同表格 显示数据库中各个记录的内容
            switch (mTableName)
            {
                case "客房类型":
                    this.dataGridView1.DataSource = db.Get("select 类型代码,类型名称  from 客房类型");
                    this.dataGridView1.Columns[1].Width = dataGridView1.Width - 100;
                    break;
                case "房间信息":
                    this.dataGridView1.DataSource = db.Get("SELECT 房间信息.房间代码, 房间信息.房号, 房间信息.楼层,       房间信息.单价, 房间信息.房间电话, 房间信息.房间备注,       房间信息.房屋状态, 客房类型.类型名称 FROM 房间信息 INNER JOIN       客房类型 ON 房间信息.类型代码 = 客房类型.类型代码 where 房屋状态='空闲' ");
                    this.dataGridView1.Columns[0].Visible = false;
                    break;
                case "客户信息":
                    this.dataGridView1.DataSource = db.Get("SELECT 客户代码, 姓名, 性别, 随行人数, 证件类型, 证件号码, 民族, 籍贯, 地址, 电话, 备注 FROM dbo.客户 ");
                    this.dataGridView1.Columns[0].Visible = false;
                    break;
                case "预定信息":
                    this.dataGridView1.DataSource = db.Get("SELECT 房间预定.预定代码, 客户.姓名, 客户.性别, 客户.证件号码, 客户.证件类型, 客户.电话, 房间预定.开始日期, 房间预定.截至日期, 房间信息.房号,房间信息.楼层, 房间信息.单价, 房间信息.房间电话, 客房类型.类型名称,(DATEDIFF   (   d   ,   开始日期   ,   截至日期   )) as 差值 FROM 房间预定 INNER JOIN 房间信息 ON 房间预定.房间代码 = 房间信息.房间代码 INNER JOIN 客户 ON 房间预定.客户代码 = 客户.客户代码 INNER JOIN 客房类型 ON 房间信息.类型代码 = 客房类型.类型代码 where 预定代码 not in ( select 预定代码 from 房间入住)");
                    this.dataGridView1.Columns[0].Visible = false;
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}