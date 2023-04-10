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
        //Capture the Username 
        string Username = txtUsername.Text;
        //Capture the Password
        string Password = txtPassword.Text;
        //Capture the Role
        string Role = txtRole.Text;
        //Capture the DateAdded
        string DateAdded = txtDateAdded.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AStaff.Valid(Username, Password, Role, DateAdded);
        if (Error == "")
        {
            //Capture the Username
            AStaff.Username = Username;
            //Capture the Password
            AStaff.Password = Password;
            //Capture the Role
            AStaff.Role = Role;
            //Capture DateAdded
            AStaff.DateAdded = Convert.ToDateTime(DateAdded);
            //Store the username in the session object
            Session["AStaff"] = AStaff;
            //Navigate to the viewer page
            Response.Redirect("StaffManagementViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
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
            txtStaffID.Text = AStaff.StaffID.ToString();
            txtUsername.Text = AStaff.Username.ToString();
            txtPassword.Text = AStaff.Password.ToString();
            txtRole.Text = AStaff.Role.ToString();
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            chkActive.Checked = AStaff.Active;
        }

    }
}
