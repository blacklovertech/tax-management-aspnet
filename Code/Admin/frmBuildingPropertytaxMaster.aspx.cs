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

public partial class SubAdmin_frmBuildingPropertytaxMaster : System.Web.UI.Page
{
    Cls_BuildingpropertyTaxMaster objbuildingpropertytaxmaster = new Cls_BuildingpropertyTaxMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
               
                UniqueHouseNO();
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
            objbuildingpropertytaxmaster.BuildingNo = Convert.ToInt32(txtBuildingApprovalNo.Text);
            objbuildingpropertytaxmaster.UniqueHouseNo = Convert.ToInt32(ddlHouseNO.SelectedValue);
            objbuildingpropertytaxmaster.PropertytaxAmount = Convert.ToDecimal(txtPropertyTaxValue.Text);
            objbuildingpropertytaxmaster.Educationtaxamt = Convert.ToDecimal(txtEducationTax.Text);
            objbuildingpropertytaxmaster.LibrarycessAmt = Convert.ToDecimal(txtLibraryCess.Text);
            objbuildingpropertytaxmaster.Uacpenalty = Convert.ToDecimal(txtPenalty.Text);
            int i = objbuildingpropertytaxmaster.InsertBuildingpropertyTaxMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;

            if (i > 0)
            {
                lblError.Text = "Sucessfully Property Details Added";
                ClearData();
            }
            else {
                lblError.Text = "Not Added..";
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
    public void ClearData()
    {
        txtEducationTax.Text = "";
        txtLibraryCess.Text = "";
        txtPenalty.Text = "";
        txtPropertyTaxValue.Text = "";
        txtBuildingApprovalNo.Text = "";
        if (ddlHouseNO.SelectedIndex != 0)
            ddlHouseNO.SelectedIndex = 0;
    }
   
    public void UniqueHouseNO()
    {
        try
        {
            Cl_MunicipalityTaxMaster objmunicipalityMaster = new Cl_MunicipalityTaxMaster();
            DataSet ds = objmunicipalityMaster.ShowUniqueHouseNO123();
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
}
