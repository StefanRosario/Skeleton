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
        AnOrder.ShippingAddress = txtShppingAddress.Text;
        //Store Order int the session Object
        Session["An Order"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderProcessViewer.aspx");
    
        {

        }
    }
}
   
