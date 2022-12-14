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

public partial class Admin_frmElectricalConnectionCategoryMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Cls_ElectricalEquipmentMaster objelectricalEquipment = new Cls_ElectricalEquipmentMaster();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objelectricalEquipment.ConnectionCategoryName = txtCategoryName.Text;
            objelectricalEquipment.ConnectionCategoryAbbr = txtAbbrvation.Text;
            objelectricalEquipment.ConnectionCategoryDescription = txtdescrip.Text;
            objelectricalEquipment.ConnectionCategoryMinCharge =Convert.ToInt32(txtminimumcharges.Text);
            objelectricalEquipment.ConnectionCategoryMaxCharge =Convert.ToInt32(txtMaximumcharges.Text);
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objelectricalEquipment.InsertElectricalConnectionCategoryDetails();
            
            if (i>0)
            {
                ClearData();
                lblError.Text = "Electrical COnnection Category Details Added..";
            }
            else
            {
                lblError.Text = "Error Process Try Again..";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearData();
    }
    public void ClearData()
    {
        txtAbbrvation.Text = "";
        txtCategoryName.Text = "";
        txtdescrip.Text = "";
        txtMaximumcharges.Text = "";
        txtminimumcharges.Text = "";
        lblError.Text = "";
    }
}
