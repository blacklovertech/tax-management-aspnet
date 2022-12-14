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
/// Summary description for Cls_PanchayatTaxMaster
/// </summary>

public class Cls_PanchayattaxMaster
{

    private int panchayatTaxId;
    private int panchayatId;
    private int taxTypeId;
    private DateTime  taxConstitutedDate;
    private decimal  taxMinValue;
    private decimal  taxMaxvalue;
    private bool  taxActiveStatus;

    // constructor
    public Cls_PanchayattaxMaster()
    {
    }
    public int InsertGovernMentMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@PanchayatId", PanchayatId);
            p[1] = new SqlParameter("@TaxTypeId", TaxTypeId);
            p[2] = new SqlParameter("@TaxConstitutedDate", TaxConstitutedDate);
            p[3] = new SqlParameter("@TaxMinValue", TaxMinValue);
            p[4] = new SqlParameter("@TaxMaxvalue", TaxMaxvalue);
            p[5] = new SqlParameter("@TaxActiveStatus", TaxActiveStatus);
         
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_PanchayattaxMaster_Insert", p);
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
    public DataSet ShowGramPanchayatId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_GrampanchayatMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowGramPanchayatALldetails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_panchayattaxmasteralldetails");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowGramPanchayatALldetailsIdWise(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Id", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_panchayattaxmasteralldetailsIdwise", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowGramPanchayatALldetailsNameWise(string Name)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Name", Name);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_panchayattaxmasteralldetailsNameWise", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public DataSet ShowGramPanchayatIdselect(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@panchayatid", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_panchayattaxmasterpanchayatidselect",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int PanchayatTaxId { get { return panchayatTaxId; } set { panchayatTaxId = value; } }
    public int PanchayatId { get { return panchayatId; } set { panchayatId = value; } }
    public int TaxTypeId { get { return taxTypeId; } set { taxTypeId = value; } }
    public DateTime  TaxConstitutedDate { get { return taxConstitutedDate; } set { taxConstitutedDate = value; } }
    public decimal  TaxMinValue { get { return taxMinValue; } set { taxMinValue = value; } }
    public decimal  TaxMaxvalue { get { return taxMaxvalue; } set { taxMaxvalue = value; } }
    public bool  TaxActiveStatus { get { return taxActiveStatus; } set { taxActiveStatus = value; } }

    public static DataSet ShowPanchayatDetailsIdWise(int id)
    {
        try
        {

            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select * from tbl_GrampanchayatMaster where Grampanchayatid="+id+"");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
        
    }
}
