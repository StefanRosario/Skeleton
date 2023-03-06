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
        //Create a new instance of clsAddress
        clsAddress AnAddress = new clsAddress();
        //Get the data from the session object
        AnAddress = (clsAddress)Session["AnAddress"];
        //Display the house number for this entry
        Response.Write(AnAddress.HouseNo);
    }
}