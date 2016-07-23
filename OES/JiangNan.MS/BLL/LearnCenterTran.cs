using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Dos.ORM;
using Dos.ORM.Db;
using System.Xml;
using JiangNan.MS.DataMap;
using JiangNan.Untility;

namespace JiangNan.MS.BLL
{  
    
    public class LearnCenterTran
    {
        private  const string XmlPath = @"config\LearnCenter.xml";
        /// <summary>
        /// 部门列表
        /// </summary>
        /// <returns></returns>
       public static List<LearnCenter> GetLearnCenter()
       {
           List<LearnCenter> centerList = new List<LearnCenter>();
           var xmlDoc = new XMLProcess(XmlPath);
           var nodeList = xmlDoc.ReadAllChild("item");
           if (nodeList != null && nodeList.Count > 0)
           {
               foreach (XmlNode node in nodeList)
               {
                   if (node.Attributes != null && (node.Attributes["id"] == null || node.Attributes["name"] == null))
                   {
                       continue;
                   }
                   centerList.Add(new LearnCenter(int.Parse(node.Attributes["id"].Value), node.Attributes["name"].Value));
               }
           }
           return centerList;
       }
        /// <summary>
        /// 获得学习中心
        /// </summary>
        /// <param name="learnCenterId"></param>
        /// <returns></returns>
        public static LearnCenter Get(string learnCenterId)
        {
            var learnCenterEntity = new LearnCenter();
            var xmlDoc = new XMLProcess(XmlPath);
            var nodeList = xmlDoc.ReadAllChild("item");
            int _learnCenterId = int.MinValue;
            if (!string.IsNullOrEmpty(learnCenterId) && int.TryParse(learnCenterId, out _learnCenterId))
            {
                if (nodeList != null && nodeList.Count > 0)
                {
                    foreach (XmlNode node in nodeList)
                    {
                        if (node.Attributes != null && (node.Attributes["id"] == null || node.Attributes["name"] == null))
                        {
                            continue;
                        }
                        if (int.Parse(node.Attributes["id"].Value) == _learnCenterId)
                        {
                            learnCenterEntity = new LearnCenter(int.Parse(node.Attributes["id"].Value),
                                node.Attributes["name"].Value);
                            continue;
                        }
                    }
                }
            }
            return learnCenterEntity;
        }


    }
}
