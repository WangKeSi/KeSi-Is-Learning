using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL
{
    /// <summary>
    /// userBLL 的摘要说明
    /// 创建人：王克思
    /// 创建时间：2019/10/16 星期三 18:49:53
    /// </summary>
    public class userBLL
    {
        DAL.userDAL d_userAccess = new DAL.userDAL();
        public int userLogin(Model.userInfo m_userInfo)//把model层的值传过来进行比对
        {
            return d_userAccess.userLogin(m_userInfo.username, m_userInfo.password);//如果有返回值则登录成功
        }
    }
}
