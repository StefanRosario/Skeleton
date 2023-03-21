using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        private static void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
            }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            string TestData = "johnsmith";
            //assign the data to the property
            AStaff.Username = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            string TestData = "password123";
            //assign the data to the property
            AStaff.Password = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Password, TestData);
        }

        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            string TestData = "Manager";
            //assign the data to the property
            AStaff.Role = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.Role, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateAdded = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void IsAuthorizedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AStaff.IsEnabled = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStaff.IsEnabled, TestData);
        }
        
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 21;
            String Username = "johnsmith";
            String Password = "password123";
            String Role = "Manager";
            //invoke the method
            Found = AStaff.Find(StaffID);
            Found = AStaff.Find(Username);
            Found = AStaff.Find(Password);
            Found = AStaff.Find(Role);
 
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the address no
            if (AStaff.StaffID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String Username = "johnsmith";
            //invoke the method
            Found = AStaff.Find(Username);
            //check the property
            if (AStaff.Username != Username)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String Password = "password123";
            //invoke the method
            Found = AStaff.Find(Password);
            //check the property
            if (AStaff.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String Role = "Manager";
            //invoke the method
            Found = AStaff.Find(Role);
            //check the property
            if (AStaff.Role != Role)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        


    }


}

