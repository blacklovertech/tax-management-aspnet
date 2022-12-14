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

public partial class SubAdmin_frmBuildingApprovalCategoryUsagaMaster : System.Web.UI.Page
{
    Cls_BuildingApprovalCategoryusageMaster objcategoryusagemaster = new Cls_BuildingApprovalCategoryusageMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowBuildingApprno();
                ShowCategoryUsagemaster();
                ddlFloorNo.Items.Insert(0, "--SelectOne--");
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
            objcategoryusagemaster.BuildingApprovalNo = Convert.ToInt32(ddlBuildingApprno.SelectedValue);
            objcategoryusagemaster.CategoryusagemasterId = Convert.ToInt32(ddlCategoryMasterId.SelectedValue);
            objcategoryusagemaster.Floorid=Convert.ToInt32(ddlFloorNo.SelectedValue);
            int i=objcategoryusagemaster.InsertBuildingApprovalCategoryUsageMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;

            if(i>0)
            {
            lblError.Text="Sucessfully Added";
                Cleardata();
            }
            else
            {
            lblError.Text="Not Added";
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
    public void ShowCategoryUsagemaster()
    {
        try
        {
            DataSet ds = objcategoryusagemaster.ShowCategoryUsageMasterId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlCategoryMasterId.DataSource = ds.Tables[0];
                ddlCategoryMasterId.DataTextField = "CategoryusageName";
                ddlCategoryMasterId.DataValueField = "CategoryusageMasterId";
                ddlCategoryMasterId.DataBind();
                ddlCategoryMasterId.Items.Insert(0, "--SelectOne--");
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        if (ddlCategoryMasterId.SelectedIndex != 0)
            ddlCategoryMasterId.SelectedIndex = 0;
        if (ddlBuildingApprno.SelectedIndex != 0)
            ddlBuildingApprno.SelectedIndex = 0;
        if (ddlFloorNo.SelectedIndex != 0)
            ddlFloorNo.SelectedIndex = 0;
    }
    public void ShowBuildingApprno()
    {

        try
        {
            Cls_Buildingfloormaster objbuildingfloorMaster = new Cls_Buildingfloormaster();
            DataSet ds = objbuildingfloorMaster.ShowBuildingApprno();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlBuildingApprno.DataSource = ds.Tables[0];
                ddlBuildingApprno.DataTextField = "BuildingApprNo";
                ddlBuildingApprno.DataValueField = "BuildingApprNo";
                ddlBuildingApprno.DataBind();
            }
            ddlBuildingApprno.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlBuildingApprno_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlBuildingApprno.SelectedIndex != 0)
            {
                Cls_Buildingfloormaster objbuildingfloorMaster = new Cls_Buildingfloormaster();
                DataSet ds = objbuildingfloorMaster.ShowFloorIDSelectApprovalCategory(Convert.ToInt32(ddlBuildingApprno.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlFloorNo.DataSource = ds.Tables[0];
                    ddlFloorNo.DataTextField = "FloorName";
                    ddlFloorNo.DataValueField = "FloorId";
                    ddlFloorNo.DataBind();
                    ddlFloorNo.Items.Insert(0, "--SelectOne--");
                }
            }
            else
            {
                ddlFloorNo.Items.Clear();
                ddlFloorNo.Items.Insert(0, "--SelectOne--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
