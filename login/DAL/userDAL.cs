using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// userDAL 的摘要说明
    /// 创建人：王克思
    /// 创建时间：2019/10/16 星期三 18:59:08
    /// </summary>
    public class userDAL
    {
        //实例化DBbase 对象  
        DBbase db = new DBbase();

        //用户登录的方法  
        public int userLogin(string name, string psw)
        {
            string strsql = "select * from users where username = '" + name + "' and password = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
    }
}
