using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> tStockList = new List<clsStock>();

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_StockManagement_SelectAll");
            RecordCount = DB.Count;
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

        public clsStock ThisStock { get; set; }
    }
}