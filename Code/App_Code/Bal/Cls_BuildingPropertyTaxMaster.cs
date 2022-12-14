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
/// Summary description for Cls_BuildingPropertyTaxMaster
/// </summary>
public class Cls_BuildingpropertyTaxMaster
{

    private int propertytaxid;
    private string propertyTaxpaiddate;
    private decimal propertytaxAmount;
    private int buildingNo;
    private int uniqueHouseNo;
    private decimal  educationtaxamt;
    private decimal librarycessAmt;
    private decimal uacpenalty;

    // constructor
    public Cls_BuildingpropertyTaxMaster()
    {
    }
    public int InsertBuildingpropertyTaxMaster()
    {
        try
        {
            SqlParameter [] p=new SqlParameter[6];
            p[0]=new SqlParameter("@propertytaxAmount",propertytaxAmount);
            p[1]=new SqlParameter("@BuildingNo",BuildingNo);
            p[2]=new SqlParameter("@UniqueHouseNo",UniqueHouseNo);
            p[3]=new SqlParameter("@Educationtaxamt",Educationtaxamt);
            p[4]=new SqlParameter("@LibrarycessAmt",LibrarycessAmt);
            p[5] = new SqlParameter("@Uacpenalty", Uacpenalty);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_BuildingpropertyTaxMaster_Insert", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    
    public int Propertytaxid { get { return propertytaxid; } set { propertytaxid = value; } }
    public string PropertyTaxpaiddate { get { return propertyTaxpaiddate; } set { propertyTaxpaiddate = value; } }
    public decimal PropertytaxAmount { get { return propertytaxAmount; } set { propertytaxAmount = value; } }
    public int BuildingNo { get { return buildingNo; } set { buildingNo = value; } }
    public int UniqueHouseNo { get { return uniqueHouseNo; } set { uniqueHouseNo = value; } }
    public decimal Educationtaxamt { get { return educationtaxamt; } set { educationtaxamt = value; } }
    public decimal LibrarycessAmt { get { return librarycessAmt; } set { librarycessAmt = value; } }
    public decimal Uacpenalty { get { return uacpenalty; } set { uacpenalty = value; } }
}
