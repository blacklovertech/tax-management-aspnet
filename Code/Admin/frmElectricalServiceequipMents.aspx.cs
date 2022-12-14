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

public partial class Admin_frmElectricalServiceequipMents : System.Web.UI.Page
{
    Cls_ElectricalEquipmentMaster objelectricalequipment = new Cls_ElectricalEquipmentMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowElectricalEquipmentId();
                ShowElectricalServiceNoId();            
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
            objelectricalequipment.ElectricalServiceNo = Convert.ToInt32(ddlServiceNo.SelectedValue);
            objelectricalequipment.ElectricalEquipmentId = Convert.ToInt32(ddlEquipmentId.SelectedValue);
            objelectricalequipment.EquipmentVolltage = Convert.ToDecimal(txtWaltage.Text);
            objelectricalequipment.ConsumptionUnitsAverage =Convert.ToInt32(txtUnitsAverage.Text);
            int i = objelectricalequipment.InsertElectricalServiveEquipments();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                ClearData();
                lblError.Text = "Sucessfully service Equipments Added..";
            }
            else
            {
                lblError.Text = "Error Process Try Again...";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlServiceNo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearData();
    }
    public void ClearData()
    {
        txtUnitsAverage.Text = "";
        txtWaltage.Text = "";
        if (ddlEquipmentId.SelectedIndex != 0)
            ddlEquipmentId.SelectedIndex = 0;
        if (ddlServiceNo.SelectedIndex != 0)
            ddlServiceNo.SelectedIndex = 0;
        lblError.Text = "";
    }
    public void ShowElectricalServiceNoId()
    {
        DataSet ds = Cls_ElectricalEquipmentMaster.ShowElectricalServiceNo();
        if (ds.Tables[0].Rows.Count != 0)
        {
            ddlServiceNo.DataSource = ds.Tables[0];
            ddlServiceNo.DataTextField = "ElectricalServiceNo";
            ddlServiceNo.DataValueField = "ElectricalServiceNo";
            ddlServiceNo.DataBind();
            ddlServiceNo.Items.Insert(0, "--Select One--");
        }

    }
    public void ShowElectricalEquipmentId()
    {
        DataSet ds = Cls_ElectricalEquipmentMaster.ShowElectricalEquipments();
        if (ds.Tables[0].Rows.Count != 0)
        {
            ddlEquipmentId.DataSource = ds.Tables[0];
            ddlEquipmentId.DataTextField = "ElectricalEquipmentName";
            ddlEquipmentId.DataValueField = "ElectricalEquipmentId";
            ddlEquipmentId.DataBind();
            ddlEquipmentId.Items.Insert(0, "--Select One--");
        }

    }
}
