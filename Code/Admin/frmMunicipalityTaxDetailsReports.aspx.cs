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

public partial class Admin_frmMunicipalityTaxDetailsReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void GetData()
    {
        try
        {
            DataSet ds = Cls_MunicipalityTaxMaster.ShowMunicipalityTaxDetails();
            if (ds.Tables[0].Rows.Count != 0)
            {
                gridReport.DataSource = ds.Tables[0];
                gridReport.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }

    }
    protected void gridReport_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            gridReport.PageIndex = e.NewPageIndex;
            GetData();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
