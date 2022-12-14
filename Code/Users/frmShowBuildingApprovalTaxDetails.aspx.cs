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

public partial class Users_frmShowBuildingApprovalTaxDetails : System.Web.UI.Page
{
    WebService objgeospation = new WebService();
    protected void Page_Load(object sender, EventArgs e)
    {
       
       
        BuildingApprovalTaxDetails();

    }
    public void BuildingApprovalTaxDetails()
    {
        try
        {
            DataSet ds = objgeospation.BuildingApprovalTaxDetails(Convert.ToInt32(Session["UserId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                detailsBuildingApprovalTaxDetails.DataSource = ds.Tables[0];
                detailsBuildingApprovalTaxDetails.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
