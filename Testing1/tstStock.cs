using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        string ProductName = "SB Tee";
        string Available = "true";
        string Description = "Black SB Tee";
        string Category = "Clothing";
        string StockCount = "200";
        string Price = "24.99";
    }
    [TestClass]
    public class tstStockManagement
    {
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

            internal string Valid(Action availableOK, Action priceOK, Action categoryOK, Action stockCountOK, Action productNameOK, Action descriptionOK)
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

        public void ValidMethodOK()
        {
            clsStockManagement Stock = new clsStockManagement();

            String Error = "";

            Error = Stock.Valid(AvailableOK, PriceOK, CategoryOK, StockCountOK, ProductNameOK, DescriptionOK);

            Assert.AreEqual(Error, "");
        }
    }
}

