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

public partial class Admin_frmRevenueCircleMaster : System.Web.UI.Page
{
    Cls_revenueCircleMaster objrevenue = new Cls_revenueCircleMaster();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objrevenue.RevenueCircleName = txtRevenueName.Text;
            objrevenue.RevenueCircleDesc = txtdescrip.Text;
            objrevenue.RevenueCircleSpan = txtSpan.Text;
            objrevenue.RevenueAbbr = txtAbbrvation.Text;
          
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objrevenue.InsertRevenueCircle();
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Successfully Revenue Details Added...";
            }
            else
            {
                lblError.Text = "Error Process Try Again..dd";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {

        Cleardata();
    }
    public void Cleardata()
    {
        txtAbbrvation.Text = "";
        txtdescrip.Text = "";
        txtRevenueName.Text = "";
        txtSpan.Text = "";
        lblError.Text = "";
    }
}
