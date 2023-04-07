using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address no property
        private Int32 mCostumerID;
        private string mShippingAddress;
        private DateTime mOrderDate;
        private decimal mTotalCost;
        private Boolean mIsShipped;
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
        public int CostumerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCostumerID;
            }

            set
            {
                //this line of code allows data into the property
                mCostumerID = value;
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
        public bool IsEnabled
        {
            get
            {
                //this line of code sends data out of the property
                return mIsShipped;
            }

            set
            {
                //this line of code allows data into the property
                mIsShipped = value;
            }
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcess_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCostumerID = Convert.ToInt32(DB.DataTable.Rows[0]["CostumerID"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mTotalCost = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalCost"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mIsShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["Shipped"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }


        }

        
    }
}
    

    
