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

public partial class SubAdmin_frmStreetMaster : System.Web.UI.Page
{
    Cls_StreetMaster objstreetmaster = new Cls_StreetMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreaId();
                ShowStreetTypeId();
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
            objstreetmaster.StreetName = txtStreetName.Text;
            objstreetmaster.StreetSpan = Convert.ToInt32(txtStreetSpan.Text);
            objstreetmaster.StreetTypeId = Convert.ToInt32(ddlStreetName.SelectedValue);
            objstreetmaster.AreaId = Convert.ToInt32(ddlAreaName.SelectedValue);
            objstreetmaster.C_M_P_Id = Convert.ToInt32(Session["EmployeeId"]);
           int i= objstreetmaster.InsertStreetMaster();
           mainpanel.Enabled = false;
           System.Threading.Thread.Sleep(2000);
           mainpanel.Enabled = true;
           if (i > 0)
           {
               Cleardata();
               lblError.Text = "Street Master Details Sucessfully Added";
           }
           else
           {
               lblError.Text = "Street Record Not Inserted";
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
    public void ShowStreetTypeId()
    {
        try
        {
            DataSet ds = objstreetmaster.ShowStreetTypeId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlStreetName.DataSource = ds.Tables[0];
                ddlStreetName.DataTextField = "StreetTypeName";
                ddlStreetName.DataValueField = "StreetTypeId";
                ddlStreetName.DataBind();
            }
            ddlStreetName.Items.Insert(0, "--SelectOne--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Cleardata()
    {
        try
        {
         
            txtStreetName.Text = "";
            txtStreetSpan.Text = "";
            if (ddlStreetName.SelectedIndex != 0)
                ddlStreetName.SelectedIndex = 0;
            if (ddlAreaName.SelectedIndex != 0)
                ddlAreaName.SelectedIndex = 0;
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
   

}
