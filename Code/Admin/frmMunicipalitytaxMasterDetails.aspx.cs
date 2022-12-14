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

public partial class SubAdmin_frmMunicipalitytaxMasterDetails : System.Web.UI.Page
{
    Cls_MunicipalityTaxMasterDetails objmunicipalitytaxdetails = new Cls_MunicipalityTaxMasterDetails();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowMunicipalityNo();
            }
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
            objmunicipalitytaxdetails.UniqueMunicipalityNo = Convert.ToInt32(ddlMunicipalityNO.SelectedValue);
            objmunicipalitytaxdetails.Paymenttype = ddlPaymenttype.Text;
            objmunicipalitytaxdetails.PaymentAmount = Convert.ToInt32(txtAmount.Text);
            objmunicipalitytaxdetails.AnyRemarks = txtremarks.Text;
            if(chkConformedstatus.Checked)
            objmunicipalitytaxdetails.Paymentcibfirmedstatus = true;
            else
                objmunicipalitytaxdetails.Paymentcibfirmedstatus = false;

            int i = objmunicipalitytaxdetails.InsertMunicipalityTaxMasterDetails();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;

            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Sucessfully Added...";
                
            }
            else
            {
                lblError.Text = "Sucessfully Not Added..";
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

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        txtAmount.Text = "";
        txtremarks.Text = "";
        lblError.Text = "";
       
        if (ddlMunicipalityNO.SelectedIndex != 0)
            ddlMunicipalityNO.SelectedIndex = 0;
        if (ddlPaymenttype.SelectedIndex != 0)
            ddlPaymenttype.SelectedIndex = 0;
        if (chkConformedstatus.Checked)
            chkConformedstatus.Checked = false;


    }
    public void ShowMunicipalityNo()
    {
        try
        {
            DataSet ds = objmunicipalitytaxdetails.ShowMunicipalityNo();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlMunicipalityNO.DataSource = ds.Tables[0];
                ddlMunicipalityNO.DataTextField = "UniqueMunicipalityTaxNo";
                ddlMunicipalityNO.DataValueField = "UniqueMunicipalitytaxNo";
                ddlMunicipalityNO.DataBind();
            }
            ddlMunicipalityNO.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
