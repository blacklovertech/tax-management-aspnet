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
/// Summary description for Cls_AreaMaster
/// </summary>
public class Cls_AreaMaster
{

    private int areaId;
    private string areaName;
    private decimal   areaSpan;
    private int areaTypeId;
    private DateTime  areaIdentifiedDate;
    public int C_M_P_Id { get; set; }

    // constructor
    public Cls_AreaMaster()
    {
    }
    public int InsertAreamaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[5];
            p[0]=new SqlParameter("@AreaName",AreaName);
            p[1]=new SqlParameter("@AreaSpan",AreaSpan);
            p[2]=new SqlParameter("@AreaTypeId",AreaTypeId);
            p[3] = new SqlParameter("@AreaIdentifiedDate", AreaIdentifiedDate);
            p[4] = new SqlParameter("@C_M_P_Id", C_M_P_Id);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_AreaMaster_Insert",p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowAreatypeid()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString,CommandType.StoredProcedure,"Sp_AreaTypeMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }

    public int AreaId { get { return areaId; } set { areaId = value; } }
    public string AreaName { get { return areaName; } set { areaName = value; } }
    public decimal   AreaSpan { get { return areaSpan; } set { areaSpan = value; } }
    public int AreaTypeId { get { return areaTypeId; } set { areaTypeId = value; } }
    public DateTime  AreaIdentifiedDate { get { return areaIdentifiedDate; } set { areaIdentifiedDate = value; } }
}
