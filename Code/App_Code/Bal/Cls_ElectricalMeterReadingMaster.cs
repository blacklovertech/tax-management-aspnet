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
/// Summary description for Cls_ElectricalMeterReadingMaster
/// </summary>
public class Cls_electricalmeterreadingmaster
{

    private int meterreadingid;
    private int uniquehouseno;
    private int electricalserviceno;
    private int previousreading;
    private int presentreading;
    private int unitsconsumed;
    private decimal emergencycharges;
    private decimal currentCharges;
    private int ed;
    private decimal addCharges;
    private decimal fsacharges;
    private decimal acdcharges;
    private decimal billAmount;
    private decimal adyamount;
    private decimal netamount;
    private string areeas;
    private DateTime dateelectivitybill;

    // constructor
    public Cls_electricalmeterreadingmaster()
    {
    }

    public int Meterreadingid { get { return meterreadingid; } set { meterreadingid = value; } }
    public int Uniquehouseno { get { return uniquehouseno; } set { uniquehouseno = value; } }
    public int Electricalserviceno { get { return electricalserviceno; } set { electricalserviceno = value; } }
    public int Previousreading { get { return previousreading; } set { previousreading = value; } }
    public int Presentreading { get { return presentreading; } set { presentreading = value; } }
    public int Unitsconsumed { get { return unitsconsumed; } set { unitsconsumed = value; } }
    public decimal Emergencycharges { get { return emergencycharges; } set { emergencycharges = value; } }
    public decimal CurrentCharges { get { return currentCharges; } set { currentCharges = value; } }
    public int Ed { get { return ed; } set { ed = value; } }
    public decimal AddCharges { get { return addCharges; } set { addCharges = value; } }
    public decimal Fsacharges { get { return fsacharges; } set { fsacharges = value; } }
    public decimal Acdcharges { get { return acdcharges; } set { acdcharges = value; } }
    public decimal BillAmount { get { return billAmount; } set { billAmount = value; } }
    public decimal Adyamount { get { return adyamount; } set { adyamount = value; } }
    public decimal Netamount { get { return netamount; } set { netamount = value; } }
    public string Areeas { get { return areeas; } set { areeas = value; } }
    public DateTime Dateelectivitybill { get { return dateelectivitybill; } set { dateelectivitybill = value; } }
    public int InsertElectricalMetorReadingMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[16];
            p[0] = new SqlParameter("@uniquehouseno", Uniquehouseno);
            p[1] = new SqlParameter("@electricalserviceno", Electricalserviceno);
            p[2] = new SqlParameter("@previousreading", Previousreading);
            p[3] = new SqlParameter("@presentreading", Presentreading);
            p[4] = new SqlParameter("@unitsconsumed", Unitsconsumed);
            p[5] = new SqlParameter("@emergencycharges", Emergencycharges);
            p[6] = new SqlParameter("@CurrentCharges", CurrentCharges);
            p[7] = new SqlParameter("@ed", Ed);
            p[8] = new SqlParameter("@AddCharges", AddCharges);
            p[9] = new SqlParameter("@fsacharges", Fsacharges);
            p[10] = new SqlParameter("@acdcharges", Acdcharges);
            p[11] = new SqlParameter("@billAmount", BillAmount);
            p[12] = new SqlParameter("@adyamount", Adyamount);
            p[13] = new SqlParameter("@netamount", Netamount);
            p[14] = new SqlParameter("@Areeas", Areeas);
            p[15] = new SqlParameter("@dateelectivitybill", Dateelectivitybill);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_electricalmeterreadingmaster_Insert", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowHouseNo()
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

    public static DataSet SelectHouseNoId(int i)
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_ElectricityServiceMaster where uniquehouseno=" + i + "");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static int  SelectElectricalServiceNo(int p1)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@Serviceno", p1);
            p[1] = new SqlParameter("@PrsentReading", SqlDbType.BigInt);
            p[1].Direction = ParameterDirection.Output;
             SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_GetPresentReading", p);
             return Convert.ToInt32(p[1].Value);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message); 
        }
    }
}