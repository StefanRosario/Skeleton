using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Boolean mActive;
        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        
        private Int32 mStaffID;
        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        private string mUsername;
        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        private string mRole;
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_StaffManagement_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string Username, string Password, string Role, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Username is blank
            if (Username.Length == 0)
            {
                //record the error
                Error = Error + "The Username may not be blank : ";
            }
            //if the Username is greater than 50 characters
            if (Username.Length > 50)
            {
                //record the error
                Error = Error + "The Username must be less than 50 characters : ";
            }

            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
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
            if (Password.Length ==0)
            {
                //record the error
                Error = Error + "The Password may not be blank : ";
            }
            //if the Password is too long
            if (Password.Length > 50)
            {
                //record the error
                Error = Error + "The Password must be less than 50 characters : ";
            }
            //is the Role blank
            if (Role.Length == 0)
            {
                //record the error
                Error = Error + "The Role may not be blank ; ";
            }
            //if the Role is too long
            if (Role.Length > 50)
            {
                Error = Error + "The Role must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}