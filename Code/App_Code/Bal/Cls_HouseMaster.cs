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
/// Summary description for Cls_HouseMaster
/// </summary>
public class Cls_HousesMaster
{

    private int uniQueHousNo;
    private string ownerName;
    private string telephonNo;
    private string email;
    private string actualHouseNo;
    private string houseRegistrationdate;
    private int areaId;
    private int streetId;
    private int plotId;
    private Boolean electricityConnstatus;
    private Boolean gasConnStatus;
    private string waterConnStatus;
    public int C_M_P_Id{ get; set; }
    public int BuildingApprovalNo { get; set; }

    // constructor
    public Cls_HousesMaster()
    {
    }
    public int InsertHouseMaster(out int Housno)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[13];
            p[0]=new SqlParameter("@OwnerName",OwnerName);
            p[1]=new SqlParameter("@TelephonNo",TelephonNo);
            p[2]=new SqlParameter("@Email",Email);
            p[3]=new SqlParameter("@ActualHouseNo",ActualHouseNo);
           
            p[4]=new SqlParameter("@AreaId",AreaId);
            p[5]=new SqlParameter("@StreetId",StreetId);
            p[6]=new SqlParameter("@PlotId",PlotId);
            p[7]=new SqlParameter("@ElectricityConnstatus",ElectricityConnstatus);
            p[8]=new SqlParameter("@GasConnStatus",GasConnStatus);
            p[9] = new SqlParameter("@WaterConnStatus", WaterConnStatus);
            p[10] = new SqlParameter("@C_M_P_Id", C_M_P_Id);
            p[11] = new SqlParameter("@BuildingApprovalNo", BuildingApprovalNo);
            p[12] = new SqlParameter("@Houseno", SqlDbType.Int);
            p[12].Direction=ParameterDirection.Output;
           int i=  SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_HousesMaster_Insert",p);
            Housno=Convert.ToInt32(p[12].Value.ToString());
            return i;
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public string   CheckActualHouseno()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@Actualno",ActualHouseNo);
            p[1] = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            p[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_houseno", p);
            return p[1].Value.ToString();

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    
    }
    public DataSet ShowHOusedetailsSelectId(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Uniquehouseno", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_HousesMaster_IdSelect",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int UpdateHOuseMasterdetails()
    {
        try
        {
            SqlParameter[] p=new SqlParameter[4];
                p[0]=new SqlParameter ("@UniQueHousNo",UniQueHousNo);
            p[1]=new SqlParameter("@OwnerName",OwnerName);
            p[2]=new SqlParameter("@TelephonNo",TelephonNo);
            p[3] = new SqlParameter("@Email", Email);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_HousesMaster_Update",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int UniQueHousNo { get { return uniQueHousNo; } set { uniQueHousNo = value; } }
    public string OwnerName { get { return ownerName; } set { ownerName = value; } }
    public string TelephonNo { get { return telephonNo; } set { telephonNo = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string ActualHouseNo { get { return actualHouseNo; } set { actualHouseNo = value; } }
    public string HouseRegistrationdate { get { return houseRegistrationdate; } set { houseRegistrationdate = value; } }
    public int AreaId { get { return areaId; } set { areaId = value; } }
    public int StreetId { get { return streetId; } set { streetId = value; } }
    public int PlotId { get { return plotId; } set { plotId = value; } }
    public Boolean ElectricityConnstatus { get { return electricityConnstatus; } set { electricityConnstatus = value; } }
    public Boolean GasConnStatus { get { return gasConnStatus; } set { gasConnStatus = value; } }
    public string WaterConnStatus { get { return waterConnStatus; } set { waterConnStatus = value; } }

    public static DataSet ShowBuildingApprovalNOSelectHouseno(int p)
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster where UniQueHousNo="+p+"");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowHouseReports()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ShowHouseReports");
        }
        catch (Exception ex) 
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet SelectRevenuCircleId(int p)
    {
        try
        {
            DataSet ds = new DataSet();
          //  SqlParameter p = new SqlParameter("@RevenueCircleId", p);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_RevenueBlockMaster where RevenueCircleId="+p+"");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }   
    }
}

