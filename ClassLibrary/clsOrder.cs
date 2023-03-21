using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the address no property
        private Int32 mCostumerID;
        private string mShippingAddress;
        
        


        public clsOrder()
        {
        }

        public int OrderID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime OrderDate { get; set; }
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
        public decimal TotalCost { get; set; }
        public bool IsEnabled { get; set; }

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
    }
}