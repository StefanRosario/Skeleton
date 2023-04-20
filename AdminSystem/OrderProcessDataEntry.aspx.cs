using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsOrder AnOrder = new clsOrder();
        //Capture the CustomerID 
        string CustomerID = txtCustomerID.Text;
        //Capture the ShippingAddress
        string ShippingAddress = txtShippingAddress.Text;
        //Capture the TotalCost
        string TotalCost = txtTotalCost.Text;
        //Capture the OrderDate
        string OrderDate = txtOrderDate.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AnOrder.Valid(CustomerID, ShippingAddress, TotalCost, OrderDate);
        if (Error == "")
        {
            //capture the StaffID
            AnOrder.OrderID = OrderID;
            //Capture the Username
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //Capture the Password
            AnOrder.ShippingAddress = ShippingAddress;
            //Capture the Role
            AnOrder.TotalCost = Convert.ToDecimal(TotalCost);
            //Capture DateAdded
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture active
            AnOrder.Shipped = chkShipped.Checked;
            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();


            //if this is a new record i.e. StaffID = -1 then add the data
            if (OrderID == -1)
            {
                //set the ThisStaff property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderProcessList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (Page.Request.UrlReferrer != null)
        {
            Response.Redirect(Page.Request.UrlReferrer.ToString());
        }
        else
        {
            // If there is no previous page, redirect to a default page
            Response.Redirect("OrderProcessDataEntry.aspx");

        }
    }
}

   
