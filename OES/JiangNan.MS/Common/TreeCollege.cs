using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using Dos.ORM.Db;
using Newtonsoft.Json;
using System.Text;


namespace JiangNan.MS.Common
{
   public class TreeCollege
    {
       /// <summary>
       ///   Tree str
       /// </summary>
       /// <returns></returns>
       public static string GetTreeJson(int degreeFormId)
       {
           StringBuilder jsonStr = new StringBuilder();
           string str = "[";
           var collegeList = GetCollegeList(degreeFormId);
           List<Level> levelList= GetLevelList();
           if (collegeList != null && collegeList.Count > 0)
           {
               #region 高校
               int c = 0;
               foreach (var cLst in collegeList)
               {
                   c++;
                   str += "{";
                   str += "\"id\"" + ":" + cLst.Id + "," + "\"text\"" + ":" + "\"" + cLst.CollegeName + "\"" + ",";
                   str += "\"nodeId\"" + ":" + "\"" + cLst.Id + "/" + "\""+",";
                   str += "\"nodeName\"" + ":" + "\"" + cLst.CollegeName + "/" + "\"" + ",";
                   str+= "\"state\"" + ":" + "\"closed\"" + "," + "\"children\"" + ":" + "[";
                   
                   #region 层次
                   int b = 0;
                   foreach (var lList in levelList)
                   {
                       b++;
                       if (GetMajorList(cLst.Id, lList.Id.ToString(), degreeFormId).Count > 0)
                       {
                          
                           str +=  "{";
                           str += "\"id\"" + ":" +lList.Id+ ",";
                           str += "\"text\"" + ":" + "\"" + lList.LevelName + "\"" + ",";
                           str += "\"nodeId\"" + ":" + "\"" + cLst.Id + "/" + lList.Id + "\"" + ",";
                           str += "\"nodeName\"" + ":" + "\"" + cLst.CollegeName + "/" + lList.LevelName + "\"" + ",";
                           str += "\"state\"" + ":" + "\"closed\""+",";
                           str += "\"children\"" + ":" + "[";
                            var majorList = GetMajorList(cLst.Id, lList.Id.ToString(), degreeFormId);
                            if(majorList.Count>0)
                            {
                                int a = 0;
                                #region 专业
                                foreach (var majorLst in majorList)
                                {
                                    a++;
                                    str += "{";
                                    str += "\"id\"" + ":" + majorLst.Id + ",";
                                    str += "\"nodeId\"" + ":" + "\"" + cLst.Id + "/" + lList.Id +"/"+majorLst.Id+ "\"" + ",";
                                    str += "\"nodeName\"" + ":" + "\"" + cLst.CollegeName + "/" + lList.LevelName + "/" + majorLst.MajorName + "\"" + ",";
                                    str += "\"text\"" + ":" + "\""  + majorLst.MajorName + "\"";
                                    if (a%majorList.Count == 0)
                                    {
                                        str += "}" ;
                                    }
                                    else
                                    {
                                        str += "}" + ",";
                                    }
                                }
                                #endregion
                            }
                            str += "]";
                       }
                       else
                       {
                           continue;
                       }
                      if (b % levelList.Count== 0)
                      {
                          str += "}";
                      }
                      else
                      {
                         str += "},";
                      }
                   }
                   #endregion
                   if (c%collegeList.Count == 0)
                   {
                       str += "]}";
                   }
                   else
                   {
                       str += "]},";
                   }
               }
               #endregion
           }
           str += "]";
           return str;
           //return JsonConvert.SerializeObject(str);
       }

       /// <summary>
       /// 层次
       /// </summary>
       /// <returns></returns>
       private static List<Level> GetLevelList()
       {
           return new List<Level> {new Level {Id = 1, LevelName = "高起专"}, new Level {Id = 2, LevelName = "专升本"}}.ToList();
       }
       /// <summary>
       /// 高校
       /// </summary>
       /// <param name="degreeFormId"></param>
       /// <returns></returns>
       private static List<College> GetCollegeList(int degreeFormId)
       {
           int _degreeFormId = int.MinValue;
           var collegeList = new List<College>();
           if(!string.IsNullOrEmpty(degreeFormId.ToString())&&int.TryParse(degreeFormId.ToString(),out _degreeFormId))
           {
                  collegeList = DB.Context.From<College>()
                      // .Select(College._.Id, College._.CollegeName})
                       .Where(College._.DegreeFormID.Contain(_degreeFormId.ToString()))
                       .OrderBy(College._.Orders, College._.CollegeName)
                       .ToList();
           }
           return collegeList;
       }

       /// <summary>
       /// 专业
       /// </summary>
       /// <param name="collegeId"></param>
       /// <param name="levelId"></param>
       /// <returns></returns>
       private static List<CollegeMajor> GetMajorList(int collegeId, string levelId, int degreeFormId)
       {
           int _collegeId = int.MinValue;
           var majorList = new List<CollegeMajor>();
           if (!string.IsNullOrEmpty(collegeId.ToString()) && !string.IsNullOrEmpty(levelId.ToString())
               && int.TryParse(collegeId.ToString(), out _collegeId) )
           {
               majorList=DB.Context.From<CollegeMajor>()
                  // .Select(d=>new {d.Id,d.MajorName})
                   .Where(CollegeMajor._.CollageID == _collegeId && CollegeMajor._.Cenci == levelId && CollegeMajor._.DegreeFormId == degreeFormId)
                   .OrderBy(CollegeMajor._.ViewCount, CollegeMajor._.MajorName )
                   .ToList();
           }
           return majorList;
       }

    }
}
