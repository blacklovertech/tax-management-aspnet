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

public partial class SubAdmin_frmBuildingApprovalMaster : System.Web.UI.Page
{
    Cls_BuildingApprovalMaster objapprovalmaster = new Cls_BuildingApprovalMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreaId();
                HousetypeId();
                ddlStreetName.Items.Insert(0, "--SelectOne--");
                ddlPlotName.Items.Insert(0, "--SelectOne--");
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
            objapprovalmaster.BuildingDescription = txtDescription.Text;
            objapprovalmaster.Housetypeid = Convert.ToInt32(ddlHouseTypeid.SelectedValue);
            objapprovalmaster.PlotId = Convert.ToInt32(ddlPlotName.SelectedValue);
            objapprovalmaster.AreaId = Convert.ToInt32(ddlAreaName.SelectedValue);
            objapprovalmaster.StreetId = Convert.ToInt32(ddlStreetName.SelectedValue);
            objapprovalmaster.NoOfFloorAppr = Convert.ToInt32(txtNOofFloor.Text);
            objapprovalmaster.Plintharea = Convert.ToDecimal(txtplithArea.Text);
            int i = objapprovalmaster.InsertBuildingApprovalMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Sucessfully Building Approval Master Details Added";
            }
            else 
            {
                lblError.Text = "Not Added";
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
    }
    protected void ddlAreaName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
            if (ddlAreaName.SelectedIndex != 0)
            {
                DataSet ds = objplotmaster.ShowAreaIdSelectShowStreetid(Convert.ToInt32(ddlAreaName.SelectedValue));
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
    public void ShowAreaId()
    {
        try
        {
            Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
            DataSet ds = objplotmaster.ShowAreaid(Convert.ToInt32(Session["EmployeeId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlAreaName.DataSource = ds.Tables[0];
                ddlAreaName.DataTextField = "AreaName";
                ddlAreaName.DataValueField = "AreaId";
                ddlAreaName.DataBind();
            }
            ddlAreaName.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        txtDescription.Text = "";
        txtNOofFloor.Text = "";
        txtplithArea.Text = "";
       
        if (ddlAreaName.SelectedIndex != 0)
            ddlAreaName.SelectedIndex = 0;
        if (ddlHouseTypeid.SelectedIndex != 0)
            ddlHouseTypeid.SelectedIndex = 0;
        if (ddlPlotName.SelectedIndex != 0)
            ddlPlotName.SelectedIndex = 0;
    
        if (ddlStreetName.SelectedIndex != 0)
            ddlStreetName.SelectedIndex = 0;
      

    }
    public void HousetypeId()
    {
        try
        {
            DataSet ds = objapprovalmaster.ShowHousetypeMaster();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlHouseTypeid.DataSource = ds.Tables[0];
                ddlHouseTypeid.DataTextField = "HouseTypeName";
                ddlHouseTypeid.DataValueField = "HouseTypeId";
                ddlHouseTypeid.DataBind();
            }
            ddlHouseTypeid.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
