using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Stock
    {
        string itemCode;
        int stockQuantity;

        public Stock(string itemCode, int stockQuantity)
        {
            this.itemCode = itemCode;
            this.stockQuantity = stockQuantity;
        }

        public string ItemCode { get => itemCode; set => itemCode = value; }
        public int StockQuantity { get => stockQuantity; set => stockQuantity = value; }
    }
}
