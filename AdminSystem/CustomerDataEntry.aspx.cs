using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsCustomer ACustomer = new clsCustomer();
        //capture Customer Id
        string CustomerId = CustomerIdTxt.Text;
        //Capture the FullName 
        string FullName = FullNameTxt.Text;
        //Capture the Email
        string Email = EmailAddressTxt.Text;
        //capture Phone
        string Phone = PhoneNumberTxt.Text;
        //Capture the date Registered
        string DateRegistered = DateRegisterTxt.Text;
        //capture shipping address
        string ShippingAddress = ShippingAddressTxt.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = ACustomer.Valid(FullName, Email, Phone, DateRegistered);
        if (Error == "")
        {
            //capture the StaffID
            ACustomer.CustomerId = Convert.ToInt32(CustomerId);
            //Capture the Username
            ACustomer.FullName = FullName;
            //Capture the Password
            ACustomer.Email = Email;
            //Capture the Role
            ACustomer.Phone = Convert.ToInt32(Phone);
            //capture shipping address
            ACustomer.ShippingAddress = ShippingAddress;
            //Capture DateAdded
            ACustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
            //capture active
            
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //set the ThisStaff property
            CustomerList.ThisCustomer = ACustomer;

            //if this is a new record i.e. StaffID = -1 then add the data
            if (ACustomer == -1)
            {
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(ACustomer);
                //update the record
                CustomerList.Update();
            }

            //redirect to the staff management list page
            Response.Redirect("CustomerManagementList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Page.Request.UrlReferrer != null)
        {
            Response.Redirect(Page.Request.UrlReferrer.ToString());
        }
        else
        {
            // If there is no previous page, redirect to a default page
            Response.Redirect("CustomerDataEntry.aspx");
        }
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

    protected void BttnOk_Click(object sender, EventArgs e)
    {

    }
}