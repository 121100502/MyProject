using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;

namespace JiangNan.MS.BLL
{
   public class majorHelper
    {
        /// <summary>
        /// 专业实体
        /// </summary>
        /// <param name="majorId"></param>
        /// <returns></returns>
        public static CollegeMajor Get(int majorId)
        {
            return DB.Context.From<CollegeMajor>().Where(CollegeMajor._.Id == majorId).ToFirst();
        }

        /// <summary>
        /// 专业名称
        /// </summary>
        /// <param name="collegeId"></param>
        /// <returns></returns>
        public static string GetMajorName(string majorId)
        {
            int _majorId = int.MinValue;
            string majorName = string.Empty;
            if (!string.IsNullOrEmpty(majorId) && int.TryParse(majorId, out _majorId))
            {
                var entity = Get(_majorId);
                majorName = entity!=null?entity.MajorName:"";
            }
            return majorName;
        }
    }
}
