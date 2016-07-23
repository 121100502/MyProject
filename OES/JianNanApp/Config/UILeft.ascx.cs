using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JiangNan.MS.BLL;
using JiangNan.MS.DataMap;
using JiangNan.Untility;

namespace JianNanApp.Config
{
    public partial class UILeft : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string userCookie = CookieHelper.GetCookieValue("myCookie");
                if (!string.IsNullOrEmpty(userCookie))
                {
                    var user = UserTran.Get(userCookie);
                    if (user != null)
                    {
                        litDeptName.Text = DeptmentTran.Get(int.Parse(user.DeptmentId.ToString())).DeptmentName;
                        litUserTrueName.Text = user.UserTrueName;
                    }
                    else
                    {
                        Response.Write(" <script> parent.window.location.href= '../login.aspx' </script> ");
                    }
                }
                else
                {
                    Response.Write(" <script> parent.window.location.href= '../login.aspx' </script> ");
                }

            }
        }
        protected void lbtnQuit_Click(object sender, EventArgs e)
        {
            CookieHelper.ClearCookie("myCookie");
            MessageBox.ShowAndRedirect(this.Page, "退出成功", "/login.aspx");
        }
    }
}