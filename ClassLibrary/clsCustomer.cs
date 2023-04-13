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

        //set private data members to test data value 
        mCustomerNo = 21;
        DateTime CustomerAdded = Convert.ToDateTime("16/9/2015");
        //always return true 
        return true;
    }

    public class ClsCustomer
    {
        //private data member for the address number property 
        private Int32 mCustomerNo;
    }

    private Int32 CustomerNo;
    private int mCustomerNo;

    public Int32 CustomerId
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

    private DateTime mCustomerAdded;
    public DateTime DateAdd
    {
        get
        {
            return mCustomerAdded;
        }

        set
        {
            mCustomerAdded = value;
        }
    }

}