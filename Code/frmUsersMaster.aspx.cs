using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Admin_frmUsersMaster : System.Web.UI.Page
{
    Cls_UserMaster objuserMaster = new Cls_UserMaster();
    string status;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            objuserMaster.UserFirstName = txtfirstName.Text;
            objuserMaster.UserMiddleName = txtMiddleName.Text;
            objuserMaster.UserLastName = txtLastName.Text;
            objuserMaster.Houseno = txtHouseNo.Text;           
            objuserMaster.DOB = Convert.ToDateTime(txtDateofBirth.Text);
            objuserMaster.Address = txtAddress.Text;
            objuserMaster.EmailId = txtEmailId.Text;
            objuserMaster.PhoneNo = txtPhoneNO.Text;
            objuserMaster.LoginName = txtUserName.Text;
            objuserMaster.PassWord = txtPassword.Text;

            int i = objuserMaster.InsertUsermaster(out status);
            if (i > 0)
            {
                ClearData();
                lblError.Text = status;
                
                
            }
            else
            {

                lblError.Text = status;
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        try
        {
            ClearData();
            lblError.Text = "";
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }

    }
    public void ClearData()
    {
        txtAddress.Text = "";
        txtEmailId.Text = "";
        txtUserName.Text = "";
        txtPassword.Text = "";
        txtConformPassword.Text = "";
        txtDateofBirth.Text = "";
        txtfirstName.Text = "";
        txtfirstName.Text = "";
        txtLastName.Text = "";
        txtMiddleName.Text = "";
        txtHouseNo.Text = "";
        txtPhoneNO.Text = "";
        lblError.Text = "";
        
        
        
    }
   
  }
