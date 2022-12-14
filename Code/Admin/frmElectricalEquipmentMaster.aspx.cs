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

public partial class Admin_frmElectricalEquipmentMaster : System.Web.UI.Page
{
    Cls_ElectricalEquipmentMaster objElectricalEquipment = new Cls_ElectricalEquipmentMaster();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objElectricalEquipment.ElectricalEquipmentName = txtEquipmentName.Text;
            objElectricalEquipment.ElectricalEquipmentAbbr = txtAbbrvation.Text;
            objElectricalEquipment.ElectricalEqupmentDesc = txtdescrip.Text;
            int i = objElectricalEquipment.insertEquipmentMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;

            if (i > 0)
            {
                ClearData();
                lblError.Text = "Sucessfully Electrical";
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
        txtdescrip.Text = "";
        txtEquipmentName.Text = "";
        lblError.Text = "";
    
    }
}
