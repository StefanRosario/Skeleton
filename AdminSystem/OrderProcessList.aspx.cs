using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
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
        //create an instance of the Staff Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of Staffs in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data firld to display
        lstOrderList.DataTextField = "CustomerID";
        //bind the data to the list
        lstOrderList.DataBind();

    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderProcessDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderProcessDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value 
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderProcessConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff Collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to disply
        lstOrderList.DataTextField = "TotalCost";
        //bind the data to the list
        lstOrderList.DataBind();

    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff Collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress("");
        //clear any existing filter to tidy up the interface;
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to disply
        lstOrderList.DataTextField = "ShippingAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}



        