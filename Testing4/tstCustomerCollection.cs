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
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
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
            clsCustomer TestCustomer = new clsCustomer();
            //add an item to the list
            //set its properties
            TestCustomer.CustomerId = 1;
            TestCustomer.FullName = "Test FullName";
            TestCustomer.Email = "Test Email";
            TestCustomer.PhoneNumber = Convert.ToInt32("12345678");
            TestCustomer.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestCustomer.ShippingAddress = "Test ShippingAddress";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
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
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
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
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //setThisCustomer to the test Data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //set ThisStaff to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test data
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
           clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FullName = "Test FullName";
            TestItem.Email = "Test Email";
            TestItem.PhoneNumber = Convert.ToInt32("12345678");
            TestItem.DateRegistered = Convert.ToDateTime("01/02/2030");
            TestItem.ShippingAddress = "Test ShippingAddress";
            //set ThisStaff to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //finding record
            TestItem.CustomerId = PrimaryKey;
            //set the primary key of the test data
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByShippingAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //apply a Role that doesn't exist
            FilteredCustomers.ReportByShippingAddress("Rizz");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Role that doesn't exist
            FilteredCustomers.ReportByEmail("24 Rizz st");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCustomers.CustomerList[0].CustomerId != 4)
                {
                    OK = false;
                }
                //check that the first record is ID 22
                if (FilteredCustomers.CustomerList[1].CustomerId != 22)
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
