using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _4Viewer: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();

        Stock = (clsStock)Session["Stock"];

        Response.Write(Stock.ProductID);
        Response.Write(Stock.Description);
        Response.Write(Stock.Available);
        Response.Write(Stock.Price);
        Response.Write(Stock.StockCount);
        Response.Write(Stock.ProductName);
        Response.Write(Stock.Category);
    }
}