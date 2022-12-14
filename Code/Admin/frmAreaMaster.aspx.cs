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

public partial class SubAdmin_frmAreaMaster : System.Web.UI.Page
{
    Cls_AreaMaster objareamaster = new Cls_AreaMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ShowAreatypeId();
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
            objareamaster.AreaName = txtAreaName.Text;
            objareamaster.AreaSpan = Convert.ToDecimal(txtAreaSpan.Text);
            objareamaster.AreaTypeId = Convert.ToInt32(ddlAreaTypeName.Text);
            objareamaster.AreaIdentifiedDate = Convert.ToDateTime(txtDate.Text);
            objareamaster.C_M_P_Id = Convert.ToInt32(Session["EmployeeId"]);

            ProcessPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            ProcessPanel.Enabled = true;
           int i= objareamaster.InsertAreamaster();
           if (i > 0)
           {
               Cleardata();
               lblError.Text = "Area Master Details Sucessfully Added";
           }
           else
           {
               lblError.Text = "Area Record Not Inserted";
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
        lblError.Text="";
    }
    public void ShowAreatypeId()
    {
        try
        {
            DataSet ds = objareamaster.ShowAreatypeid();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlAreaTypeName.DataSource = ds.Tables[0];
                ddlAreaTypeName.DataTextField = "AreaTypeName";
                ddlAreaTypeName.DataValueField = "AreaTypeId";
                ddlAreaTypeName.DataBind();
            }
            ddlAreaTypeName.Items.Insert(0, "--SelectOne--");
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
            txtAreaName.Text = "";
            txtAreaSpan.Text = "";
            txtDate.Text = "";
            if (ddlAreaTypeName.SelectedIndex != 0)
                ddlAreaTypeName.SelectedIndex = 0;
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
