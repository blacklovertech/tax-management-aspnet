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
/// Summary description for Cls_FloorMaster
/// </summary>
public class Cls_FloorMaster
{

    private int floorId;
    private string floorName;
    private string floorDescription;

    // constructor
    public Cls_FloorMaster()
    {
    }
    public int InsertFloorMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0]=new SqlParameter("@FloorId",FloorId);
            p[1]=new SqlParameter("@FloorName",FloorName);
            p[2] = new SqlParameter("@FloorDescription", FloorDescription);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_FloorMaster_Insert",p);
        }
        catch (Exception ex)
        {
            
            throw new ArgumentException(ex.Message);
        }
    
    }
    public int FloorId { get { return floorId; } set { floorId = value; } }
    public string FloorName { get { return floorName; } set { floorName = value; } }
    public string FloorDescription { get { return floorDescription; } set { floorDescription = value; } }
}