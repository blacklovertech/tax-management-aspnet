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

public partial class Admin_frmRevenueBlockMaster : System.Web.UI.Page
{
    Cls_revenueCircleMaster objrevenue = new Cls_revenueCircleMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowRevenueCircleid();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }

    }

    private void ShowRevenueCircleid()
    {
        try
        {
            DataSet ds = Cls_revenueCircleMaster.ShowRevenuecircleId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlRevenuName.DataSource = ds.Tables[0];
                ddlRevenuName.DataTextField = "RevenueCircleName";
                ddlRevenuName.DataValueField = "RevenueCircleid";
                ddlRevenuName.DataBind();
                ddlRevenuName.Items.Insert(0, "--Select One--");
            }
          
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objrevenue.RevenueBlockName = txtRevenueName.Text;
            objrevenue.RevenueBlockSpan = txtSpan.Text;
            objrevenue.RevenueDesc = txtdescrip.Text;
            objrevenue.RevenueBlockAbbr = txtAbbrvation.Text;
            objrevenue.RevenueCircleid = Convert.ToInt32(ddlRevenuName.SelectedValue);
           
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objrevenue.insertRevenueBlockData();
            if (i > 0)
            {
                ClearData();
                lblError.Text = "Sucessfully Record Added..";
            }
            else
            {
                lblError.Text = "Error Process Try Again";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

    }
    public void ClearData()
    {
        txtRevenueName.Text = "";
        txtAbbrvation.Text = "";
        txtdescrip.Text = "";
        txtSpan.Text = "";
        lblError.Text = "";
        if (ddlRevenuName.SelectedIndex != 0)
            ddlRevenuName.SelectedIndex = 0;

    }
}
