using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;
using System.Data;

namespace JiangNan.MS.BLL
{
   public class SecondLevelHelper
    {
       /// <summary>
       /// Add
       /// </summary>
       /// <param name="slConfig"></param>
       /// <returns></returns>
       public static bool Add(SecondLevelConfig slConfig)
       {
           return DB.Context.Insert(slConfig) > 0;
       }

       /// <summary>
       /// 列表
       /// </summary>
       /// <returns></returns>
       public static List<SecondLevelConfig> GetSlConfig()
       {
           return DB.Context.From<SecondLevelConfig>().ToList();
       }

       /// <summary>
       /// 实体
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static SecondLevelConfig GetEnitty(int id)
       {
           return DB.Context.From<SecondLevelConfig>()
               .Where(SecondLevelConfig._.Id  == id).ToFirstDefault();
       }

       /// <summary>
       /// 新增二级配置
       /// </summary>
       /// <param name="slEntity"></param>
       /// <returns></returns>
       public static bool AddConfigItem(SecondLevelConfigItem slEntity)
       {
           return DB.Context.Insert(slEntity) > 0;
       }

       /// <summary>
       /// 二级配置实体
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static SecondLevelConfigItem GetLevelItem(int id)
       {
           return DB.Context.From<SecondLevelConfigItem>()
               .Where(SecondLevelConfigItem._.Id == id).ToFirstDefault();
       }

       /// <summary>
       /// ConfigItem List
       /// </summary>
       /// <param name="slConfigid"></param>
       /// <returns></returns>
       public static List<SecondLevelConfigItem> GetConfigItemList(int slConfigid)
       {
           return DB.Context.From<SecondLevelConfigItem>().Where(SecondLevelConfigItem._.SecondLevelId == slConfigid).ToList();
       }

       public static DataTable GetConfigItem(int slConfigid)
       {
           return
               DB.Context.From<SecondLevelConfigItem>()
                   .Where(SecondLevelConfigItem._.SecondLevelId == slConfigid)
                   .ToDataTable();
       }

       /// <summary>
       ///  CofigItem Dic
       /// </summary>
       /// <param name="slConfigId"></param>
       /// <returns></returns>
       public static Dictionary<int, string> GetConfigItemDic(int slConfigId)
       {
           var dic = new Dictionary<int, string>();
           int _slConfigId = int.MinValue;
           if (!string.IsNullOrEmpty(slConfigId.ToString()) && int.TryParse(slConfigId.ToString(), out _slConfigId))
           {
               var itemList = GetConfigItemList(slConfigId);
               if (itemList.Count > 0)
               {
                   foreach (var configItem in itemList)
                   {
                       if (dic.Keys.Contains(configItem.Id))
                       {
                           continue;
                       }
                       dic.Add(configItem.Id, configItem.ItemName);
                   }
               }

           }
           return dic;
       }

    }

   
}
