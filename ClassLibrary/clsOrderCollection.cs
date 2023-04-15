using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for this list
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                //set the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //set the private data
                return mOrderList.Count;
            }
            set
            {

            }
        }
    }
}
    
