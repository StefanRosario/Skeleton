using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new insatance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the OrderID
        AnOrder = (clsOrder) Session ["An Order"];
        
        //navigate to the viewer page
        Response.Write(AnOrder.ShippingAddress);
        
              
        }   
    }

