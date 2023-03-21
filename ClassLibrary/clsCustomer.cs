using System;

using ClassLibrary;


    public class clsCustomer
    {
        public DateTime DateAdded { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateDated { get; set; }
        public DateTime CustomerDate { get; set; }

    public bool Find(int CustomerId)
    {

        CustomerId = 21;
       //always return true 
        return true;
    }

    public class ClsCustomer
    {
        //private data member for the address number property 
        private Int32 CustomerNo;
    }

    private Int32 CustomerNo;
    public int CustomerId
    {
        get
        {
            return CustomerId;

        }
        set
        {
            CustomerId = value;

        }
    }

}
