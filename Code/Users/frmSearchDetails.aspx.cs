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

public partial class Users_frmSearchDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    WebService objservice = new WebService();
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        GetData();
    }
    protected void gridShowMunicipalityDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridShowMunicipalityDetails.PageIndex = e.NewPageIndex;
        GetData();
    }
    public void GetData()
    {
        try
        {
            DataSet ds = objservice.SearchMunicipalityTaxDetails(Convert.ToInt16(Session["UserId"]), Convert.ToDateTime(txtStartDate.Text), Convert.ToDateTime(txtEndDate.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                gridShowMunicipalityDetails.DataSource = ds.Tables[0];
                gridShowMunicipalityDetails.DataBind();
            }
            else
            {
                gridShowMunicipalityDetails.EmptyDataText = "<h3>No TaxDetails </h3>";
                gridShowMunicipalityDetails.DataBind();
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
