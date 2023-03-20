using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsEnabled { get; set; }

        public bool Find(int staffID)
        {
            //Always retun true
            return true;
        }
    }
}