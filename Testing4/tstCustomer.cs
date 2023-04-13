using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TstCustomer
    {
        public object DataTime { get; private set; }

        [TestMethod]
        public void ClassCustomerInstanceOk()
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
            Assert.AreEqual(ACustomer.DateAdded, TestData);
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
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]

        public void FullName()
        {
            //creates class instantly 
            clsCustomer ACustomer = new clsCustomer();
            //creates test data to assign to property 
            String TestData = "Duke Dennis";
            //assign the data to the property
            ACustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FullName, TestData);
        }

        [TestMethod]

        public void EmailAddress()
        {
            //create class instantly 
            clsCustomer ACustomer = new clsCustomer();
            //create test data to assign to property 
            string TestData = "DK@my365.dmu.ac.uk";
            //assign the data to the property
            ACustomer.EmailAddress = TestData;
            //determine if both values match 
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]

        public void ShippingAddress()
        {
            //creates class instantly 
            clsCustomer ACustomer = new clsCustomer();
            //create test data to assign to property
            string TestData = "24 Rizz st";
            //assign the data to the property 
            ACustomer.ShippingAddress = TestData;
            //determine if both values match 
            Assert.AreEqual(ACustomer.ShippingAddress, TestData);
        }

        [TestMethod]

        public void DateRegistered()
        {
            clsCustomer AnOrder = new clsCustomer();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.CustomerDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerDate, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerNo = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerNo);
            //Check the Customerid
            if (ACustomer.CustomerId != 21)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(Found);
        }
            
        public void TestCustomerNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable records if datas data is ok
            Boolean OK = true;
            //create test data to use in the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //checks address no.
            if (ACustomer.CustomerId != 21)
            {

                OK = false;

            }
            //test to see if results correct 
            Assert.IsTrue(OK);
        }

        
    }
}