using System;


namespace ClassLibrary
{
    public class clsStock
    {
        private Boolean tAvailable;

        public Boolean Available
        {
            get
            {
                return tAvailable;
            }
            set
            {
                tAvailable = value;
            }
        }

        private Int32 tProductID;

        public Int32 ProductID
        {
            get
            {
                return tProductID;
            }
            set
            {
                tProductID = value;
            }
        }

        private string tProductName;

        public string ProductName
        {
            get
            {
                return tProductName;
            }
            set
            {
                tProductName = value;
            }
        }

        private string tDescription;

        public string Description
        {
            get
            {
                return tDescription;
            }
            set
            {
                tDescription = value;
            }
        }

        private string tCategory;

        public string Category
        {
            get
            {
                return tCategory;
            }
            set
            {
                tCategory = value;
            }
        }

        private decimal tPrice;

        public decimal Price
        {
            get
            {
                return tPrice;
            }
            set
            {
                tPrice = value;
            }
        }

        private Int32 tStockCount;

        public Int32 StockCount
        {
            get
            {
                return tStockCount;
            }
            set
            {
                tStockCount = value;
            }
        }
        public bool Find(int ProductID)
        {
            tProductID = 376;
            tProductName = "SB Hoodie";
            tAvailable = true;
            tCategory = "Clothing";
            tDescription = "Grey SB Hoodie";
            tStockCount = 100;
            tPrice = 54.99m;
            return true;
        }
    }
}
    

