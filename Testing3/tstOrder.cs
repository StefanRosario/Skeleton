﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);

        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see if the 2 values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);



        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see if the 2 values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);



        }
        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = Convert.ToDateTime("22/02/2023");
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Decimal TestData = Convert.ToDecimal(65.00);
            //assign the data to the property
            AnOrder.TotalCost = TestData;
            //test to see if the 2 values are the same
            Assert.AreEqual(AnOrder.TotalCost, TestData);

        }

        [TestMethod]
        public void ShippedOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = false;
            //assign the data to the property
            AnOrder.Shipped = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Shipped, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            string TestData = "60, Finsubry road, Leicester, LE2 6FU";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //assign the data to the property
            Int32 OrderID = 1;
            


            //invoke the method
            Found = AnOrder.Find(OrderID);
          


            //test to see if the two values are the same
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.ShippingAddress != "60, Finsubry road, Leicester, LE2 6FU")
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCostFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.TotalCost != Convert.ToDecimal(65.00))
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }

        
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestShippedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.Shipped != false)
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            //boolean variable to record if data OK
            Boolean OK = true;
            //assign the data to the property
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Costumer ID
            if (AnOrder.OrderDate != Convert.ToDateTime("22/02/2023"))
            {
                OK = false;
            }
            //test to see if the two values are the same
            Assert.IsTrue(OK);
        }


    }
}

       
       

