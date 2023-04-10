
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{

    [TestClass]
    public class tstOrders
    {

        //good test data
        //create some test data to pass to the method
        string CostumerID = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string TotalCost = "65.00";
        string ShippingAddress = "60, Finsubry road, Leicester, LE2 6FU";



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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            //assign the data to the property
            Error = AnOrder.Valid(CostumerID, OrderDate, TotalCost, ShippingAddress);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = ""; 
            //create some test data to pass to the method
            string CustomerID = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDNoMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalCost, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }



    }

       
       

