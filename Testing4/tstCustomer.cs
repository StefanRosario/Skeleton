using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        public object AnAddress { get; private set; }
        public object Testdata { get; private set; }

        [TestMethod]
        public void InstanceOk()
        {
            //creates class that wants to be created 
            clsCustomer ACustomer = new clsCustomer();
            //tests to see if it exists 
            Assert.IsNotNull(ACustomer);


        }

        [TestMethod]
        public void CustomerDate()
        {
            //creates class that wants to be created 
            clsCustomer ACustomer = new clsCustomer();
            //create test data to assign property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to property 
            ACustomer.DateAdded = TestData;
            //test to see if two values are the same 
            Assert.AreEqual(ACustomer.DateAdded, Testdata);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //creates class instantly 
            clsCustomer ACustomer = new clsCustomer();
            //create test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            ACustomer.CustomerId = TestData;
            //test to see if the two values match 
            Assert.AreEqual(ACustomer.CustomerId.TestData);
        }


    }
}

