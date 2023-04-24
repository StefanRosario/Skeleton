using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstStockManagement
    {
        string ProductName = "SB Tee";
        string Available = "true";
        string Description = "Black SB Tee";
        string Category = "Clothing";
        string StockCount = "200";
        string Price = "24.99";

        [TestMethod]
        public void InitialiseOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            Assert.IsNotNull(Stock);
        }

        [TestMethod]

        public void AvailableOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            Boolean TestData = true;

            Stock.Active = TestData;

            Assert.AreEqual(Stock.Active, TestData);
        }

        private class clsStockManagement
        {
            public bool Active { get; internal set; }
            public int ProductId { get; internal set; }
            public int StockCount { get; internal set; }
            public string ProductName { get; internal set; }
            public string Description { get; internal set; }
            public string Category { get; internal set; }
            public decimal Price { get; internal set; }

            internal string Valid(string availableOK, string priceOK, string categoryOK, string stockCountOK, string productNameOK, string descriptionOK)
            {
                return "";
            }
        }

        public void ProductIdOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            Int32 TestData = 10045;

            Stock.ProductId = TestData;

            Assert.AreEqual(Stock.ProductId, TestData);


        }
        [TestMethod]
        public void StockCountOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            Int32 TestData = 56;

            Stock.StockCount = TestData;

            Assert.AreEqual(Stock.StockCount, TestData);

        }
        [TestMethod]
        public void ProductNameOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            string TestData = "SB Hoodie";

            Stock.ProductName = TestData;

            Assert.AreEqual(Stock.ProductName, TestData);

        }
        [TestMethod]
        public void DescriptionOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            string TestData = "Black Hoodie with embroidered SB logo";

            Stock.Description = TestData;

            Assert.AreEqual(Stock.Description, TestData);
        }
        [TestMethod]
        public void CategoryOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            string TestData = "Clothing";

            Stock.Category = TestData;

            Assert.AreEqual(Stock.Category, TestData);

        }
        [TestMethod]
        public void PriceOK()
        {

            clsStockManagement Stock = new clsStockManagement();

            decimal TestData = 34.99m;

            Stock.Price = TestData;

            Assert.AreEqual(Stock.Price, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            Error = Stock.Valid(Available, Price, Category, StockCount, ProductName, Description);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string ProductNameOK = "Extremely Large Product Name for testing XL model";

            Error = Stock.Valid(Available, Price, Category, StockCount, ProductNameOK, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string ProductNameOK = "Extremely Large Product Name for testing XXXL model";

            Error = Stock.Valid(Available, Price, Category, StockCount, ProductNameOK, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string ProductNameOK = "Extremely Large Product Name for testing XXL model";

            Error = Stock.Valid(Available, Price, Category, StockCount, ProductNameOK, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMiddle()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string ProductNameOK = "Extremely Large Product N";

            Error = Stock.Valid(Available, Price, Category, StockCount, ProductNameOK, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string PriceOK = "54.123";

            Error = Stock.Valid(Available, PriceOK, Category, StockCount, ProductName, Description);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string PriceOK = "54.1";

            Error = Stock.Valid(Available, PriceOK, Category, StockCount, ProductName, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string PriceOK = "54.12";

            Error = Stock.Valid(Available, PriceOK, Category, StockCount, ProductName, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMiddle()
        {
            clsStock Stock = new clsStock();

            String Error = "";

            string PriceOK = "545325346.12";

            Error = Stock.Valid(Available, PriceOK, Category, StockCount, ProductName, Description);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock Stock = new clsStock();

            Int32 PrimaryKey = 0;

            Stock.ProductID = 123;
            Stock.ProductName = "SB Hoodie";
            Stock.Available = true;
            Stock.Category = "Clothing";
            Stock.Description = "White SB Hoodie";
            Stock.StockCount = 75;
            Stock.Price = 54.99m;

            AllStock.ThisStock = Stock;

            PrimaryKey = AllStock.Add();

            Stock.ProductID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, Stock);
        }
    }
}


