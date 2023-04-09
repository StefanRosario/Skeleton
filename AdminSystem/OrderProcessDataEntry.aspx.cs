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
        //create new insatance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the OrderID
        AnOrder.ShippingAddress = txtShippingAddress.Text;



        //Store Order int the session Object
        Session["An Order"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderProcessViewer.aspx");

        {

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

   
