using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;

namespace JiangNan.MS.BLL
{
    public class LoginHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static bool Add(LoginLog log)
        {
            return DB.Context.Insert(log) > 0;
        }
        
        /// <summary>
        /// GetloginLogList
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static List<LoginLog> GetloginLogList(string userName)
        {
            List<LoginLog> listLog;
            if (!string.IsNullOrEmpty(userName))
            {
                listLog = DB.Context.From<LoginLog>().Where(LoginLog._.UserName == userName).ToList();
            }
            else
            {
                listLog = DB.Context.From<LoginLog>().ToList();
            }
            return listLog;
        }

    }
}
