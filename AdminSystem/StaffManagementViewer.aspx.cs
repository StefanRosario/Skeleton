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
        //Create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //Get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //Display the username for this entry
        Response.Write(AStaff.Username);
    }
}