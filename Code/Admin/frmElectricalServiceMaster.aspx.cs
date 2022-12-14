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

public partial class Admin_frmElectricalServiceMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                UniqueHouseNo();
                ElectricalCOnnectionCategoryId();
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    Cls_ElectricalEquipmentMaster objelectricalEquipment = new Cls_ElectricalEquipmentMaster();
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            objelectricalEquipment.UniqueHouseno = Convert.ToInt32(ddluniqueno.SelectedValue);
            objelectricalEquipment.ActulaHouseNo = ddluniqueno.SelectedItem.Text;
            objelectricalEquipment.ConncetionCategoryId = Convert.ToInt32(ddlConnectionCategoryId.SelectedValue);
            objelectricalEquipment.Ero = txtEro.Text;
            objelectricalEquipment.Section = txtSection.Text;
            objelectricalEquipment.Group = txtGroup.Text;
            objelectricalEquipment.NoOffloors =Convert.ToInt32(txtFloors.Text);
            objelectricalEquipment.NoofPhases =Convert.ToInt32(txtphases.Text);
            objelectricalEquipment.Mp = txtMp.Text;
            objelectricalEquipment.Load = txtLoad.Text;
            int i = objelectricalEquipment.InsertElectricalServiceMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                ClearData();
                lblError.Text = "Sucessfully Electricity Services Details Added..";
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
        try
        {
            ClearData();
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void ClearData()
    {

        txtEro.Text = "";
        txtFloors.Text = "";
        txtGroup.Text = "";
        txtHouseNO.Text = "";
        txtLoad.Text = "";
        txtMp.Text = "";
        txtphases.Text = "";
        txtSection.Text = "";
        if (ddlConnectionCategoryId.SelectedIndex != 0)
            ddlConnectionCategoryId.SelectedIndex = 0;
        if (ddluniqueno.SelectedIndex != 0)
            ddluniqueno.SelectedIndex = 0;
        lblError.Text = "";
        
    
    }
    public void UniqueHouseNo()
    {
        try
        {
            DataSet ds = Cls_ElectricalEquipmentMaster.ShowUniquehouseIdElectricalservicewise123();
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
    protected void ddluniqueno_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddluniqueno.SelectedIndex != 0)
        {
            DataSet ds = Cls_ElectricalEquipmentMaster.ShowActivalHouseNoSelectHouseno(Convert.ToInt32( ddluniqueno.SelectedValue));
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtHouseNO.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                txtHouseNO.Text = "";
            }
        }
        else
        {
            lblError.Text = "";
            txtHouseNO.Text = "";
        }
    }

    public void ElectricalCOnnectionCategoryId()
    {
        try
        {
            DataSet ds = Cls_ElectricalEquipmentMaster.ShowElectionConnectionCategoryIdDisply();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlConnectionCategoryId.DataSource = ds.Tables[0];
                ddlConnectionCategoryId.DataTextField = "ConnectionCategoryName";
                ddlConnectionCategoryId.DataValueField = "ConnectionCategoryId";
                ddlConnectionCategoryId.DataBind();
                ddlConnectionCategoryId.Items.Insert(0, "--Select One--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
