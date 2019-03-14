using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Database 的摘要说明


/// </summary>
public class db
{
    public static string strID = "000004";//帐号
    public db()
    {
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static SqlConnection createConnection()
    {
        //从webconfig中取得字符串连接方式
        SqlConnection cnn = new SqlConnection(@"Data Source=KKK\WMM;Initial Catalog=CJDKF;Integrated Security=True");
        return cnn;
    }
    public static DataTable Get(string SetStr)
    {
        //定义数据库连接 查询并填充DataSet

        SqlConnection tmpCnn = db.createConnection();
        if (tmpCnn.State != 0)
        {
            tmpCnn.Close();
        }
        tmpCnn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter(SetStr, tmpCnn);
        DataSet tmpDataSet = new DataSet();
        cmd.Fill(tmpDataSet);
        tmpCnn.Close();
        return tmpDataSet.Tables[0];
    }
    // 下载于www.51aspx.com
    public static void Exec(string sqlStr)
    {
        //定义数据库连接　　执行数据库的增加　修改和删除数据的功能
        SqlConnection tmpCnn = db.createConnection();
        if (tmpCnn.State != 0)
        {
            tmpCnn.Close();
        }
        tmpCnn.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = sqlStr;
        cmd.Connection = tmpCnn;
        cmd.ExecuteNonQuery();
        tmpCnn.Close();
    }
}