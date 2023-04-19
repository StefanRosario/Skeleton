using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for this list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisStaff
        clsOrder mThisOrder = new clsOrder();

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
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }
              void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalCost"]);
                AnOrder.Shipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["Shipped"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);

                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_OrderProcess_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record ot the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Shipped", mThisOrder.Shipped);
            //execute the query returning the primary key value
            return DB.Execute("sproc_OrderProcess_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values op ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prodecure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Shipped", mThisOrder.Shipped);
            //execute the stored procedure
            DB.Execute("sproc_OrderProcess_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_OrderProcess_Delete");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the record based on a full or partial Role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_OrderProcess_FilterByShippingAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
     


