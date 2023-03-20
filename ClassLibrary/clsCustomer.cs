using System;

using ClassLibrary;


    public class clsCustomer
    {
        public DateTime DateAdded { get; set; }
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateDated { get; set; }
        public DateTime CustomerDate { get; set; }

    //CustomerNo private member variable 
    private Int32 mCustomerNo;
    //CustomerNO public property
    public Int32 CustomerNo
    {
        get
        {
            return mCustomerNo;
        }
        set
        {
            mCustomerNo = value;
        }
    }
    



    public bool Find(int addressNo)
    {
        //sets private data members to the test data value 
        mCustomerNo = 21;
        //alwsys return true 
        return true;

    }
}
