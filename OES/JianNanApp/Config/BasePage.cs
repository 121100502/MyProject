using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JiangNan.MS.DataMap;
using JiangNan.MS.BLL;
using Dos.ORM.Db;

/// <summary>
/// BasePage 的摘要说明
/// </summary>
namespace JiangNan.Untility
{
    public class BasePage : System.Web.UI.Page
    {
        public User user;
        public BasePage()
        {

        }

        protected override void OnInit(EventArgs e)
        {
            string userName = CookieHelper.GetCookieValue("myCookie");
            if (!string.IsNullOrEmpty(userName))
            {
                user = UserTran.Get(userName);
                Response.Write(" <script> parent.window.location.href= '../login.aspx' </script> ");
            }
            base.OnInit(e);
        }
    }
}
