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

        public string Valid(object customerID, object orderDate, object totalCostProperty, object shippingAddress)
        {
            return "";



            
        }





    }
}
    


    

    
