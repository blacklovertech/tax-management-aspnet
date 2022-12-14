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

public partial class SubAdmin_frmEditHouseMaster : System.Web.UI.Page
{
    Cls_HousesMaster objhousemaster = new Cls_HousesMaster();
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
            objhousemaster.UniQueHousNo = Convert.ToInt32(ddlActualNO.SelectedValue);
            objhousemaster.OwnerName = txtOwnerName.Text;
            objhousemaster.TelephonNo = txttelephoneno.Text;
            objhousemaster.Email = txtEmailid.Text;
            int i = objhousemaster.UpdateHOuseMasterdetails();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                lblError.Text = "Sucessfully Recorded Modifie..";
                Cleardata();
            }
            else
            {
                lblError.Text = "Not Modifie..";
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
    public void UniqueHouseNO()
    {
        try
        {
            Cl_MunicipalityTaxMaster objmunicipalityMaster = new Cl_MunicipalityTaxMaster();
            DataSet ds = objmunicipalityMaster.ShowUniqueHouseNO();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlActualNO.DataSource = ds.Tables[0];
                ddlActualNO.DataTextField = "ActualHouseNo";
                ddlActualNO.DataValueField = "UniQueHousNo";
                ddlActualNO.DataBind();
            }
            ddlActualNO.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlActualNO_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlActualNO.SelectedIndex != 0)
            {
                DataSet ds = objhousemaster.ShowHOusedetailsSelectId(Convert.ToInt32(ddlActualNO.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtEmailid.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtOwnerName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txttelephoneno.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                
                }
            }

        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        txtEmailid.Text = "";
        txtOwnerName.Text = "";
        txttelephoneno.Text = "";
        if (ddlActualNO.SelectedIndex != 0)
            ddlActualNO.SelectedIndex = 0;
    }
}
