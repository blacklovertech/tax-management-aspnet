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


public partial class Users_frmShowMunicipalityTaxDetails : System.Web.UI.Page
{
    WebService objMunicipality = new WebService();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        MunicipalityTaxDetails();

    }
    public void MunicipalityTaxDetails()
    {
        try
        {
            DataSet ds = objMunicipality.HouseWiseMunicipalityTaxes(Convert.ToInt32(Session["UserId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                detShowTaxes.DataSource = ds.Tables[0];
                detShowTaxes.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
