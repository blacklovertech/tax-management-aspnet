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

public partial class SubAdmin_frmMunicipalitytaxmaster : System.Web.UI.Page
{
    Cl_MunicipalityTaxMaster objmunicipalityMaster = new Cl_MunicipalityTaxMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                LocalityId();
                UniqueHouseNO();
                
                Revenuecirclename();
               // RevenueBlockname();
                ddlBlockName.Items.Insert(0, "--SelectOne--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }

    private void Revenuecirclename()
    {
        try
        {
            DataSet ds = Cls_revenueCircleMaster.ShowRevenuecircleId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlRevenueCircleName.DataSource = ds.Tables[0];
                ddlRevenueCircleName.DataTextField = "RevenueCircleName";
                ddlRevenueCircleName.DataValueField = "RevenueCircleid";
                ddlRevenueCircleName.DataBind();          
            }
            ddlRevenueCircleName.Items.Insert(0, "--SelectOne--");

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    private void RevenueBlockname()
    {
        try
        {
            DataSet ds = Cls_revenueCircleMaster.ShowRevenueBlockId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlBlockName.DataSource = ds.Tables[0];
                ddlBlockName.DataTextField = "RevenueBlockName";
                ddlBlockName.DataValueField = "RevenueBlockId";
                ddlBlockName.DataBind();
                ddlBlockName.Items.Insert(0, "--SelectOne--");
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
            objmunicipalityMaster.UniqueHouseNo = Convert.ToInt32(ddlHouseNO.SelectedValue);
            objmunicipalityMaster.TaxAssenmentNo =Convert.ToInt32( txtAssenmentNo.Text);
            objmunicipalityMaster.LocalityId = Convert.ToInt32(ddlLocalityName.SelectedValue);
            objmunicipalityMaster.BuildingApprovalNo = Convert.ToInt32(txtBuildingApprovalNo.Text);
            objmunicipalityMaster.NoOfFlower = Convert.ToInt32(txtNoofFloors.Text);
            objmunicipalityMaster.PropetyTaxvalue = Convert.ToDecimal(txtPropertyTaxValue.Text);
            objmunicipalityMaster.EducationTaxValue = Convert.ToDecimal(txtEducationTax.Text);
            objmunicipalityMaster.LibraryCess = Convert.ToDecimal(txtEducationTax.Text);
            objmunicipalityMaster.UacPenalty = Convert.ToInt32(txtPenalty.Text);
            objmunicipalityMaster.MunicipalityorpanchayatorcorporatioNo =Convert.ToInt32(Session["Municipality"]);
            objmunicipalityMaster.RevenueCircleId = Convert.ToInt32(ddlRevenueCircleName.SelectedValue);
            objmunicipalityMaster.RevenueBlockId = Convert.ToInt32(ddlBlockName.SelectedValue);
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objmunicipalityMaster.InsertMunicipalityTaxMaster();
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Sucessfully Municipality Tax Master Details Added";
            }
            else
            {
                lblError.Text = "Error Process Try Again....";
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
 
    public void Cleardata()
    {
        txtAssenmentNo.Text = "";
        txtEducationTax.Text = "";
        txtLibraryCess.Text = "";
        txtNoofFloors.Text = "";
        txtPenalty.Text = "";
        txtPropertyTaxValue.Text = "";
        txtBuildingApprovalNo.Text = "";
        if (ddlHouseNO.SelectedIndex != 0)
            ddlHouseNO.SelectedIndex = 0;
        if (ddlLocalityName.SelectedIndex != 0)
            ddlLocalityName.SelectedIndex = 0;
        if (ddlRevenueCircleName.SelectedIndex != 0)
            ddlRevenueCircleName.SelectedIndex = 0;
        if (ddlBlockName.SelectedIndex != 0)
            ddlBlockName.SelectedIndex = 0;
        lblError.Text = "";
       

    }
    public void UniqueHouseNO()
    {
        try
        {
            DataSet ds = objmunicipalityMaster.ShowUniqueHouseNO1();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlHouseNO.DataSource = ds.Tables[0];
                ddlHouseNO.DataTextField = "ActualHouseNo";
                ddlHouseNO.DataValueField = "UniQueHousNo";
                ddlHouseNO.DataBind();          
            }
            ddlHouseNO.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void LocalityId()
    {
        try
        {
            DataSet ds = objmunicipalityMaster.ShowLocalityId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlLocalityName.DataSource = ds.Tables[0];
                ddlLocalityName.DataTextField = "LocalityName";
                ddlLocalityName.DataValueField = "LocalityId";
                ddlLocalityName.DataBind();
            }
            ddlLocalityName.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
   

    protected void ddlRevenueCircleName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlRevenueCircleName.SelectedIndex != 0)
            {
                ddlBlockName.Items.Clear();
                DataSet ds = Cls_HousesMaster.SelectRevenuCircleId(Convert.ToInt32(ddlRevenueCircleName.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlBlockName.DataSource = ds.Tables[0];
                    ddlBlockName.DataTextField = "RevenueBlockName";
                    ddlBlockName.DataValueField = "RevenueBlockId";
                    ddlBlockName.DataBind();
                    ddlBlockName.Items.Insert(0, "--SelectOne--");
                }
                else
                {
                    ddlBlockName.Items.Insert(0, "--SelectOne--");
                 //   txtBuildingApprovalNo.Text = "";
                }
            }
           
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlHouseNO_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlHouseNO.SelectedIndex != 0)
            {
                DataSet ds = Cls_HousesMaster.ShowBuildingApprovalNOSelectHouseno(Convert.ToInt32(ddlHouseNO.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtBuildingApprovalNo.Text = ds.Tables[0].Rows[0][13].ToString();
                }
                else
                {
                    txtBuildingApprovalNo.Text = "";
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlBlockName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
