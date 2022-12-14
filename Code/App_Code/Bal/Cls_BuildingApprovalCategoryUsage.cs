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
/// Summary description for Cls_BuildingApprovalCategoryUsage
/// </summary>
public class Cls_BuildingApprovalCategoryusageMaster
{

    private int buildingApprovalNo;
    private int categoryusagemasterId;
    private int floorid;

    // constructor
    public Cls_BuildingApprovalCategoryusageMaster()
    {
    }
    public int InsertBuildingApprovalCategoryUsageMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@BuildingApprovalNo", BuildingApprovalNo);
            p[1] = new SqlParameter("@CategoryusagemasterId", CategoryusagemasterId);
            p[2] = new SqlParameter("@floorid", floorid);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingApprovalCategoryusageMaster_Insert", p);


        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet  ShowCategoryUsageMasterId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_Categoryusagemaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);

        }
    }

    public int BuildingApprovalNo { get { return buildingApprovalNo; } set { buildingApprovalNo = value; } }
    public int CategoryusagemasterId { get { return categoryusagemasterId; } set { categoryusagemasterId = value; } }
    public int Floorid { get { return floorid; } set { floorid = value; } }
}
