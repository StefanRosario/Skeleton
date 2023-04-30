using Class_Library;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestCustomer = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.Phone = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //add the item to the test list
            TestCustomer.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestCustomer);
        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestCustomer = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.Phone = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //add the item to the test list
            TestCustomer.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
            {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.Phone = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //variable stores primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.Phone = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //setThisCustomer to the test Data
            AllCustomers.ThisCustomer = TestItem;
            //add the record

            //PrimaryKey = AllCustomers.Add();

            //add the item to the test list
            TestItem.CustomerId = PrimaryKey;
            //assign the data to the property
            AllCustomers.ThisCustomer = Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        private clsCustomer Find(int primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}
