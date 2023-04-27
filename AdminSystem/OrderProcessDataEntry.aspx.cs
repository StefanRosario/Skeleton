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
        //get the number of the Staffs to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();

        OrderBook.ThisOrder.Find(OrderID);

        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtTotalCost.Text = OrderBook.ThisOrder.TotalCost.ToString();
        txtShippingAddress.Text = OrderBook.ThisOrder.ShippingAddress;
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        chkShipped.Checked = OrderBook.ThisOrder.Shipped;


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
            //capture the OrderID
            AnOrder.OrderID = OrderID;
            //Capture the CustomerID
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //Capture the ShippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //Capture the TotalCost
            AnOrder.TotalCost = Convert.ToDecimal(TotalCost);
            //Capture OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture Shipped
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




   
