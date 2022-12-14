using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;
using Geospatial;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]

    public DataSet HouseInformationDetails(int houseno)
    {
        try
        {
            SqlParameter p = new SqlParameter("@HouseId", houseno);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ShowHouseInformation", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    [WebMethod]
    public DataSet HouseWiseMunicipalityTaxes(int houseno)
    {
        try
        {
            SqlParameter p = new SqlParameter("@HouseNo", houseno);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxDetails123", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    [WebMethod]
    public DataSet ElectricalBillMeterReading(int houseno)
    {
        try
        {
            SqlParameter p = new SqlParameter("@electricalhouseno", houseno);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_EleectricalMeterReadingMaster", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    [WebMethod]
    public DataSet BuildingApprovalTaxDetails(int houseno)
    {
        try
        {
            SqlParameter p = new SqlParameter("@HouseNo", houseno);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingPropertyTaxDetails", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    [WebMethod]
    public DataSet ShowElectricalServiceNo(int houseno)
    {
        try
        {
            SqlParameter p = new SqlParameter("@HouseNo", houseno);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "sp_SelectElectricalServiceMaster", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    [WebMethod]
    public DataSet SearchMunicipalityTaxDetails(int houseno, DateTime todate, DateTime enddate)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@houseno", houseno);
            p[1] = new SqlParameter("@todate", todate);
            p[2] = new SqlParameter("@enddate", enddate);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityDetailsShowIdWise", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    [WebMethod]
    public DataSet SearchElectricalmeterDetails(int houseno, DateTime todate, DateTime enddate)
    {
        try
        {
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@houseno", houseno);
            p[1] = new SqlParameter("@todate", todate);
            p[2] = new SqlParameter("@enddate", enddate);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_ElectricalMeterReadingSearch", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }



}

