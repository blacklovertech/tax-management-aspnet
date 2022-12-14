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

public partial class SubAdmin_frmplotMaster : System.Web.UI.Page
{
    Cls_PLotMaster objplotmaster = new Cls_PLotMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreaId();
                ddlstreetid.Items.Insert(0, "--SelectOne--");
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
            objplotmaster.PlotOwnerName = txtplotownerName.Text;
            objplotmaster.TelephoneNO = txtPhoneNo.Text;
            objplotmaster.PlotDescription = txtDescription.Text;
            objplotmaster.AreaId = Convert.ToInt32(ddlareaName.SelectedValue);
            objplotmaster.StreetId = Convert.ToInt32(ddlstreetid.SelectedValue);
            objplotmaster.C_M_P_Id = Convert.ToInt32(Session["EmployeeId"]);
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            int i = objplotmaster.InsertPlotMaster();
            if (i > 0)
            {
                Cleardata();
                lblError.Text = "Plot Master Details Sucessfully Added";
            }
            else
            {
                lblError.Text = "Plot Record Not Inserted";
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
        try
        {
          
            txtDescription.Text = "";
            txtPhoneNo.Text = "";
            txtplotownerName.Text = "";
            if (ddlstreetid.SelectedIndex != 0)
                ddlstreetid.SelectedIndex = 0;
            if (ddlareaName.SelectedIndex != 0)
                ddlareaName.SelectedIndex = 0;
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
            DataSet ds = objplotmaster.ShowAreaid(Convert.ToInt32(Session["EmployeeId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlareaName.DataSource = ds.Tables[0];
                ddlareaName.DataTextField = "AreaName";
                ddlareaName.DataValueField = "AreaId";
                ddlareaName.DataBind();
            }
            ddlareaName.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void ddlareaName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlareaName.SelectedIndex != 0)
            {
                DataSet ds = objplotmaster.ShowAreaIdSelectShowStreetid(Convert.ToInt32(ddlareaName.SelectedValue));
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlstreetid.DataSource = ds.Tables[0];
                    ddlstreetid.DataTextField = "StreetName";
                    ddlstreetid.DataValueField = "StreetId";
                    ddlstreetid.DataBind();
                    ddlstreetid.Items.Insert(0, "--SelectOne--");
                }
                else
                {
                    ddlstreetid.Items.Clear();
                    ddlstreetid.Items.Insert(0, "--SelectOne--");
                }
            }
            else
            {
                ddlstreetid.Items.Clear();
                ddlstreetid.Items.Insert(0, "--SelectOne--");
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
