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
/// Summary description for Cls_MunicipalityTaxMasterDetails
/// </summary>
public class Cls_MunicipalityTaxMasterDetails
{

    private int municipaliltyTaxPaymentId;
    private string municipalityTaxpayDate;
    private int uniqueMunicipalityNo;
    private string paymenttype;
    private Boolean paymentcibfirmedstatus;
    private decimal paymentAmount;
    private string anyRemarks;

    // constructor
    public Cls_MunicipalityTaxMasterDetails()
    {
    }
    public int InsertMunicipalityTaxMasterDetails()
    {
        try
        {
            SqlParameter []p=new SqlParameter[5];
            p[0]=new SqlParameter("@UniqueMunicipalityNo",UniqueMunicipalityNo);
            p[1]=new SqlParameter("@Paymenttype",Paymenttype);
            p[2]=new SqlParameter("@paymentcibfirmedstatus",paymentcibfirmedstatus);
            p[3]=new SqlParameter("@paymentAmount",paymentAmount);
            p[4] = new SqlParameter("@AnyRemarks", AnyRemarks);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_MunicipalityTaxMasterDetails_Insert",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowMunicipalityNo()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityTaxMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int MunicipaliltyTaxPaymentId { get { return municipaliltyTaxPaymentId; } set { municipaliltyTaxPaymentId = value; } }
    public string MunicipalityTaxpayDate { get { return municipalityTaxpayDate; } set { municipalityTaxpayDate = value; } }
    public int UniqueMunicipalityNo { get { return uniqueMunicipalityNo; } set { uniqueMunicipalityNo = value; } }
    public string Paymenttype { get { return paymenttype; } set { paymenttype = value; } }
    public bool Paymentcibfirmedstatus { get { return paymentcibfirmedstatus; } set { paymentcibfirmedstatus = value; } }
    public decimal  PaymentAmount { get { return paymentAmount; } set { paymentAmount = value; } }
    public string AnyRemarks { get { return anyRemarks; } set { anyRemarks = value; } }
}
