using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        Stock.ThisStock.Find(ProductID);

        txtProductID.Text = Stock.ThisStock.ProductID.ToString();
        txtProductName.Text = Stock.ThisStock.ProductName.ToString();
        chkAvailable.Checked = Stock.ThisStock.Available;
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtStockCount.Text = Stock.ThisStock.StockCount.ToString();
        txtDescription.Text = Stock.ThisStock.Description.ToString();
        txtCategory.Text = Stock.ThisStock.Category.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();

        string ProductId = txtProductID.Text;
        string Description = txtDescription.Text;
        string ProductName = txtProductName.Text;
        string Price = txtPrice.Text;
        string StockCount = txtStockCount.Text;
        string Category = txtCategory.Text;
        string Available = chkAvailable.Checked.ToString();

        string Error = "";
        Error = Stock.Valid(Available, Price, Category, StockCount, ProductName, Description);
        if (Error == "")
        {
            Stock.ProductID = Convert.ToInt32(txtProductID.Text);
            Stock.Description = txtDescription.Text;
            Stock.ProductName = txtProductName.Text;
            Stock.Price = Convert.ToDecimal(txtPrice.Text);
            Stock.StockCount = Convert.ToInt32(txtStockCount.Text);
            Stock.Category = txtCategory.Text;
            Stock.Available = chkAvailable.Checked;

            clsStockCollection StockList = new clsStockCollection();

            if (ProductID == -1)
            {
                StockList.ThisStock = Stock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(ProductID);
                StockList.ThisStock = Stock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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