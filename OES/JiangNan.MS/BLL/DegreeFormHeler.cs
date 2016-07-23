using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;

namespace JiangNan.MS.BLL
{
   public class DegreeFormHeler
    {
        /// <summary>
        /// GetDegreeFormList
        /// </summary>
        /// <returns></returns>
        public static List<DegreeForm> GetDegreeFormList()
        {
            var degreeLst = new List<int>{1,2,3,6};
            return DB.Context.From<DegreeForm>().Where(c => c.Id.In(degreeLst)).ToList();
        }

        /// <summary>
        /// GetDegreeFormDic
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetDegreeFormDic()
        {
            var dic = new Dictionary<int, string>();
            var itemList = GetDegreeFormList();
            if (itemList.Count > 0)
            {
                foreach (var configItem in itemList)
                {
                    if (dic.Keys.Contains(configItem.Id))
                    {
                        continue;
                    }
                    dic.Add(configItem.Id, configItem.DegreeFormName);
                }
            }
            return dic;
        }

       /// <summary>
        /// Get
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static DegreeForm Get(int id)
       {
           return DB.Context.From<DegreeForm>().Where(DegreeForm._.Id == id).ToFirst();
       }
      
       /// <summary>
       /// 咨询类型名称
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static string GetDreeFormName(string id)
       {
           int _id = int.MinValue;
           string dreeFormName = string.Empty;
           if (!string.IsNullOrEmpty(id) && int.TryParse(id, out _id))
           {
               var entity = Get(_id);
               dreeFormName = entity != null ? entity.DegreeFormName : "";
           }
           return dreeFormName;
       }

    }
}
