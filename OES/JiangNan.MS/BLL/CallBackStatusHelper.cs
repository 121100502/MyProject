using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM.Db;
using JiangNan.MS.DataMap;
using System.Data;

namespace JiangNan.MS.BLL
{
    public class CallBackStatusHelper
    {
        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static CallBackStatus Get(int id)
        {
            return DB.Context.From<CallBackStatus>().Where(CallBackStatus._.Id == id).ToFirst();
        }

        /// <summary>
        /// List<CallBackStatus>
        /// </summary>
        /// <returns></returns>
        public static List<CallBackStatus> Get()
        {
            return DB.Context.From<CallBackStatus>().ToList();
        }

        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDataTable()
        {
            return DB.Context.From<CallBackStatus>().ToDataTable();
        }

        /// <summary>
        /// 回访状态名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetStatusName(string id)
        {
            string statusName = string.Empty;
            int _id = int.MinValue;
            if (!string.IsNullOrEmpty(id) && int.TryParse(id, out _id))
            {
                var entity = Get(_id);
                statusName = entity != null ? entity.StatusName : "";
            }
            return statusName;
        }

        
    }
}
