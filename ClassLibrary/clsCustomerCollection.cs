using Class_Library;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisStaff
        clsCustomer mThisCustomer = new clsCustomer();
        //private data member for the list


        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {

                //set private data 
                mCustomerList = value;
            }
        }


         public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return private data
                return mThisCustomer;
            }
            set
            {

                mThisCustomer = value;
            
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
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer Acustomer = new clsCustomer();
                //read in the fields from the current record
                Acustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                Acustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                Acustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Acustomer.PhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["Phone"]);
                Acustomer.DateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRegistered"]);
                Acustomer.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                //add the record to the private data member
                mCustomerList.Add(Acustomer);
                //point at the next record
                Index++;
            }
        }

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_CustomerManagement_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }



       

        public int Add()
        {
            //add new record to database based on value of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prodecure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            //execute the query returning the primary key value
            return DB.Execute("sproc_CustomerManagement_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values op ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prodecure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_CustomerManagement_Update");
        }

        public void Delete()
        { 
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_CustomerManagement_Delete");
        }

    

        public void ReportByEmail(string v)
        {
            throw new NotImplementedException();
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the record based on a full or partial Role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //execute the stored procedure
            DB.Execute("sproc_CustomerManagement_FilterByShippingAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}