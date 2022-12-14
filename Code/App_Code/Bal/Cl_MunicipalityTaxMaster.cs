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
/// Summary description for Cl_MunicipalityTaxMaster
/// </summary>
public class Cl_MunicipalityTaxMaster
{

    private int uniqueMunicipalityNo;
    private int uniqueHouseNo;
    private int taxAssenmentNo;
    private int localityId;
    private int buildingApprovalNo;
    private int noOfFlower;
    private decimal  propetyTaxvalue;
    private decimal educationTaxValue;
    private decimal  libraryCess;
    private int uacPenalty;
    private int municipalityorpanchayatorcorporatioNo;
    public int RevenueCircleId { get; set; }
    public int RevenueBlockId { get; set; }

    // constructor
    public Cl_MunicipalityTaxMaster()
    {
    }
    public DataSet  ShowUniqueHouseNO()
    { 
    try 
	{
        DataSet ds = new DataSet();
        return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_housenomunicipalittTaxwise");
	}
	catch (Exception ex)
	{

        throw new ArgumentException(ex.Message);
	}
    }
    public DataSet ShowUniqueHouseNO1()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tl_HousesMaster");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowUniqueHouseNO123()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_housenodisplaybuildingapproval");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet ShowLocalityId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_LocalityMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowBuildingApprovalNo()
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
    public int InsertMunicipalityTaxMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[12];
            p[0]=new SqlParameter("@UniqueHouseNo",UniqueHouseNo);
            p[1]=new SqlParameter("@TaxAssenmentNo",TaxAssenmentNo);
            p[2]=new SqlParameter("@LocalityId",LocalityId);
            p[3]=new SqlParameter("@BuildingApprovalNo",BuildingApprovalNo);
            p[4]=new SqlParameter("@NoOfFlower",NoOfFlower);
            p[5]=new SqlParameter("@PropetyTaxvalue",PropetyTaxvalue);
           p[6]=new SqlParameter("@EducationTaxValue",EducationTaxValue);
            p[7]=new SqlParameter("@LibraryCess",LibraryCess);
            p[8] = new SqlParameter("@UacPenalty", UacPenalty);
            p[9] = new SqlParameter("@MunicipalityorpanchayatorcorporatioNo", MunicipalityorpanchayatorcorporatioNo);
            p[10]=new SqlParameter("@RevenueCircleId",RevenueCircleId);
            p[11] = new SqlParameter("@RevenueBlockId", RevenueBlockId);


            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMaster_Insert", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int UniqueMunicipalityNo { get { return uniqueMunicipalityNo; } set { uniqueMunicipalityNo = value; } }
    public int UniqueHouseNo { get { return uniqueHouseNo; } set { uniqueHouseNo = value; } }
    public int TaxAssenmentNo { get { return taxAssenmentNo; } set { taxAssenmentNo = value; } }
    public int LocalityId { get { return localityId; } set { localityId = value; } }
    public int BuildingApprovalNo { get { return buildingApprovalNo; } set { buildingApprovalNo = value; } }
    public int NoOfFlower { get { return noOfFlower; } set { noOfFlower = value; } }
    public decimal PropetyTaxvalue { get { return propetyTaxvalue; } set { propetyTaxvalue = value; } }
    public decimal EducationTaxValue { get { return educationTaxValue; } set { educationTaxValue = value; } }
    public decimal LibraryCess { get { return libraryCess; } set { libraryCess = value; } }
    public int UacPenalty { get { return uacPenalty; } set { uacPenalty = value; } }
    public int MunicipalityorpanchayatorcorporatioNo { get { return municipalityorpanchayatorcorporatioNo; } set { municipalityorpanchayatorcorporatioNo = value; } }

}
