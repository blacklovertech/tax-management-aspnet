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


public partial class Users_frmShowHouseInformation : System.Web.UI.Page
{
    WebService objGeospatial = new WebService();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ShowHouseDetails();
    }
    public void ShowHouseDetails()
    {
        try
        {
            DataSet ds = objGeospatial.HouseInformationDetails(Convert.ToInt32(Session["UserId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                dethousedetails.DataSource = ds.Tables[0];
                dethousedetails.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
