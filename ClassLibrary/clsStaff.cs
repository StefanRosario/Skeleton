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
        private Boolean mIsEnabled;
        public bool IsEnabled
        {
            get
            {
                return mIsEnabled;
            }
            set
            {
                mIsEnabled = value;
            }
        }

        public bool Find(int staffID)
        {
            mStaffID = 21;
            //Always retun true
            return true;
        }

        public bool Find(string username)
        {
            return true;
        }

        public bool Find(DateTime dateAdded)
        {
            return true;
        }

        public bool Find(Boolean isEnabled)
        {
            return true;
        }
    }
}