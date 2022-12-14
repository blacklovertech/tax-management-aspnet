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
/// Summary description for Cls_MunicipalityTaxMaster
/// </summary>
public class Cls_MunicipalityTaxMaster
{

    private int municipalityTaxId;
    private int municipalityId;
    private int taxTypeId;
    private DateTime  taxConstituteddate;
    private decimal  taxMinValue;
    private decimal  taxMaxValue;
    private bool  taxActiveState;

    // constructor
    public Cls_MunicipalityTaxMaster()
    {
    }
    public int InsertMunicipalitytaxMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@MunicipalityId", MunicipalityId);
            p[1] = new SqlParameter("@TaxTypeId", TaxTypeId);
            p[2] = new SqlParameter("@TaxConstituteddate", TaxConstituteddate);
            p[3] = new SqlParameter("@TaxMinValue", TaxMinValue);
            p[4] = new SqlParameter("@TaxMaxValue", TaxMaxValue);
            p[5] = new SqlParameter("@TaxActiveState", TaxActiveState);

            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMaster_Insert1", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowTaxtypeId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_GovernMentTaxMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowMunicipalityId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowMunicipalityAlldetails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMasteralldetails");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowMunicipalitySelectId(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p=new SqlParameter("@municipalityid",id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_Municipalitytaxmastermunicipalityidselect",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }

    public int MunicipalityTaxId { get { return municipalityTaxId; } set { municipalityTaxId = value; } }
    public int MunicipalityId { get { return municipalityId; } set { municipalityId = value; } }
    public int TaxTypeId { get { return taxTypeId; } set { taxTypeId = value; } }
    public DateTime  TaxConstituteddate { get { return taxConstituteddate; } set { taxConstituteddate = value; } }
    public decimal  TaxMinValue { get { return taxMinValue; } set { taxMinValue = value; } }
    public decimal  TaxMaxValue { get { return taxMaxValue; } set { taxMaxValue = value; } }
    public bool  TaxActiveState { get { return taxActiveState; } set { taxActiveState = value; } }

    public static DataSet ShowMunicipalityId(int p)
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tbl_MunicipalityMaster where MunicipalityId="+p+"");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet ShowMunicipalityAlldetailsIdWise(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Id", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMasteralldetailsIdWise",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet ShowMunicipalityTaxAlldetailsNameWise(string Name)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Name",Name);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMasteralldetailsNamewise", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public static DataSet ShowMunicipalityTaxDetails()
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxReports");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
