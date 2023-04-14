using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsOrder AnOrder = new clsOrder();
        //Capture the Username 
        string CustomerID = txtCustomerID.Text;
        //Capture the Password
        string ShippingAddress = txtShippingAddress.Text;
        //Capture the Role
        string TotalCost = txtTotalCost.Text;
        //Capture the DateAdded
        string OrderDate = txtOrderDate.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AnOrder.Valid(CustomerID, ShippingAddress, TotalCost, OrderDate);
        if (Error == "")
        {
            //Capture the Username
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //Capture the Password
            AnOrder.ShippingAddress = ShippingAddress;
            //Capture the Role
            AnOrder.TotalCost = Convert.ToDecimal(TotalCost);
            //Capture DateAdded
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //Store the username in the session object
            Session["An Order"] = AnOrder;
            //Navigate to the viewer page
            Response.Redirect("OrderProcessViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalCost.Text = AnOrder.TotalCost.ToString();
            chkShipped.Checked = AnOrder.Shipped;


        }
    }


    protected void chkShipped_CheckedChanged(object sender, EventArgs e)
    {

    }
}

   
