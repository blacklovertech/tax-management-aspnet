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
/// Summary description for Cls_StreetMaster
/// </summary>
public class Cls_StreetMaster
{

    private int streetId;
    private string streetName;
    private int streetSpan;
    private int streetTypeId;
    private int areaid;
    public int C_M_P_Id { get; set; }

    // constructor
    public Cls_StreetMaster()
    {
    }
    public int InsertStreetMaster()
    {
        try
        {
            SqlParameter []p=new SqlParameter[5];
            p[0]=new SqlParameter("@StreetName",StreetName);
            p[1]=new SqlParameter("@StreetSpan",StreetSpan);
            p[2]=new SqlParameter("@StreetTypeId",StreetTypeId);
            p[3] = new SqlParameter("@AreaId", AreaId);
            p[4]=new SqlParameter("@C_M_P_Id",C_M_P_Id);
            return SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_StreetMaster_Insert", p);
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowStreetTypeId()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_StreetTypeMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message); 
        }
    
    }
    public int StreetId { get { return streetId; } set { streetId = value; } }
    public string StreetName { get { return streetName; } set { streetName = value; } }
    public int StreetSpan { get { return streetSpan; } set { streetSpan = value; } }
    public int StreetTypeId { get { return streetTypeId; } set { streetTypeId = value; } }
    public int  AreaId { get { return areaid; } set { areaid = value; } }
}
