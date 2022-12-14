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

public partial class SubAdmin_frmLocalityMaster : System.Web.UI.Page
{
    Cls_LocalityMaster objlocalitymaster = new Cls_LocalityMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreaId();
                
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
            objlocalitymaster.LocalityName = txtLocationName.Text;
            objlocalitymaster.LocalityDesc = txtDescription.Text;
            objlocalitymaster.LocalitySpan =Convert.ToInt32(txtSpan.Text);
            objlocalitymaster.LocalityAbbr = txtAbbr.Text;
            objlocalitymaster.AreaId = Convert.ToInt32(ddlAreaName.SelectedValue);
            int i = objlocalitymaster.InsertLocalityMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Sucessfully Recorded Added";
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
        txtAbbr.Text = "";
        txtLocationName.Text = "";
        txtSpan.Text = "";

        if (ddlAreaName.SelectedIndex != 0)
            ddlAreaName.SelectedIndex = 0;
      


    }
}
