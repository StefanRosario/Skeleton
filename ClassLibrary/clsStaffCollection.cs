using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();
        //private data member for the list

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
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
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_StaffManagement_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record ot the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Username", mThisStaff.Username);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_StaffManagement_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values op ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prodecure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Username", mThisStaff.Username);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the stored procedure
            DB.Execute("sproc_StaffManagement_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_StaffManagement_Delete");
        }

        public void ReportByRole(string Role)
        {
            //filters the record based on a full or partial Role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@Role", Role);
            //execute the stored procedure
            DB.Execute("sproc_StaffManagement_FilterByRole");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}