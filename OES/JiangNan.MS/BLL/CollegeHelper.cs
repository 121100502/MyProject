using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;

namespace JiangNan.MS.BLL
{
    public class CollegeHelper
    {
        /// <summary>
        /// 高校实体
        /// </summary>
        /// <param name="collegeId"></param>
        /// <returns></returns>
        public static College Get(int collegeId)
        {
            return DB.Context.From<College>().Where(College._.Id == collegeId).ToFirst();
        }

        /// <summary>
        /// 高校名称
        /// </summary>
        /// <param name="collegeId"></param>
        /// <returns></returns>
        public static string GetCollegeName(string collegeId)
        {
            int _collegeId = int.MinValue;
            string collegeName = string.Empty;
            if (!string.IsNullOrEmpty(collegeId) && int.TryParse(collegeId, out _collegeId))
            {
                var entity = Get(_collegeId);
                collegeName = entity!=null?entity.CollegeName:"";
            }
            return collegeName;
        }

    }
}
