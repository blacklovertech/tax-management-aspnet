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
/// Summary description for Cls_PanchayatAssetMaster
/// </summary>
public class Cls_PanchayatAssetMaster
{

    private int panchayatAssetId;
    private int panchayatId;
    private int assettypeId;
    private decimal  assetCast;
    private DateTime  assetPurchasedDate;
    private int costEvalutionDoneUserId;
    private string assetLatandlong;
    private string assetAddress;
    private string assetSpanIfany;

    // constructor
    public Cls_PanchayatAssetMaster()
    {
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
    public DataSet ShowAssetmasterId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_AssetTypeMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }

    public int InsertPanchayatAssetMaster()
    {
        try
        {
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@PanchayatId", PanchayatId);
            p[1] = new SqlParameter("@AssettypeId", AssettypeId);
            p[2] = new SqlParameter("@AssetCast", AssetCast);
            p[3] = new SqlParameter("@AssetPurchasedDate", AssetPurchasedDate);
            p[4] = new SqlParameter("@CostEvalutionDoneUserId", CostEvalutionDoneUserId);
            p[5] = new SqlParameter("@AssetLatandlong", AssetLatandlong);
            p[6] = new SqlParameter("@AssetAddress", AssetAddress);
            p[7] = new SqlParameter("@AssetSpanIfany", AssetSpanIfany);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_PanchayatAssetMaster_Insert", p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowPanchayatAssetAllDetails()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_PanchayatAssetAlldetailsShow");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowPanchayatAssetAllDetailsIdWise(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Id", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_PanchayatAssetAlldetailsShowIdWise", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowPanchayatAssetAllDetailsName(string Name)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@Name", Name);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_PanchayatAssetAlldetailsShowNameWise", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public int PanchayatAssetId { get { return panchayatAssetId; } set { panchayatAssetId = value; } }
    public int PanchayatId { get { return panchayatId; } set { panchayatId = value; } }
    public int AssettypeId { get { return assettypeId; } set { assettypeId = value; } }
    public decimal  AssetCast { get { return assetCast; } set { assetCast = value; } }
    public DateTime  AssetPurchasedDate { get { return assetPurchasedDate; } set { assetPurchasedDate = value; } }
    public int CostEvalutionDoneUserId { get { return costEvalutionDoneUserId; } set { costEvalutionDoneUserId = value; } }
    public string AssetLatandlong { get { return assetLatandlong; } set { assetLatandlong = value; } }
    public string AssetAddress { get { return assetAddress; } set { assetAddress = value; } }
    public string AssetSpanIfany { get { return assetSpanIfany; } set { assetSpanIfany = value; } }
}