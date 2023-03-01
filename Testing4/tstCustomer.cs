using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            classCustomer AnCustomer = new classCustomer();
            Assert.IsNotNull(AnCustomer);
        }
    }
}
