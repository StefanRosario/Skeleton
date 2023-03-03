using ClassLibrary;
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
    public void CostumerIDPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.CostumerID = TestData;
        //test to see if the 2 values are the same
        Assert.AreEqual(AnOrder.CostumerID, TestData);



    }
        [TestMethod]
        public void OrderDate()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
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
            Decimal TestData = 1;
            //assign the data to the property
            AnOrder.TotalCost = TestData;
            //test to see if the 2 values are the same
            Assert.AreEqual(AnOrder.TotalCost, TestData);

        }
        
        [TestMethod]
        public void IsShippedOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.IsEnabled = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.IsEnabled, TestData);
        }

        [TestMethod]
        public void ShippingAddresOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            string TestData = "Narborough Road";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }
    
   
       
        
    }
}
