using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JiangNan.MS.DataMap;
using JiangNan.MS.BLL;
using Dos.ORM.Db;
using JiangNan.Untility;

namespace JiangNan.MS.Common
{
   
    public class BasePage: System.Web.UI.Page
    {
        public string UserCookie = string.Empty;
        public User user = new User();
        
        public BasePage()
        {

        }

        protected override void OnInit(EventArgs e)
        {
            UserCookie =CookieHelper.GetCookieValue("myCookie");
            if (!string.IsNullOrEmpty(UserCookie))
            {
                user = UserTran.Get(UserCookie);
                if (user == null)
                {
                    Response.Write(" <script> parent.window.location.href= '../login.aspx' </script> ");
                }
            }
            else
            {
                Response.Write(" <script> parent.window.location.href= '../login.aspx' </script> ");
            }
            base.OnInit(e);
        }
    }
}
