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
using System.Windows.Forms;

public partial class SubAdmin_frmHouseMaster : System.Web.UI.Page
{
    Cls_HousesMaster objhousemaster = new Cls_HousesMaster();
    static string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreaId();
                ddlStreetName.Items.Insert(0, "--SelectOne--");
                ddlPlotName.Items.Insert(0, "--SelectOne--");
                ShowBuildingApprno();
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
            int houseno;
            objhousemaster.OwnerName = txtOwnerName.Text;
            objhousemaster.TelephonNo = txttelephoneno.Text;
            objhousemaster.Email = txtemail.Text;
            objhousemaster.ActualHouseNo = txtActualNo.Text;
            objhousemaster.AreaId = Convert.ToInt32(ddlAreaId.SelectedValue);
            objhousemaster.StreetId = Convert.ToInt32(ddlStreetName.SelectedValue);
            objhousemaster.PlotId = Convert.ToInt32(ddlPlotName.SelectedValue);
            if (ddlpowerStatus.Text == "Yes")
                objhousemaster.ElectricityConnstatus = true;
            else
                objhousemaster.ElectricityConnstatus = false;
            if (ddlGasStatus.Text == "Yes")
                objhousemaster.GasConnStatus = true;
            else
                objhousemaster.GasConnStatus = false;
            objhousemaster.WaterConnStatus = ddlwaterconnstatus.Text;
            objhousemaster.C_M_P_Id = Convert.ToInt32(Session["EmployeeId"]);
            objhousemaster.BuildingApprovalNo = Convert.ToInt32(ddlBuildingApprovalNo.SelectedValue);
            
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objhousemaster.InsertHouseMaster(out houseno);
            if (i > 0)
            {
                lblError.Text = "Sucess fully Inserted";
                lblUniqueHouseno.Visible = true;
                lblHouseno.Text = houseno.ToString();
                Cleardata();
                btnAdd.Enabled = false;
            }
            else
            {
                lblError.Text = "Sucess fully Not Inserted";
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
        lblError.Text = "";
        lblHouseno.Text = "";
        lblUniqueHouseno.Visible = false;
    }
    protected void txtActualNo_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    int i = convert.toint32(txtactualno.text.length);
        //    if (i > 4)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
        //catch (exception ex)
        //{

        //    lblerror.text = ex.message;
        //}

    }
    protected void ddlAreaId_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
            if (ddlAreaId.SelectedIndex != 0)
            {
                DataSet ds = objplotmaster.ShowAreaIdSelectShowStreetid(Convert.ToInt32(ddlAreaId.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlStreetName.DataSource = ds.Tables[0];
                    ddlStreetName.DataTextField = "StreetName";
                    ddlStreetName.DataValueField = "StreetId";
                    ddlStreetName.DataBind();
                    ddlStreetName.Items.Insert(0, "--SelectOne--");
                }
                else
                {
                    ddlStreetName.Items.Clear();
                    ddlStreetName.Items.Insert(0, "--SelectOne--");
                }
            }
            else
            {
                ddlStreetName.Items.Clear();
                ddlStreetName.Items.Insert(0, "--SelectOne--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void ShowAreaId()
    {
        try
        {
            Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
            DataSet ds = objplotmaster.ShowAreaid(Convert.ToInt32(Session["EmployeeId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlAreaId.DataSource = ds.Tables[0];
                ddlAreaId.DataTextField = "AreaName";
                ddlAreaId.DataValueField = "AreaId";
                ddlAreaId.DataBind();
            }
            ddlAreaId.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlStreetName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
            if (ddlStreetName.SelectedIndex != 0)
            {
                DataSet ds = objplotmaster.SelctStreetIdShowPlotid(Convert.ToInt32(ddlStreetName.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlPlotName.DataSource = ds.Tables[0];
                    ddlPlotName.DataTextField = "plotownername";
                    ddlPlotName.DataValueField = "plotid";
                    ddlPlotName.DataBind();
                    ddlPlotName.Items.Insert(0, "--SelectOne--");
                }
                else
                {
                    ddlPlotName.Items.Clear();
                    ddlPlotName.Items.Insert(0, "--SelectOne--");
                }
            }
            else
            {
                ddlPlotName.Items.Clear();
                ddlPlotName.Items.Insert(0, "--SelectOne--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        txtActualNo.Text = "";
        txtemail.Text = "";
        txtOwnerName.Text = "";
        txttelephoneno.Text = "";
        if (ddlAreaId.SelectedIndex != 0)
            ddlAreaId.SelectedIndex = 0;
        if (ddlGasStatus.SelectedIndex != 0)
            ddlGasStatus.SelectedIndex = 0;
        if (ddlPlotName.SelectedIndex != 0)
            ddlPlotName.SelectedIndex = 0;
        if (ddlpowerStatus.SelectedIndex != 0)
            ddlpowerStatus.SelectedIndex = 0;
        if (ddlStreetName.SelectedIndex != 0)
            ddlStreetName.SelectedIndex = 0;
        if (ddlwaterconnstatus.SelectedIndex != 0)
            ddlwaterconnstatus.SelectedIndex = 0;
        if (ddlBuildingApprovalNo.SelectedIndex != 0)
            ddlBuildingApprovalNo.SelectedIndex = 0;

    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        try
        {  
            objhousemaster.ActualHouseNo = txtActualNo.Text;
            s = objhousemaster.CheckActualHouseno();           
            if (txtActualNo.Text != "")
            {
                if (s == "Accepted")
                {
                    btnAdd.Enabled = true;
                    
                }

                else
                {
                    MessageBox.Show("Enter Anothe House No");
                }
            }
            else
            {                
                MessageBox.Show("Enter House NO");            
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void ShowBuildingApprno()
    {

        try
        {
            Cls_Buildingfloormaster objbuildingfloorMaster = new Cls_Buildingfloormaster();
            DataSet ds = objbuildingfloorMaster.ShowBuildingApprnohousewise();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlBuildingApprovalNo.DataSource = ds.Tables[0];
                ddlBuildingApprovalNo.DataTextField = "BuildingApprNo";
                ddlBuildingApprovalNo.DataValueField = "BuildingApprNo";
                ddlBuildingApprovalNo.DataBind();
                ddlBuildingApprovalNo.Items.Insert(0, "--SelectOne--");
            }
            else 
            {
                ddlBuildingApprovalNo.Items.Clear();
                ddlBuildingApprovalNo.Items.Insert(0, "--SelectOne--");
            }
           
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
