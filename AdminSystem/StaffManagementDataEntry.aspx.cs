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

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Find_Click(object sender, EventArgs e)
    {
        //Create am instance of the address class
        clsStaff AStaff = new clsStaff();
        //Variable to store the primary key
        Int32 StaffID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //Find the record
        Found = AStaff.Find(StaffID);
        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtUsername.Text = AStaff.Username;
            txtPassword.Text = AStaff.Password;
            txtRole.Text = AStaff.Role;
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            chkActive.Checked = AStaff.Active;
        }
    }

    protected void txtUsername_TextChanged(object sender, EventArgs e)
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
}
