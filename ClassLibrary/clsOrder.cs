using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address no property
        private Int32 mCustomerID;
        private string mShippingAddress;
        private DateTime mOrderDate;
        private decimal mTotalCost;
        private Boolean mShipped;
        private Int32 mOrderID;





        public clsOrder()
        {
        }

        public int OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }

            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }

            set
            {
                mOrderDate = value;
            }
        }
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
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }
        public decimal TotalCost
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalCost;
            }

            set
            {
                //this line of code allows data into the property
                mTotalCost = value;
            }
        }
        public bool Shipped
        {
            get
            {
                //this line of code sends data out of the property
                return mShipped;
            }

            set
            {
                //this line of code allows data into the property
                mShipped = value;
            }
        }

        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_OrderProcess_FilterByOrderID");

            if (DB.Count == 1)
            {

                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalCost = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalCost"]);
                mShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipped"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string CustomerID, string OrderDate, string TotalCost, string ShippingAddress)
        {
            String Error = "";
            DateTime DateTemp;
            if (CustomerID.Length == 0)
            {
                Error = Error + "The customerID may not be blank : ";


            }


            if (CustomerID.Length > 50)
            {
                Error = Error + "The customerID must be less than 50 characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
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
                //return any error messages
                 Error = Error + "The date is not a valid date : ";
            }
            //is the Password blank
            if (TotalCost.Length == 0)
            {
                //record the error
                Error = Error + "The total cost may be blank : ";
            }
            //if the Password is too long
            if (TotalCost.Length > 50)
            {
                //record the error
                Error = Error + "The Total Cost must be less than 50 characters : ";
            }
            //is the Role blank
            if (ShippingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The shipping address may  be blank ; ";
            }
            //if the Role is too long
            if (ShippingAddress.Length > 50)
            {
                Error = Error + "The ShippingAddress must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}



