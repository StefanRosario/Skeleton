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
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_StockManagement_FilterByProductID");
            if (DB.Count == 1)
            {

                tProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                tProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                tAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                tPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                tStockCount = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                tCategory = Convert.ToString(DB.DataTable.Rows[0]["Catergory"]);
                tDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string availableOK, string priceOK, string categoryOK, string stockCountOK, string productNameOK, string descriptionOK)
        {
            String Error = "";

            if (productNameOK.Length > 50)
            {
                Error = Error + "The product name is longer than 50 characters: ";
            }
            if (descriptionOK.Length > 50)
            {
                Error = Error + "The description length is longer than 50 characters: ";
            }
            try
            {
                decimal localPrice = decimal.Parse(priceOK);
            }
            catch
            {
                Error = Error + "The value entered is not a number: ";
            }

            string[] localdecimalPrice = priceOK.Split('.');
            if(localdecimalPrice[1].Length > 2)
            {
                Error = Error + "The price contains more values more than 2 decimal places ";
            }
            try
            {

                bool localBool = Convert.ToBoolean(availableOK);
            }
            catch
            {
                Error = Error + "The value entered is not a boolean: ";
            }
            return Error;
        }
    }
}



                    





