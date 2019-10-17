using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace DAL
{
    /// <summary>
    /// DBbase 的摘要说明
    /// 创建人：王克思
    /// 创建时间：2019/10/16 星期三 19:01:25
    /// </summary>
    public class DBbase
    {
        //读取配置文件 连接数据库语句      
        public static string strCon = "server=127.0.0.1;port=3306;user=root;password=root; database=c#_data;";
        //实例化连接对象 con  
        MySqlConnection con = new MySqlConnection(strCon);

        //检测连接是否打开  
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }
        //执行语句，返回该语句查询的数据行的总行数  
        public int returnRowCount(string strSQL)
        {
            chkConnection();
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter daa = new MySqlDataAdapter(strSQL, con);//适配器
                daa.Fill(ds);//将查询到的数据填充到数据集里面
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }
    }
}
