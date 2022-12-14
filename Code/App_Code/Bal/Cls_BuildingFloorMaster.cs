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
/// Summary description for Cls_BuildingFloorMaster
/// </summary>
public class Cls_Buildingfloormaster
{

    private int buildingApprno;
    private int floorNoUnique;
    private decimal  floorPlintharea;

    // constructor
    public Cls_Buildingfloormaster()
    {
    }
    public int InsertBuildingfloorMaster()
    {
        try
        {
            SqlParameter [] p=new SqlParameter[3];
            p[0]=new SqlParameter("@BuildingApprno",BuildingApprno);
            p[1]=new SqlParameter("@floorNoUnique",floorNoUnique);
            p[2] = new SqlParameter("@floorPlintharea", floorPlintharea);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_Buildingfloormaster_Insert",p);
         

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowFloorID(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p=new SqlParameter("@BuildingApprno",id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_FloorMasteSelectId",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    
        public DataSet ShowFloorIDSelectApprovalCategory(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p=new SqlParameter("@BuildingApprno",id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_FloorMasteSelectIdCateggory", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowBuildingApprno()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingApprovalMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowBuildingApprnohousewise()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingApprovalMaster_SelectHouseDetailswise");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
 
    public int BuildingApprno { get { return buildingApprno; } set { buildingApprno = value; } }
    public int FloorNoUnique { get { return floorNoUnique; } set { floorNoUnique = value; } }
    public decimal  FloorPlintharea { get { return floorPlintharea; } set { floorPlintharea = value; } }
}
