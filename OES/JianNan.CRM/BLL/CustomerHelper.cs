using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.CRM.DataMap;
using Dos.ORM.Db;    
using System.Data;
using Dos.ORM;
using JiangNan.MS.DataMap;
using JiangNan.MS.BLL;
using JiangNan.Untility;


namespace JiangNan.CRM.BLL
{
   
    public class CustomerHelper
    {
       
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static bool Add(Customer customer)
        {
            return DB.Context.Insert(customer) > 0;
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
                //return DB.Context.Delete<Customer>(d=>d.Id.In(idLst)) >0;
                isDel= DB.Context.Delete<Customer>(Customer._.Id.In(idLst)) > 0;
            }
            return isDel;
        }

        /// <summary>
        /// 实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer Get(int? id)
        {
            return DB.Context.From<Customer>().Where(Customer._.Id == id).ToFirst();
        }

        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetList(int rows, int page)
        {
            //Skip跳过多少条，之后Take取出多少条结果
            return DB.Context.From<Customer>().ToList().Skip(rows*(page - 1)).Take(rows).ToList();
        }

        /// <summary>
        /// GetList
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetList()
        {
            return DB.Context.From<Customer>().ToList();
          
        }

        /// <summary>
        /// Customer 格式化
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static List<TmpCustomer> GetCustomerLst(string userName, int currentPage, int pageSize)
        {
            var tmpLst = DB.Context.From<Customer>().Where(Customer._.BelongUser == userName && Customer._.CallBackStatus.NotIn(5))
                .OrderBy(Customer._.CreateDate.Desc)
                .Page(pageSize, currentPage)
                .ToList();
           
            List<TmpCustomer> tmpCustomerLst = new List<TmpCustomer>();
            if (tmpLst.Count > 0)
            {
                tmpCustomerLst.AddRange(tmpLst.Select(d => new TmpCustomer
                {
                    Id = d.Id,
                    CustomerName = d.CustomerName,
                    Sex = d.Sex == "male" ? "男" : "女",
                    CellPhone = d.CellPhone,
                    QQ = d.QQ,
                    BelongType = DegreeFormHeler.GetDreeFormName(d.ConsultantDegreeType.ToString()),
                    CollegeNo = CollegeHelper.GetCollegeName(d.CollegeNo.ToString()),
                    LevelNo = d.LevelNo == 1 ? "高起专" : "专升本",
                    MajorNo = majorHelper.GetMajorName(d.MajorNo.ToString()),
                    ConsultantDetail = d.ConsultantDetail,
                    ConsultantDate = Convert.ToDateTime(d.ConsultantDate).ToString("yyyy-MM-dd"),
                    CallBackStatus = CallBackStatusHelper.GetStatusName(d.CallBackStatus.ToString()),
                    CustomeStatus = d.CustomeStatus == true ? "有效" : "无效",
                    MediaSource = SecondLevelHelper.GetLevelItem(d.MediaSource.ConvertTo<int>()).ItemName,
                    IsExpress = d.IsExpress == true ? "1" : "0"
                }));
            }
            return tmpCustomerLst;
        }

        /// <summary>
        /// GetCustomerLst
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static List<TmpCustomer> GetCustomerLst(SearchTmp entity)
        {
            var where = new Where<Customer>();
            where.And(Customer._.BelongUser == entity.UserName);
            if (entity.MediaSource.Count > 0)
            {
                where.And(Customer._.MediaSource.In(entity.MediaSource));
            }
            if (entity.CallBackStatus.Count > 0)
            {
                where.And(Customer._.CallBackStatus.In(entity.CallBackStatus));
            }
            where.And(Customer._.ConsultantDate >=Convert.ToDateTime(entity.ConsultantDate[0]) );
            where.And( Customer._.ConsultantDate <= Convert.ToDateTime(entity.ConsultantDate[1]));
            var tmpLst = DB.Context.From<Customer>()
                .Where(where)
                .OrderBy(Customer._.ConsultantDate.Desc)
                .Page(entity.PageSize, entity.CurrentPage)
                .ToList();
          
            List<TmpCustomer> tmpCustomerLst = new List<TmpCustomer>();          
            if (tmpLst.Count > 0)
            {
                tmpCustomerLst.AddRange(tmpLst.Select(d => new TmpCustomer
                {
                    Id = d.Id,
                    CustomerName = d.CustomerName,
                    Sex = d.Sex == "male" ? "男" : "女",
                    CellPhone = d.CellPhone,
                    QQ = d.QQ,
                    BelongType = DegreeFormHeler.GetDreeFormName(d.ConsultantDegreeType.ToString()),
                    CollegeNo = CollegeHelper.GetCollegeName(d.CollegeNo.ToString()),
                    LevelNo = d.LevelNo == 1 ? "高起专" : "专升本",
                    MajorNo = majorHelper.GetMajorName(d.MajorNo.ToString()),
                    ConsultantDetail = d.ConsultantDetail,
                    ConsultantDate = Convert.ToDateTime(d.ConsultantDate).ToString("yyyy-MM-dd"),
                    CallBackStatus = CallBackStatusHelper.GetStatusName(d.CallBackStatus.ToString()),
                    CustomeStatus = d.CustomeStatus == true ? "有效" : "无效",
                    MediaSource = SecondLevelHelper.GetLevelItem(d.MediaSource.ConvertTo<int>()).ItemName,
                    IsExpress = d.IsExpress == true ? "1" : "0"
                }));
            }
            return tmpCustomerLst;
        }

        /// <summary>
        /// 数量
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int GetCustomerCount(SearchTmp entity)
        {
            var where = new Where<Customer>();
            where.And(Customer._.BelongUser == entity.UserName);
            if (entity.MediaSource.Count > 0)
            {
                where.And(Customer._.MediaSource.In(entity.MediaSource));
            }
            if (entity.CallBackStatus.Count > 0)
            {
                where.And(Customer._.CallBackStatus.In(entity.CallBackStatus));
            }
            where.And(Customer._.ConsultantDate >=Convert.ToDateTime(entity.ConsultantDate[0]) );
            where.And( Customer._.ConsultantDate <= Convert.ToDateTime(entity.ConsultantDate[1]));
            return DB.Context.From<Customer>().Where(where).ToList().Count;
        }

        /// <summary>
        /// 获得某个用户下的客户总数
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static int GetCustomerCount(string userName)
        {
            return DB.Context.From<Customer>().Where(Customer._.BelongUser == userName).ToList().Count;
        }

        /// <summary>
        /// 统计用户招生数据
        /// </summary>
        /// <param name="procName">参数过程名称</param>
        /// <param name="userName">用户名</param>
        /// <param name="beginDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns></returns>
        public static DataTable GetCharDatebyProc(string procName,string userName,string beginDate,string endDate )
        {
            return DB.Context.FromProc(procName)
            .AddInParameter("userName", DbType.String, userName)
            .AddInParameter("beginDate", DbType.DateTime, beginDate)
            .AddInParameter("endDate", DbType.DateTime, endDate)
            .ToDataTable();
        }

    }

    /// <summary>
    /// customer json用
    /// </summary>
    public class TmpCustomer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Sex { get; set; }
        public string Tel { get; set; }
        public string CellPhone { get; set; }
        public string QQ { get; set; }
        public string WeChat { get; set; }
        public string BelongType { get; set; }
        public string CollegeNo { get; set; }
        public string LevelNo { get; set; }
        public string MajorNo { get; set; }
        public string ConsultantDetail { get; set; }
        public string ConsultantDate { get; set; }
        public string CallBackStatus { get; set; }
        public string CustomeStatus { get; set; }
        public string MediaSource { get; set; }
        public string IsExpress { get; set; }
    }

    /// <summary>
    /// 查询
    /// </summary>
    public class SearchTmp
    {
        public string UserName { get; set; }
        public string[] ConsultantDate { get; set; }
        public List<int> MediaSource = new List<int>();
        public List<int> CallBackStatus = new List<int>();
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        //public List<int> MediaSource { }


    }


}
