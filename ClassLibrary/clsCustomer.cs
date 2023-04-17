using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library

{


    public class clsCustomer
    {
        private bool mActive;
        private int mCustomerNo;


        //private data member for active 
        private bool Active
        {
            get
            {
                //return private data 
                return mActive;
            }
            set
            {
                //set private data 
                mActive = value;
            }
        }

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

        private String mFName;
        public String FName
        {
            get
            {
                return mfName;


            }
            set
            {
                //set value of private data memer
                FName = value;
            }
        }

        private string mEmail;
        private string mfName;

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

        private string mDateRegistered;

        public string DateRegistered
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
        public string FullName { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}