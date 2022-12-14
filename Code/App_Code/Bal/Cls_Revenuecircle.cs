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
/// Summary description for Cls_Revenuecircle
/// </summary>

public class Cls_revenueCircleMaster
{

    private int revenueCircleid;
    private string revenueAbbr;
    private string revenueCircleName;
    private string revenueCircleDesc;
    private string revenueCircleSpan;
    private string revenueCircleIdentifiedDate;
    private int revenueBlockId;
    private string revenueBlockName;
    private string revenueBlockSpan;
    private string revenueDesc;
    private string revenueBlockAbbr;
    private string revenueBlockIdentifiedDate;

    // constructor
    public Cls_revenueCircleMaster()
    {
    }

    public int RevenueCircleid { get { return revenueCircleid; } set { revenueCircleid = value; } }
    public string RevenueCircleName { get { return revenueCircleName; } set { revenueCircleName = value; } }
    public string RevenueCircleDesc { get { return revenueCircleDesc; } set { revenueCircleDesc = value; } }
    public string RevenueCircleSpan { get { return revenueCircleSpan; } set { revenueCircleSpan = value; } }
    public string RevenueCircleIdentifiedDate { get { return revenueCircleIdentifiedDate; } set { revenueCircleIdentifiedDate = value; } }
    public int RevenueBlockId { get { return revenueBlockId; } set { revenueBlockId = value; } }
    public string RevenueBlockName { get { return revenueBlockName; } set { revenueBlockName = value; } }
    public string RevenueBlockSpan { get { return revenueBlockSpan; } set { revenueBlockSpan = value; } }
    public string RevenueDesc { get { return revenueDesc; } set { revenueDesc = value; } }
    public string RevenueBlockAbbr { get { return revenueBlockAbbr; } set { revenueBlockAbbr = value; } }
    public string RevenueBlockIdentifiedDate { get { return revenueBlockIdentifiedDate; } set { revenueBlockIdentifiedDate = value; } }
    public string RevenueAbbr { get { return revenueAbbr; } set { revenueAbbr = value; } }

    public int InsertRevenueCircle()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0]=new SqlParameter("@RevenueCircleName",RevenueCircleName);
            p[1]=new SqlParameter("@RevenueCircleDesc",RevenueCircleDesc);
            p[2]=new SqlParameter("@RevenueCircleSpan",RevenueCircleSpan);
            p[3]=new SqlParameter("@RevenueAbbr",RevenueAbbr);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_revenueCircleMaster_Insert", p); 
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int insertRevenueBlockData()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@RevenueBlockName", RevenueBlockName);
            p[1] = new SqlParameter("@RevenueBlockSpan", RevenueBlockSpan);
            p[2] = new SqlParameter("@RevenueDesc", RevenueDesc);
            p[3] = new SqlParameter("@RevenueBlockAbbr", RevenueBlockAbbr);
            p[4] = new SqlParameter("@RevenueCircleId", RevenueCircleid);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_RevenueBlockMaster_Insert", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowRevenuecircleId()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "Select * from tl_revenueCircleMaster");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowRevenueBlockId()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "Select * from tl_RevenueBlockMaster");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
