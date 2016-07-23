using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.CRM.DataMap;
using JiangNan.Untility;
using Dos.ORM;
using Dos.ORM.Db;

namespace JiangNan.CRM.BLL
{
    public class ConsultantTran
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="consultant"></param>
        /// <returns></returns>
        public static bool Add(ConsultantInfo consultant)
        {
            return DB.AddEntity(consultant);
        }
     
    }
}
