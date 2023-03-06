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
    }


}
