﻿using ClassLibrary;
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
        }
    }
