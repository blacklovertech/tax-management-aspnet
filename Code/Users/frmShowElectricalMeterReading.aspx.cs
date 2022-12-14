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

public partial class Users_frmShowElectricalMeterReading : System.Web.UI.Page
{
    WebService objgeospation = new WebService() ;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            ElectricalTaxMeterReadingDetails();
           
        }
    }
    public void ElectricalTaxMeterReadingDetails()
    {
        try
        {
            ddlElectricalServiceNo.Items.Clear();
            DataSet ds = objgeospation.ShowElectricalServiceNo(Convert.ToInt32(Session["UserId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlElectricalServiceNo.DataSource = ds.Tables[0];
                ddlElectricalServiceNo.DataTextField = "ElectricalServiceNo";
                ddlElectricalServiceNo.DataValueField = "ElectricalServiceNo";
                ddlElectricalServiceNo.DataBind();
                ddlElectricalServiceNo.Items.Insert(0, "--Select One--");
            }
            else
            {
                ddlElectricalServiceNo.Items.Clear();
                ddlElectricalServiceNo.Items.Insert(0, "--Select One--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlElectricalServiceNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlElectricalServiceNo.SelectedIndex != 0)
            {
                DataSet ds = objgeospation.ElectricalBillMeterReading(Convert.ToInt32(ddlElectricalServiceNo.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    detailsElectricalShowDetails.DataSource = ds.Tables[0];
                    detailsElectricalShowDetails.DataBind();
                }
                else
                {
                    detailsElectricalShowDetails.EmptyDataText = "No details";
                    detailsElectricalShowDetails.DataBind();
                }
            }
            else
            { }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
