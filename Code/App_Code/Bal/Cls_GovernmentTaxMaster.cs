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
/// Summary description for Cls_GovernmentTaxMaster
/// </summary>
public class Cls_GovernMentTaxMaster
{

    private int taxTypeId;
    private string taxName;
    private string taxAbbr;
    private string taxDescription;
    private decimal  mintaxValue;
    private decimal  maxtaxValue;
    private DateTime  taxConstitutedDate;
    private bool  taxtypeActiveStatus;

    // constructor
    public Cls_GovernMentTaxMaster()
    {
    }
    public int InsertGovernMentMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[7];
            p[0]=new SqlParameter("@TaxName",TaxName);
            p[1]=new SqlParameter("@TaxAbbr",TaxAbbr);
            p[2]=new SqlParameter("@TaxDescription",TaxDescription);
            p[3]=new SqlParameter("@MintaxValue",MintaxValue);
            p[4]=new SqlParameter("@MaxtaxValue",MaxtaxValue);
            p[5]=new SqlParameter("@TaxConstitutedDate",TaxConstitutedDate);
            p[6] = new SqlParameter("@TaxtypeActiveStatus", TaxtypeActiveStatus);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_GovernMentTaxMaster_Insert",p);
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
    public int TaxTypeId { get { return taxTypeId; } set { taxTypeId = value; } }
    public string TaxName { get { return taxName; } set { taxName = value; } }
    public string TaxAbbr { get { return taxAbbr; } set { taxAbbr = value; } }
    public string TaxDescription { get { return taxDescription; } set { taxDescription = value; } }
    public decimal  MintaxValue { get { return mintaxValue; } set { mintaxValue = value; } }
    public decimal  MaxtaxValue { get { return maxtaxValue; } set { maxtaxValue = value; } }
    public DateTime  TaxConstitutedDate { get { return taxConstitutedDate; } set { taxConstitutedDate = value; } }
    public bool  TaxtypeActiveStatus { get { return taxtypeActiveStatus; } set { taxtypeActiveStatus = value; } }
}
