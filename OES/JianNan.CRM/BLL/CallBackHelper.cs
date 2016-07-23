using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.CRM.DataMap;
using Dos.ORM.Db;
using System.Data;
using JiangNan.MS.DataMap;
using JiangNan.MS.BLL;

namespace JiangNan.CRM.BLL
{
    public class CallBackHelper
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static bool Add(CallBackLog log)
        {
            return DB.Context.Insert(log) > 0;
        }

        /// <summary>
        /// Customer 格式化
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static List<CallBackLog> GetList( int customerId,int currentPage, int pageSize)
        {
            var tmpLst = DB.Context.From<CallBackLog>().Where(CallBackLog._.CustomerId == customerId)
                .OrderBy(CallBackLog._.CreateDate.Desc)
                .Page(pageSize, currentPage)
                .ToList();
            return tmpLst;
        }

        public static int GetCount(int customerId)
        {
            return DB.Context.From<CallBackLog>().Where(CallBackLog._.CustomerId == customerId).ToList().Count;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="idLst"></param>
        /// <returns></returns>
        public static bool Del(List<int> idLst)
        {
            bool isDel = false;
            if (idLst != null && idLst.Count > 0)
            {
                isDel = DB.Context.Delete<CallBackLog>(CallBackLog._.Id.In(idLst)) > 0;
            }
            return isDel;
        }
    }
}
