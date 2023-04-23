using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Collections.Generic;


namespace TestingStock
{
    [TestClass]
    public class StockCollection
    {
        [TestMethod]
        public void TestMethod1() { }

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.ProductID = 2;
            TestItem.ProductName = "SB Beanie";
            TestItem.Price = 12.99m;
            TestItem.Category = "Clothing";
            TestItem.Description = "Red SB Beanie";
            TestItem.StockCount = 150;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock ThisStock = new clsStock();

            ThisStock.Available = true;
            ThisStock.ProductID = 2;
            ThisStock.ProductName = "SB Beanie";
            ThisStock.Price = 12.99m;
            ThisStock.Category = "Clothing";
            ThisStock.Description = "Red SB Beanie";
            ThisStock.StockCount = 150;


            AllStock.ThisStock = ThisStock;

            Assert.AreEqual(AllStock.ThisStock, ThisStock);


        }
    }
}