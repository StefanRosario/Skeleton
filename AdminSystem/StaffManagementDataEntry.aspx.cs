using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //Capture the Username and password
        AStaff.Username = txtUsername.Text;
        //Store the username in the session object
        Session["AStaff"] = AStaff;
        //Navigate to the viewer page
        Response.Redirect("StaffManagementViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}