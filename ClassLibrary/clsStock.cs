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
                Available = value;
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
                ProductID = value;
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
                ProductName = value;
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
                Description = value;
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
                Category = value;
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
                Price = value;
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
                StockCount = value;
            }
        }
    }
}


