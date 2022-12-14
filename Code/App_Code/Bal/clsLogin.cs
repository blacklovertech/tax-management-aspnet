using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Geospatial;
/// <summary>
/// Summary description for clsLogin
/// </summary>
public class clsLogin
{

    public clsLogin()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static string LoginName { get; set; }
    public static string Password { get; set; }
    public static string Role { get; set; }
    public static int Houseno { get; set; }
    DataSet ds = null;

    public string GetUserLogin( out string houseno,out string name)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];

            p[0] = new SqlParameter("@LoginName", LoginName);
            p[1] = new SqlParameter("@Password", Password);
            p[2] = new SqlParameter("@Role", SqlDbType.VarChar, 50);
            p[2].Direction = ParameterDirection.Output;
            p[3] = new SqlParameter("@Houseno", SqlDbType.VarChar,50);
            p[3].Direction = ParameterDirection.Output;
            p[4] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p[4].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "spLoginChecking", p);
            Role = Convert.ToString(p[2].Value);
            if (Role != "NoUser")
            {
                houseno = p[3].Value.ToString();
                name = p[4].Value.ToString();
            }
            else
            {
                houseno = "";
                name = "";
            }
            return Role;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
    
    public static  void LoginCheck()
    {
        clsLogin.LoginName = ConfigurationManager.AppSettings["UserName"];
        clsLogin.Password = ConfigurationManager.AppSettings["PassWord"];
    }
    public static string HousenoChecking()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@HouseNo", Houseno);
        p[1] = new SqlParameter("@Msg", SqlDbType.VarChar, 50);
        p[1].Direction = ParameterDirection.Output;
        SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_HouseNoLogincheck", p);
        return Convert.ToString( p[1].Value);
        
    }

}
