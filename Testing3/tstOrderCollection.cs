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
    }
}
