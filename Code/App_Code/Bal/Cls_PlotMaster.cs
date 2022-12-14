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
/// Summary description for Cls_PlotMaster
/// </summary>
public class Cls_PLotMaster
{

    private int plotId;
    private string plotOwnerName;
    private string telephoneNO;
    private string plotDescription;
    private int areaId;
    private int streetId;
    private DateTime plotRegistrationDate;
    public int C_M_P_Id { get; set; }

    // constructor
    public Cls_PLotMaster()
    {
    }
    public int InsertPlotMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[6];
            p[0]=new SqlParameter("@PlotOwnerName",PlotOwnerName);
            p[1]=new SqlParameter("@TelephoneNO",TelephoneNO);
            p[2]=new SqlParameter("@PlotDescription",PlotDescription);
            p[3]=new SqlParameter("@AreaId",AreaId);
            p[4] = new SqlParameter("@StreetId", StreetId);
            p[5]= new SqlParameter("@C_M_P_Id", C_M_P_Id);
           
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_PLotMaster_Insert",p);

        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowAreaIdSelectShowStreetid(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@AreaId", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_AreaIdSelectShowStreetid",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }

    }
    public DataSet ShowAreaid(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@C_M_P_Id", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_AreaMaster_Select",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet SelctStreetIdShowPlotid(int id)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlParameter p = new SqlParameter("@streetid", id);
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_selectStreetidShowplotid",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int PlotId { get { return plotId; } set { plotId = value; } }
    public string PlotOwnerName { get { return plotOwnerName; } set { plotOwnerName = value; } }
    public string TelephoneNO { get { return telephoneNO; } set { telephoneNO = value; } }
    public string PlotDescription { get { return plotDescription; } set { plotDescription = value; } }
    public int AreaId { get { return areaId; } set { areaId = value; } }
    public int StreetId { get { return streetId; } set { streetId = value; } }
    public DateTime PlotRegistrationDate { get { return plotRegistrationDate; } set { plotRegistrationDate = value; } }
}
