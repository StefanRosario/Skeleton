using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bttnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void BttnOk_Click(object sender, EventArgs e)
    {
        
        //navigate to the viewer page 
        Response.Redirect("CustomerViewer.aspx");
        
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}