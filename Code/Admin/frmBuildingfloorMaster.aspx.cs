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

public partial class SubAdmin_frmBuildingfloorMaster : System.Web.UI.Page
{
    Cls_Buildingfloormaster objbuildingfloorMaster = new Cls_Buildingfloormaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowBuildingApprno();
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
            objbuildingfloorMaster.BuildingApprno = Convert.ToInt32(ddlBuildingApprno.SelectedValue);
            objbuildingfloorMaster.FloorNoUnique = Convert.ToInt32(ddlFloorNo.SelectedValue);
            objbuildingfloorMaster.FloorPlintharea = Convert.ToDecimal(txtPlintArea.Text);
            int i = objbuildingfloorMaster.InsertBuildingfloorMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                lblError.Text = "Sucessfully Recorded Added..";
                ClearData();
            }
            else
            {
                lblError.Text = "Record Not Inserted";
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
        lblError.Text = "";
    }
   
    public void ShowBuildingApprno()
    {

        try
        {
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
                DataSet ds = objbuildingfloorMaster.ShowFloorID(Convert.ToInt32(ddlBuildingApprno.SelectedValue));
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
    public void ClearData()
    {
        try
        {
            txtPlintArea.Text = "";
            if (ddlFloorNo.SelectedIndex != 0)
                ddlFloorNo.SelectedIndex = 0;
            if (ddlBuildingApprno.SelectedIndex != 0)
                ddlBuildingApprno.SelectedIndex = 0;
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
