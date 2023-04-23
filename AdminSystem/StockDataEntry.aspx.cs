using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();

        Stock.ProductID = Convert.ToInt32(txtProductID.Text);
        Stock.Description = txtDescription.Text;
        Stock.ProductName = txtProductName.Text;
        Stock.Price = Convert.ToDecimal(txtPrice.Text);
        Stock.StockCount = Convert.ToInt32(txtStockCount.Text);
        Stock.Category = txtCategory.Text;
        Stock.Available = chkAvailable.Checked;

        Session["Stock"] = Stock;

        Response.Redirect("StockViewer.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();

        Int32 ProductID;

        Boolean Found = false;

        ProductID = Convert.ToInt32(txtProductID.Text);

        Found = Stock.Find(ProductID);

        if (Found == true)
        {
            txtCategory.Text = Stock.Category;
            txtDescription.Text = Stock.Description;
            txtPrice.Text = Stock.Price.ToString();
            txtProductName.Text = Stock.ProductName;
            txtStockCount.Text = Stock.StockCount.ToString();
            chkAvailable.Checked = Stock.Available;


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}