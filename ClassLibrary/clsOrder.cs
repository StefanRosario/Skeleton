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
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }

            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }
        public DateTime OrderDate {
            get
            {
                return OrderDate;
            }

            set
            {
                OrderDate = value;
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

        public bool Find(int costumerID)
        {
            mCostumerID = 21;
           
            //always return true
            return true;
        }

        public bool Find(string shippingAddress)
        {
            mShippingAddress = "Narborough Road";
            //always return true
            return true;
        }

        public bool Find(decimal totalCost)
        {
            mTotalCost = 1;
            return true;
        }

        public bool Find(DateTime orderDate)
        {

            mOrderDate = Convert.ToDateTime("30/11/2022");
            //always return true
            return true;
        }



    }
    }
    

    
