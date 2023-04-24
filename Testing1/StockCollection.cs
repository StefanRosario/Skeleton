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
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock ThisStock = new clsStock();

            Int32 PrimaryKey = 0;

            ThisStock.Available = true;
            ThisStock.ProductID = 7;
            ThisStock.ProductName = "SB socks";
            ThisStock.Price = 3.99m;
            ThisStock.Category = "Clothing";
            ThisStock.Description = "Rainbow SB Socks";
            ThisStock.StockCount = 30;


            AllStock.ThisStock = ThisStock;

            PrimaryKey = AllStock.Add();

            ThisStock.ProductID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStockCollection FilteredStock = new clsStockCollection();

            FilteredStock.ReportByProductName("");

            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }
           
            public void ReportByProductNameNoneFound()
        { 
            clsStockCollection FilteredStock = new clsStockCollection();


            FilteredStock.ReportByProductName("nbtee");

            Assert.AreEqual(0, FilteredStock.Count);
        }
    
            [TestMethod]
            public void ReportByProductNameFound()
        { 
            clsStockCollection FilteredStock = new clsStockCollection();

            Boolean OK = false;

            FilteredStock.ReportByProductName("SB Shoes");

            if (FilteredStock.Count == 1)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }
    }
}