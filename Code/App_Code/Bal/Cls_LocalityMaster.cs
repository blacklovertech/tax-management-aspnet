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
/// Summary description for Class1
/// </summary>
public class Cls_LocalityMaster
{

    private int localityId;
    private string localityName;
    private string localityDesc;
    private int localitySpan;
    private string localityAbbr;
    private int areaId;
    private string localityIdentityDate;

    // constructor
    public Cls_LocalityMaster()
    {
    }
    public int InsertLocalityMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[5];
            p[0]=new SqlParameter("@LocalityName",LocalityName);
            p[1]=new SqlParameter("@LocalityDesc",LocalityDesc);
            p[2]=new SqlParameter("@LocalitySpan",LocalitySpan);
            p[3]=new SqlParameter("@LocalityAbbr",LocalityAbbr);
            p[4]=new SqlParameter("@AreaId",AreaId);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_LocalityMaster_Insert",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int LocalityId { get { return localityId; } set { localityId = value; } }
    public string LocalityName { get { return localityName; } set { localityName = value; } }
    public string LocalityDesc { get { return localityDesc; } set { localityDesc = value; } }
    public int LocalitySpan { get { return localitySpan; } set { localitySpan = value; } }
    public string LocalityAbbr { get { return localityAbbr; } set { localityAbbr = value; } }
    public int AreaId { get { return areaId; } set { areaId = value; } }
    public string LocalityIdentityDate { get { return localityIdentityDate; } set { localityIdentityDate = value; } }
}
