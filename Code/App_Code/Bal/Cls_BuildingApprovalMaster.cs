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
/// Summary description for Cls_BuildingApprovalMaster
/// </summary>
public class Cls_BuildingApprovalMaster
{

    private int buildingApprNo;
    private string buildingApprDate;
    private string buildingDescription;
    private int housetypeid;
    private int plotId;
    private int areaId;
    private int streetId;
    private int noOfFloorAppr;
    private decimal plintharea;

    // constructor
    public Cls_BuildingApprovalMaster()
    {
    }
    public DataSet ShowHousetypeMaster()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_HouseTypeMaster_Select");

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    
    }
    public int InsertBuildingApprovalMaster()
    {
        try
        {
            SqlParameter[]p=new SqlParameter[7];
            p[0]=new SqlParameter("@BuildingDescription",BuildingDescription);
            p[1]=new SqlParameter("@Housetypeid",Housetypeid);
            p[2]=new SqlParameter("@PlotId",PlotId);
            p[3]=new SqlParameter("@AreaId",AreaId);
            p[4]=new SqlParameter("@StreetId",StreetId);
            p[5]=new SqlParameter("@NoOfFloorAppr",NoOfFloorAppr);
            p[6] = new SqlParameter("@Plintharea", Plintharea);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingApprovalMaster_Insert",p);
            
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int BuildingApprNo { get { return buildingApprNo; } set { buildingApprNo = value; } }
    public string BuildingApprDate { get { return buildingApprDate; } set { buildingApprDate = value; } }
    public string BuildingDescription { get { return buildingDescription; } set { buildingDescription = value; } }
    public int Housetypeid { get { return housetypeid; } set { housetypeid = value; } }
    public int PlotId { get { return plotId; } set { plotId = value; } }
    public int AreaId { get { return areaId; } set { areaId = value; } }
    public int StreetId { get { return streetId; } set { streetId = value; } }
    public int NoOfFloorAppr { get { return noOfFloorAppr; } set { noOfFloorAppr = value; } }
    public decimal Plintharea { get { return plintharea; } set { plintharea = value; } }

    public static DataSet ShowBuildingpropertyTaxes()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingPropertyTaxReports"); 
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
