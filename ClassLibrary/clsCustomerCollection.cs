using Class_Library;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
        }

        public System.Collections.Generic.List<clsCustomer> CustomerList { get; set; }
        public clsCustomer ThisCustomer { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}