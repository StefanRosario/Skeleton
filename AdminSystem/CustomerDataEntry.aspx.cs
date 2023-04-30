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

    public object Phone { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsCustomer ACustomer = new clsCustomer();
        //capture Customer Id
        string FullName = FullNameTxt.Text;
        //Capture the Email
        string Email = EmailTxt.Text;
        //Capture the date Registered
        string DateRegistered = DateRegisterTxt.Text;
        //capture shipping address
        string ShippingAddress = ShippingAddressTxt.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
        if (Error == "")
        {
            //capture the CustomerId
            ACustomer.CustomerId = Convert.ToInt32(CustomerId);
            //Capture the FullName
            ACustomer.FullName = FullName;
            //Capture the Email
            ACustomer.Email = Email;
            //Capture the Phone
            ACustomer.Phone = Convert.ToInt32(Phone);
            //capture shipping address
            ACustomer.ShippingAddress = ShippingAddress;
            //Capture DAte Registered
            ACustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
        
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;

            //if this is a new record i.e. StaffID = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisStaff property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisStaff property
                CustomerList.ThisCustomer = ACustomer;
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
        clsCustomer ACustomer = new clsCustomer();
        //Variable to store the primary key
        Int32 CustomerId;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        CustomerId = Convert.ToInt32(CustomerIdTxt.Text);
        //Find the record
        Found = ACustomer.Find(CustomerId);
        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            CustomerIdTxt.Text = ACustomer.CustomerId.ToString();
            FullNameTxt.Text = ACustomer.FullName.ToString();
            EmailTxt.Text = ACustomer.Email.ToString();
            PhoneNumberTxt.Text = ACustomer.Phone.ToString();
            ShippingAddressTxt.Text = ACustomer.ShippingAddress.ToString();
            DateRegisterTxt.Text = ACustomer.DateRegistered.ToString();
            
        }

    }

    protected void BttnOk_Click(object sender, EventArgs e)
    {

    }
}