using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;

namespace JiangNan.MS.BLL
{
    public class DeptmentTran : DB
    {
        public static bool Add(Deptment deptment)
        {
            return DB.Context.Insert(deptment) > 0;
        }
        /// <summary>
        /// 获得实体
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        public static Deptment Get(int deptId)
        {
            int _deptId = int.MinValue;
            var deptmentEnity = new Deptment();
            if (!string.IsNullOrEmpty(deptId.ToString()) && int.TryParse(deptId.ToString(), out _deptId))
            {
                deptmentEnity = DB.Context.From<Deptment>().Where(Deptment._.Id == _deptId).ToFirst();
            }
            return deptmentEnity;
        }

        /// <summary>
        /// GetDeptmentList
        /// </summary>
        /// <returns></returns>
        public static List<Deptment> GetDeptmentList()
        {
            return DbSession.Default.From<Deptment>().ToList();
        }
    }

}
