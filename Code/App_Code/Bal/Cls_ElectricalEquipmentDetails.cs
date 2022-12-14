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
/// Summary description for Cls_ElectricalEquipmentDetails
/// </summary>
public class Cls_ElectricalEquipmentMaster
{

    private int electricalEquipmentId;
    private string electricalEquipmentName;
    private string electricalEquipmentAbbr;
    private string electricalEquipmentDesc;
    private int connectionCategoryId;
    private string connectionCategoryName;
    private string connectionCategoryAbbr;
    private decimal connectionCategoryMinCharge;
    private decimal connectionCategoryMaxCharge;
    private string connectionCategoryDescription;
    private decimal equipmentVolltage;
    private decimal consumptionUnitsAverage;
    private int electricalServiceNo;
    private int uniqueHouseno;
    private string actulaHouseNo;
    private int conncetionCategoryId;
    private string ero;
    private string section;
    private string group;
    private int noOffloors;
    private int  noofPhases;
    private string mp;
    private string load;

    // constructor
    public Cls_ElectricalEquipmentMaster()
    {
    }

    public int ElectricalEquipmentId { get { return electricalEquipmentId; } set { electricalEquipmentId = value; } }
    public string ElectricalEquipmentName { get { return electricalEquipmentName; } set { electricalEquipmentName = value; } }
    public string ElectricalEquipmentAbbr { get { return electricalEquipmentAbbr; } set { electricalEquipmentAbbr = value; } }
    public string ElectricalEqupmentDesc { get { return electricalEquipmentDesc; } set { electricalEquipmentDesc = value; } }
    public int ConnectionCategoryId { get { return connectionCategoryId; } set { connectionCategoryId = value; } }
    public string ConnectionCategoryName { get { return connectionCategoryName; } set { connectionCategoryName = value; } }
    public string ConnectionCategoryAbbr { get { return connectionCategoryAbbr; } set { connectionCategoryAbbr = value; } }
    public decimal ConnectionCategoryMinCharge { get { return connectionCategoryMinCharge; } set { connectionCategoryMinCharge = value; } }
    public decimal ConnectionCategoryMaxCharge { get { return connectionCategoryMaxCharge; } set { connectionCategoryMaxCharge = value; } }
    public string ConnectionCategoryDescription { get { return connectionCategoryDescription; } set { connectionCategoryDescription = value; } }
    public decimal EquipmentVolltage { get { return equipmentVolltage; } set { equipmentVolltage = value; } }
    public decimal ConsumptionUnitsAverage { get { return consumptionUnitsAverage; } set { consumptionUnitsAverage = value; } }
    public int ElectricalServiceNo { get { return electricalServiceNo; } set { electricalServiceNo = value; } }
    public int UniqueHouseno { get { return uniqueHouseno; } set { uniqueHouseno = value; } }
    public string ActulaHouseNo { get { return actulaHouseNo; } set { actulaHouseNo = value; } }
    public int ConncetionCategoryId { get { return conncetionCategoryId; } set { conncetionCategoryId = value; } }
    public string Ero { get { return ero; } set { ero = value; } }
    public string Section { get { return section; } set { section = value; } }
    public string Group { get { return group; } set { group = value; } }
    public int NoOffloors { get { return noOffloors; } set { noOffloors = value; } }
    public int  NoofPhases { get { return noofPhases; } set { noofPhases = value; } }
    public string Mp { get { return mp; } set { mp = value; } }
    public string Load { get { return load; } set { load = value; } }

    public int insertEquipmentMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@ElectricalEquipmentName", ElectricalEquipmentName);
            p[1] = new SqlParameter("@ElectricalEquipmentAbbr", ElectricalEquipmentAbbr);
            p[2] = new SqlParameter("@ElectricalEquipmentDesc", ElectricalEqupmentDesc);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ElectricalEquipmentMaster_Insert", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int InsertElectricalConnectionCategoryDetails()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@ConnectionCategoryName", ConnectionCategoryName);
            p[1] = new SqlParameter("@ConnectionCategoryAbbr", ConnectionCategoryAbbr);
            p[2] = new SqlParameter("@ConnectionCategoryMinCharge", ConnectionCategoryMinCharge);
            p[3] = new SqlParameter("@ConnectionCategoryMaxCharge", ConnectionCategoryMaxCharge);
            p[4] = new SqlParameter("@ConnectionCategoryDescription", ConnectionCategoryDescription);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ElectricalConnectionCategoryMaster_Insert", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int InsertElectricalServiceMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@UniqueHouseno", UniqueHouseno);
            p[1] = new SqlParameter("@ActulaHouseNo", ActulaHouseNo);
            p[2] = new SqlParameter("@ConncetionCategoryId", ConncetionCategoryId);
            p[3] = new SqlParameter("@Ero", Ero);
            p[4] = new SqlParameter("@Section", Section);
            p[5]=new SqlParameter("@Group",Group);
            p[6]=new SqlParameter("@NoOffloors",NoOffloors);
            p[7] = new SqlParameter("@NoofPhases", NoofPhases);
            p[8]=new SqlParameter("@mp",Mp);
            p[9] = new SqlParameter("@load", Load);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ElectricityServiceMaster_Insert", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowUniqueHouseId()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowUniquehouseIdElectricalservicewise()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster  where UniQueHousNo in (select Distinct (UniqueHouseno) from tl_ElectricityServiceMaster)");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowUniquehouseIdElectricalservicewise123()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster  where UniQueHousNo not in (select Distinct (UniqueHouseno) from tl_ElectricityServiceMaster)");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public static DataSet ShowActivalHouseNoSelectHouseno(int i)
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster where uniquehousno =" + i + "");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowElectionConnectionCategoryIdDisply()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_ElectricalConnectionCategoryMaster");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int InsertElectricalServiveEquipments()
    {
        try
        {
               SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@ElectricalserviceNo", electricalServiceNo);
            p[1] = new SqlParameter("@ElectricalEquipmentid", ElectricalEquipmentId);
            p[2] = new SqlParameter("@EquipmentVolltage", EquipmentVolltage);
            p[3] = new SqlParameter("@ConsumptionUnitsAverage", ConsumptionUnitsAverage);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ElectricalServiceEquipments_Insert", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowElectricalServiceNo()
    {
        return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_ElectricityServiceMaster");
    }

    public static DataSet ShowElectricalEquipments()
    {
        return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_ElectricalEquipmentMaster");
    }
}
