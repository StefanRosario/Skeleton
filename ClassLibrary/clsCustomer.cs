using System;
using System.Collections.Generic;

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

        private Int32 mPhone;
        public Int32 PhoneNumber
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

        public string Phone { get; set; }

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_CustomerManagement_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }

        }

        public string Valid(string FullName, string Email, string ShippingAddress, string DateRegistered)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Username is blank
            if (FullName.Length == 0)
            {
                //record the error
                Error = Error + "The Username may be blank : ";
            }
            //if the Username is greater than 50 characters
            if (FullName.Length > 50)
            {
                //record the error
                Error = Error + "The Username must be less than 50 characters : ";
            }

            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateRegistered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the Password blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The Password may be blank : ";
            }
            //if the Password is too long
            if (Email.Length > 50)
            {
                //record the error
                Error = Error + "The Password must be less than 50 characters : ";
            }
            //is the Role blank
            if (ShippingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Shipping Address may be blank ; ";
            }
            //if the Role is too long
            if (ShippingAddress.Length > 60)
            {
                Error = Error + "The Shipping Address must be less than 60 characters : ";
            }
            //return any error messages
            return Error;
        }

        public static implicit operator List<object>(clsCustomer v)
        {
            throw new NotImplementedException();
        }
    } 
 }
