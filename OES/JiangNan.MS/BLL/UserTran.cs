using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JiangNan.MS.DataMap;
using JiangNan.Untility;
using Dos.ORM;
using Dos.ORM.Db;
using JiangNan.Untility;


namespace JiangNan.MS.BLL
{
    
   public class UserTran
    {
       /// <summary>
       /// 新增
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       public static int Add(User user)
       {
           int flag = int.MinValue;
           User userEntity = Get(user.UserName);
          //是否有重复用户名
           if (userEntity != null)
           {
               flag = 0;
           }
           else
           {
               flag = DB.Context.Insert(user);
           }
           return flag;
       }

       /// <summary>
       /// 是否存在此用户
       /// </summary>
       /// <param name="userName"></param>
       /// <returns></returns>
       public static bool IsExit(string userName)
       {
           return DB.Context.Exists<User>(User._.UserName == userName);
       }

       /// <summary>
       /// 获得实体
       /// </summary>
       /// <param name="userId"></param>
       /// <returns></returns>
       public static User Get(int userId)
       {
           return DB.Context.From<User>().Where(User._.Id == userId).ToFirstDefault();
       }

       /// <summary>
       /// 获得实体
       /// </summary>
       /// <param name="userId"></param>
       /// <returns></returns>
       public static User Get(string userName)
       {
           return DB.Context.From<User>().Where(User._.UserName == userName).ToFirst();
       }

       /// <summary>
       /// 获得实体
       /// </summary>
       /// <param name="userName"></param>
       /// <param name="pwd"></param>
       /// <returns></returns>
       private static User Get(string userName, string pwd)
       {
           return DB.Context.From<User>().Where(User._.UserName == userName && User._.UserPwd == pwd && User._.UserStatus==1).ToFirst();
       }

       /// <summary>
       /// 登陆 0用户不存，1登陆成功，2密码错误
       /// </summary>
       /// <param name="userName"></param>
       /// <param name="pwd"></param>
       /// <returns></returns>
       public static int Login(string userName, string pwd)
       {
           int loginFlag = 0;
           User entity = Get(userName);
           if (entity != null)
           {
               entity = Get(userName, Tools.GetMD5(pwd));
               loginFlag = entity != null ? 1 : 2;
           }
           return loginFlag;
       }

       /// <summary>
       /// 所有用户
       /// </summary>
       /// <returns></returns>
       public static List<User> GetUserList()
       {
           return DB.Context.From<User>().ToList();
       }

       /// <summary>
       /// 修改
       /// </summary>
       /// <param name="user"></param>
       /// <returns></returns>
       public static bool Mofiy(User user)
       {
          // DB.Context.Update<User>()
           return true;
       }

       /// <summary>
       /// User Json
       /// </summary>
       /// <returns></returns>
       public static List<TmpUser> GetAllUser(int pageSize,int currentPage)
       {
           var tmpLst = DB.Context.From<User>().Where(User._.Id>0)
               .OrderBy(User._.CreateDate).OrderByDescending()
                .Page(pageSize, currentPage)
                .ToList();
           List<TmpUser> tmpCustomerLst = new List<TmpUser>();
           if (tmpLst.Count > 0)
           {
               tmpCustomerLst.AddRange(tmpLst.Select(d => new TmpUser
               {
                   Id = d.Id,
                   UserName = d.UserName,
                   UserTrueName = d.UserTrueName,
                   UserPwd=d.UserPwd,
                   DeptName = DeptmentTran.Get(int.Parse(d.DeptmentId.ToString())).DeptmentName,
                   LearnCenterName = LearnCenterTran.Get(d.LearnCenterId.ToString()).CenterName,
                   UserStatus = d.UserStatus==true?"有效":"无效",
                   CreateDate = Convert.ToDateTime(d.CreateDate).ToString("yyyy-MM-dd")
               }));
           }
           return tmpCustomerLst;
       }

       /// <summary>
       ///批量 删除
       /// </summary>
       /// <param name="idLst"></param>
       /// <returns></returns>
       public static bool Del(List<int> idLst)
       {
           bool isDel = false;
           if (idLst != null && idLst.Count > 0)
           {
               isDel = DB.Context.Delete<User>(User._.Id.In(idLst)) > 0;
           }
           return isDel;
       }

    }

    /// <summary>
    /// TmpUser
    /// </summary>
    public class TmpUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserTrueName { get; set; }
        public string UserPwd { get; set; }
        public string Email { get; set; }
        public string DeptName { get; set; }
        public string LearnCenterName { get; set; }
        public string UserStatus { get; set; }
        public string CreateDate { get; set; }
    }

}
