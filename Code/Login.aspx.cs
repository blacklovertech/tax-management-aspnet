using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = Request.Url.ToString();
        string[] split = url.Split('/');
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i] == "Admin")
            {
                lblLogin.Text = "Admin Login";
                linkShow.Visible = false;
            }
            else if (split[i] == "Users")
            {
                lblLogin.Text = "Users Login";
                linkShow.Visible = true;
            }
           
            if (Session["AdminId"] != null)
            {
                FormsAuthentication.SignOut();
            }

            else if (Session["UserId"] != null)
            {
                FormsAuthentication.SignOut();
            }


        }

    }
    clsLogin objLogin = new clsLogin();
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        string str1 = null;
        string[] LoginName = null;
        try
        {
            if (txtUsername.Text.Contains("@"))
            {
                string str = txtUsername.Text;
                LoginName = str.Split('@');
                clsLogin.LoginName = LoginName[0].ToString();
                str1 = LoginName[0].ToString();
            }
            else
            {
                clsLogin.LoginName = txtUsername.Text.Trim();
                str1 = txtUsername.Text.Trim();
            }
            clsLogin.Password = txtPassword.Text.Trim();
            string houseno,name;
            string Role = objLogin.GetUserLogin(out houseno,out name);

            if (Role == "NoUser")
                lblMsg.Text = "User Name and password mismatch. Try again.";
            else
            {
                if (Role.ToUpper() == "ADMIN")
                {
                    Session["AdminId"] = houseno;
                   
                    Session["UserType"] = "Admin";
                    FormsAuthentication.RedirectFromLoginPage("Admin", false);
                }
                else if (Role.ToUpper() == "USERS")
                {
                    Session["UserId"] = houseno;
                    Session["UserType"] = "Users";
                    Session["UserName"] = name;
                    FormsAuthentication.RedirectFromLoginPage("Users", false);
                }
               
                else
                    lblMsg.Text = "Login Failed for this User";
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
               
    }
}
