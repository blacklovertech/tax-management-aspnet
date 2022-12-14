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
/// Summary description for Cls_UserMaster
/// </summary>
public class Cls_UserMaster
{

    private int userID;
    private string userFirstName;
    private string userMiddleName;
    private string userLastName;
    private string address;
    private string emailId;
    private string phoneNo;
    private DateTime dOB;
    private DateTime  dOR;
    private int rolleid;
    private string loginName;
    private string passWord;
    public string  C_M_D_Type { get; set; }
    public int C_m_d_ID { get; set; }
    public String Houseno  { get; set; }
    // constructor
    public Cls_UserMaster()
    {
    }
    public int InsertUsermaster( out string  Status)
    {
        try
        {
            SqlParameter []p=new SqlParameter[11];
            p[0]=new SqlParameter("@UserFirstName",UserFirstName);
            p[1]=new SqlParameter("@UserMiddleName",UserMiddleName);
            p[2]=new SqlParameter("@UserLastName",UserLastName);
            p[3]=new SqlParameter("@Address",Address);
            p[4]=new SqlParameter("@EmailId",EmailId);
            p[5]=new SqlParameter("@PhoneNo",PhoneNo);
            p[6]=new SqlParameter("@DOB",DOB);
           
            p[7]=new SqlParameter("@LoginName",LoginName);
            p[8]=new SqlParameter("@Password",PassWord);
            p[9] = new SqlParameter("@HouseNo", Houseno);
            p[10] = new SqlParameter("@Msg", SqlDbType.VarChar,50);
            p[10].Direction = ParameterDirection.Output;
            int i= SqlHelper.ExecuteNonQuery(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_UserMaster_Insert", p);
            Status = p[10].Value.ToString();
            return i;
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public DataSet ShowRollid()
    {
        try
        {
            DataSet ds = new DataSet();
            return SqlHelper.ExecuteDataset(Cls_Connection.ConnectionString, CommandType.StoredProcedure, "Sp_RoleMaster_Select");
        }
        catch (Exception ex)
        {

            throw new ArgumentException(ex.Message);
        }
    }
    public int UserID { get { return userID; } set { userID = value; } }
    public string UserFirstName { get { return userFirstName; } set { userFirstName = value; } }
    public string UserMiddleName { get { return userMiddleName; } set { userMiddleName = value; } }
    public string UserLastName { get { return userLastName; } set { userLastName = value; } }
    public string Address { get { return address; } set { address = value; } }
    public string EmailId { get { return emailId; } set { emailId = value; } }
    public string PhoneNo { get { return phoneNo; } set { phoneNo = value; } }
    public DateTime  DOB { get { return dOB; } set { dOB = value; } }
    public DateTime  DOR { get { return dOR; } set { dOR = value; } }
    public string LoginName { get { return loginName; } set { loginName = value; } }
    public string PassWord { get { return passWord; } set { passWord = value; } }
    public int Rolleid { get { return rolleid; } set { rolleid = value; } }



}
