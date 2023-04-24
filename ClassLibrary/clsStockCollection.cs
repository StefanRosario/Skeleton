using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> tStockList = new List<clsStock>();
        clsStock tThisStock = new clsStock();

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_StockManagement_SelectAll");

            PopulateArray(DB);
        }

        public List<clsStock> StockList
        {
            get
            {
                return tStockList;
            }
            set
            {
                tStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return tStockList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisStock
        {
            get
            {
                return tThisStock;
            }
            set
            {
                tThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", tThisStock.ProductID);
            DB.AddParameter("@ProductName", tThisStock.ProductName);
            DB.AddParameter("@Price", tThisStock.Price);
            DB.AddParameter("@Available", tThisStock.Available);
            DB.AddParameter("@Catergory", tThisStock.Category);
            DB.AddParameter("@Description", tThisStock.Description);
            DB.AddParameter("@StockCount", tThisStock.StockCount);

            return DB.Execute("sproc_StockManagement_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", tThisStock.ProductID);
            DB.Execute("sproc_StockManagement_Delete");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", tThisStock.ProductID);
            DB.AddParameter("@ProductName", tThisStock.ProductName);
            DB.AddParameter("@Price", tThisStock.Price);
            DB.AddParameter("@Available", tThisStock.Available);
            DB.AddParameter("@Catergory", tThisStock.Category);
            DB.AddParameter("@Description", tThisStock.Description);
            DB.AddParameter("@StockCount", tThisStock.StockCount);

            DB.Execute("sproc_StockManagement_Update");
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_StockManagement_FilterByProductName");

            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            tStockList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock Stock = new clsStock();
                Stock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                Stock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                Stock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                Stock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                Stock.StockCount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockCount"]);
                Stock.Category = Convert.ToString(DB.DataTable.Rows[Index]["Catergory"]);
                Stock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);

                tStockList.Add(Stock);

                Index++;
            }
        }
    }
}
