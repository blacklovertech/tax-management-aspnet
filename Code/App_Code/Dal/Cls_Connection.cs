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

/// <summary>
/// Summary description for Cls_Connection
/// </summary>
public class Cls_Connection
{
	public Cls_Connection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string ConnectionString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["MunicipalAdministrationSystemConnectionString"].ConnectionString;
        }
    }
}
