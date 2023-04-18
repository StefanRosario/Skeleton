using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.TotalCost = Convert.ToDecimal("65.00");
            TestOrder.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestOrder.OrderDate = Convert.ToDateTime("22/02/2023");
            TestOrder.Shipped = false;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //set ThisStaff to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //set ThisStaff to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //Update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.TotalCost = Convert.ToDecimal("65.00");
            TestItem.ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";
            TestItem.OrderDate = Convert.ToDateTime("22/02/2023");
            TestItem.Shipped = false;
            //set ThisStaff to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records);
            FilteredOrders.ReportByShippingAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a TotalCost that doesn't exist
            FilteredOrders.ReportByShippingAddress("narborough");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a TotalCost that doesn't exist
            FilteredOrders.ReportByShippingAddress("60, Finsubry road, Leicester, LE2 6FU");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredOrders.OrderList[0].OrderID != 4)
                {
                    OK = false;
                }
                //check that the first record is ID 22
                if (FilteredOrders.OrderList[1].OrderID != 22)
                {
                    OK = false;
                }

                else
                {
                    OK = false;
                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }

    }
}
