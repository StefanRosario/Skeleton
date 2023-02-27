using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        private static void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
            }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnAddress.Active, TestData);
        }
        }
    }
