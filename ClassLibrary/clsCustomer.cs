using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsCustomer
    {
     
        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;


            }
            set
            {
                //set value of private data memer
                mCustomerId = value;
            }
        }

        private String mFullName;
        public String FullName
        {
            get
            {
                return mFullName;


            }
            set
            {
                //set value of private data memer
                mFullName = value;
            }
        }


        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;


            }
            set
            {
                //set value of private data memer
                mEmail = value;
            }
        }

        public string Valid(string fullName, string email, string dateRegistered)
        {
            throw new NotImplementedException();
        }

        public string Valid(string fullName, string email, string phone, string dateRegistered)
        {
            throw new NotImplementedException();
        }

        private Int32 mPhone;
        public Int32 Phone
        {
            get
            {
                return mPhone;


            }
            set
            {
                //set value of private data memer
                mPhone = value;
            }
        }

        private string mShippingAddress;

        public string ShippingAddress
        {
            get
            {
                return mShippingAddress;

            }
            set
            {
                mShippingAddress = value;
            }
        }

        private DateTime mDateRegistered;

        public DateTime DateRegistered
        {
            get
            {
                return mDateRegistered;
            }
            set
            {
                mDateRegistered = value;
            }
        }

        public DateTime CustomerDate { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int CustomerId)
        {
            //set the private data members to the test data value
            mCustomerId = Convert.ToInt32("32");
            mFullName = "Duke Dennis";
            mEmail = " D@my365.dmu.ac.uk";
            mPhone = Convert.ToInt32("88356201");
            mShippingAddress = "24 rizz st";
            mDateRegistered = Convert.ToDateTime("16/9/2015");
            //always return true
            return true;

        }

        public void Find(clsCustomer aCustomer)
        {
            throw new NotImplementedException();
        }
    }
}