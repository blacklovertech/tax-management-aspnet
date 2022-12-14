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
/// Summary description for MunicipalityMaster
/// </summary>
public class Cls_MunicipalityMaster
{

    private int municipalityId;
    private string municipalityName;
    private string municipalityConstituteddate;
    private string municipalitySpan;
    private int noOfPanchayatsCovered;
    private decimal  averrageIncomeTarget;
    private byte[] municipalityMap;
    private string municipalityMaptype;
    private string municipalitylatandlong;
    private int municipalityGradeId;

    // constructor
    public Cls_MunicipalityMaster()
    {
    }
    public int InsertMunicipalityMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@MunicipalityName", MunicipalityName);
            p[1] = new SqlParameter("@MunicipalitySpan", MunicipalitySpan);
            p[2] = new SqlParameter("@NoOfPanchayatsCovered", NoOfPanchayatsCovered);
            p[3] = new SqlParameter("@AverrageIncomeTarget", AverrageIncomeTarget);
            p[4] = new SqlParameter("@MunicipalityMap", MunicipalityMap);
            p[5] = new SqlParameter("@MunicipalityMaptype", MunicipalityMaptype);
            p[6] = new SqlParameter("@Municipalitylatandlong", Municipalitylatandlong);
            p[7] = new SqlParameter("@MunicipalityGradeId", MunicipalityGradeId);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityMaster_Insert", p);


        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowMunicipalityGradeID()
    {
        try
        {
            DataSet ds = new DataSet();
           return  SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityGradeMaster_Select");

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
    public DataSet ShowMunicipalityIdSelect(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@MunicipalityId", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_MunicipalityMaster_Select_Id",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }

    public int MunicipalityId { get { return municipalityId; } set { municipalityId = value; } }
    public string MunicipalityName { get { return municipalityName; } set { municipalityName = value; } }
    public string MunicipalityConstituteddate { get { return municipalityConstituteddate; } set { municipalityConstituteddate = value; } }
    public string MunicipalitySpan { get { return municipalitySpan; } set { municipalitySpan = value; } }
    public int NoOfPanchayatsCovered { get { return noOfPanchayatsCovered; } set { noOfPanchayatsCovered = value; } }
    public decimal  AverrageIncomeTarget { get { return averrageIncomeTarget; } set { averrageIncomeTarget = value; } }
    public byte[] MunicipalityMap { get { return municipalityMap; } set { municipalityMap = value; } }
    public string MunicipalityMaptype { get { return municipalityMaptype; } set { municipalityMaptype = value; } }
    public string Municipalitylatandlong { get { return municipalitylatandlong; } set { municipalitylatandlong = value; } }
    public int MunicipalityGradeId { get { return municipalityGradeId; } set { municipalityGradeId = value; } }

    public static DataSet SearchMunicipality(string p)
    {
        try
        {
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.Text, "select MunicipalityName as MunicipalityName,NoOfpanchayatsCovered as Noofpanchayatscovered,AverrageIncometarget as AverageIncome from tbl_municipalityMaster where municipalityname like '%" + p + "%'");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
}
