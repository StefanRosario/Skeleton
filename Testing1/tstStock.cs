using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Testing1
{
    [TestClass]
    public class tstStockManagement
    {
        [TestMethod]
        public void AvailableOK()
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

            clsStockManagement Stock = new clsStockManagement

            string TestData = "Black Hoodie with embroidered SB logo";

            Stock.Description = TestData;

            Assert.AreEqual(Stock.Description, TestData);
        }
        [TestMethod]
        public void CatergoryOK()
        {

            clsStockManagement Stock = new clsStockManagement

            string TestData = "Clothing";

            Stock.Catergory = TestData;

            Assert.AreEqual(Stock.Catergory, TestData);

        }
        [TestMethod]
        public void PriceOK()
        {

            clsStockManagement Stock = new clsStockManagement

            decimal TestData = 34.99;

            Stock.Price = TestData;

            Assert.AreEqual(Stock.Price, TestData);
        }
    }
}

