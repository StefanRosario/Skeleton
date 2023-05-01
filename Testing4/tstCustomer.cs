using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TstCustomer
    {
        string FullName = "Duke Dennis";
        string Email = "DK@my365.dmu.ac.uk";
        string ShippingAddress = "24 Rizz st";
        string DateRegistered = DateTime.Now.Date.ToString();

        [TestMethod]
        private static void ClassCustomerInstanceOk()
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
            ACustomer.DateRegistered = TestData;
            //test to see if two values are the same 
            Assert.AreEqual(ACustomer.DateRegistered, TestData);
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

        public void FullNameIdPropertyOK()
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

        public void EmailIdPropertyOK()
        {
            //create class instantly 
            clsCustomer ACustomer = new clsCustomer();
            //create test data to assign to property 
            string TestData = "DK@my365.dmu.ac.uk";
            //assign the data to the property
            ACustomer.Email = TestData;
            //determine if both values match 
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]

        public void ShippingAddressIdPropertyOK()
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

        public void DateRegisteredIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateRegistered = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.DateRegistered, TestData);

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
            Int32 CustomerId = 1;
            //Invoke the method
            Found = ACustomer.Find(CustomerId);
            //Check the Customerid
            //Test to see if the result is correct
            Assert.IsTrue(Found);
        }

        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable records if datas data is ok
            Boolean OK = true;
            //create test data to use in the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //checks address no.
            if (ACustomer.CustomerId != 21)
            {

                OK = false;

            }
            //test to see if results correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.FullName != "Test FullName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.PhoneNumber != Convert.ToInt32("Test Phone"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public  void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.ShippingAddress != "24 Rizz st")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateRegisteredFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.DateRegistered != Convert.ToDateTime("02/04/2026"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
                                    //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNamePLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
                                    //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaa"; //this should be ok
                                      //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            FullName = FullName.PadRight(51, 'a'); //this should fail
                                                   //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            FullName = FullName.PadRight(500, 'a'); //this should fail
                                                    //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaa"; //this should be ok
                                        //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaa"; //this should be ok
                                     //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatRegisteredInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "Duke Dennis";
            string Email = "DK@my365.dmu.ac.uk";
            string ShippingAddress = "24 Rizz st";
            //set the DateAdded to a non date value
            string DateRegistered = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "a";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void EmailMinPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateRegistered = "aa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string Email = "";//this should be ok 
            Email = Email.PadRight(49, 'a'); 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string Email = "aaaaaa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string Email = "aaaa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string Email = "aaaaaaaaaa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            FullName = FullName.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change date to whenever to a string variable 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateRegistered = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailInvaidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "Duke Dennis";
            string Email = "DK@my365.dmu.ac.uk";
            string ShippingAddress = "24 Rizz st";
            //set the DateRegistered to a non date value
            string DateRegistered = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {

            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some data to pass to method
            string ShippingAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddresslMinPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string ShippingAddress = "aa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string ShippingAddress = "aaaa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //creates test data to pass to method 
            string ShippingAddress = "aaaaaa";//should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to method 
            string ShippingAddress = "aaa";//this should be ok 
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddresslMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string ShippingAddress = ""; 
            ShippingAddress = ShippingAddress.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            FullName = FullName.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(FullName, Email, ShippingAddress, DateRegistered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
