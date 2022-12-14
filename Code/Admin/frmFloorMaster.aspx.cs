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

public partial class SubAdmin_frmFloorMaster : System.Web.UI.Page
{
    Cls_FloorMaster objfloormaster = new Cls_FloorMaster();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            objfloormaster.FloorId = Convert.ToInt32(txtFloorNo.Text);
            objfloormaster.FloorName = txtFloorName.Text;
            objfloormaster.FloorDescription = txtDescription.Text;
            int i = objfloormaster.InsertFloorMaster();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                lblError.Text = "Sucessfully Floor Details Added.";
                ClearData();
            }
            else
            {
                lblError.Text = "Not Added...";
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
        txtDescription.Text = "";
        txtFloorName.Text = "";
        txtFloorNo.Text = "";
    }
}
