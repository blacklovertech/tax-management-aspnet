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

public partial class Admin_frmElectricalMeterReadingMaster : System.Web.UI.Page
{
    Cls_electricalmeterreadingmaster objelectricalreadingdetails = new Cls_electricalmeterreadingmaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowUniqueHousenoId();
                ddlElectricalServiceNo.Items.Insert(0, "--Select One--");
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
            objelectricalreadingdetails.Uniquehouseno = Convert.ToInt32(ddluniqueno.SelectedValue);
            objelectricalreadingdetails.Electricalserviceno =Convert.ToInt32( ddlElectricalServiceNo.SelectedValue);
            objelectricalreadingdetails.Previousreading =Convert.ToInt32(txtPreviousReading.Text);
            objelectricalreadingdetails.Presentreading =Convert.ToInt32( txtPresentReading.Text);
            objelectricalreadingdetails.Unitsconsumed =Convert.ToInt32( txtConsumed.Text);
            objelectricalreadingdetails.Emergencycharges = Convert.ToDecimal(txtemergencyCharge.Text);
            objelectricalreadingdetails.CurrentCharges = Convert.ToDecimal(txtCustCharges.Text);
            objelectricalreadingdetails.Ed =Convert.ToInt32(txtEd.Text);
            objelectricalreadingdetails.AddCharges =Convert.ToDecimal(txtAddlCharges.Text);
            objelectricalreadingdetails.Fsacharges =Convert.ToDecimal(txtfsacharges.Text);
            objelectricalreadingdetails.Acdcharges =Convert.ToDecimal(txtAcdCharges.Text);
            objelectricalreadingdetails.BillAmount =Convert.ToDecimal( txtBillAmount.Text);
            objelectricalreadingdetails.Adyamount =Convert.ToDecimal(txtAdjamount.Text);
            objelectricalreadingdetails.Netamount =Convert.ToDecimal(txtnetAmount.Text);
            objelectricalreadingdetails.Areeas = txtArreas.Text;
            objelectricalreadingdetails.Dateelectivitybill =Convert.ToDateTime(txtDateelectricityBill.Text);
            int i = objelectricalreadingdetails.InsertElectricalMetorReadingMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                //ClearData();
                lblError.Text = "Sucessfully Reading Details Added..";
                btnAdd.Enabled = false;
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
    protected void ddluniqueno_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddluniqueno.SelectedIndex != 0)
            {
                ddlElectricalServiceNo.Items.Clear();
                txtPreviousReading.Text = "";
                DataSet ds = Cls_electricalmeterreadingmaster.SelectHouseNoId(Convert.ToInt32(ddluniqueno.SelectedValue));
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
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void ShowUniqueHousenoId()
    {
        try
        {

            DataSet ds = Cls_ElectricalEquipmentMaster.ShowUniquehouseIdElectricalservicewise();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddluniqueno.DataSource = ds.Tables[0];
                ddluniqueno.DataTextField = "ActualHouseNo";
                ddluniqueno.DataValueField = "UniQueHousNo";
                ddluniqueno.DataBind();
                ddluniqueno.Items.Insert(0, "--Select One--");
            }
                     
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void ClearData()
    {
        try
        {
            txtAcdCharges.Text = "";
            txtAddlCharges.Text = "";
            txtAdjamount.Text = "";
            txtArreas.Text = "";
            txtBillAmount.Text = "";
            txtConsumed.Text = "";
            txtCustCharges.Text = "";
            txtDateelectricityBill.Text = "";
            txtEd.Text = "";

            txtemergencyCharge.Text = "";
            txtfsacharges.Text = "";
            txtnetAmount.Text = "";
            txtPresentReading.Text = "";
            txtPreviousReading.Text = "";
            if (ddluniqueno.SelectedIndex != 0)
                ddluniqueno.SelectedIndex = 0;
            if (ddlElectricalServiceNo.SelectedIndex != 0)
                ddlElectricalServiceNo.SelectedIndex = 0;
            lblError.Text = "";
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
      
        
    }
    protected void btnNetAMount_Click(object sender, EventArgs e)
    {
        try
        {
            txtnetAmount.Text = Convert.ToString(Convert.ToInt32(txtemergencyCharge.Text) + Convert.ToInt32(txtCustCharges.Text) + Convert.ToInt32(txtEd.Text) + Convert.ToInt32(txtAddlCharges.Text) + Convert.ToInt32(txtfsacharges.Text) + Convert.ToInt32(txtAcdCharges.Text) + Convert.ToInt32(txtBillAmount.Text) + Convert.ToInt32(txtAdjamount.Text));
            btnAdd.Enabled = true;
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
                txtPreviousReading.Text = "";
                int i = Cls_electricalmeterreadingmaster.SelectElectricalServiceNo(Convert.ToInt32(ddlElectricalServiceNo.SelectedValue));
                txtPreviousReading.Text = i.ToString();
            }
            else
            {
                txtPreviousReading.Text = "";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
