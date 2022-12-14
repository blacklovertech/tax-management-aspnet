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
/// Summary description for Cls_RoleMaster
/// </summary>
public class Cls_RoleMaster
{

    private int roleId;
    private string roleName;
    private string roleAbbr;
    private string roleDescription;

    // constructor
    public Cls_RoleMaster()
    {
    }
    public int InsertRoleMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0]=new SqlParameter("@RoleName",RoleName);
            p[1]=new SqlParameter("@RoleAbbr",RoleAbbr);
            p[2] = new SqlParameter("@RoleDescription", RoleDescription);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_RoleMaster_Insert",p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int RoleId { get { return roleId; } set { roleId = value; } }
    public string RoleName { get { return roleName; } set { roleName = value; } }
    public string RoleAbbr { get { return roleAbbr; } set { roleAbbr = value; } }
    public string RoleDescription { get { return roleDescription; } set { roleDescription = value; } }
}
