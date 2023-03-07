using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public int CostumerID { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsEnabled { get; set; }
    }

    
}