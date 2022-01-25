using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Items
    {
        string itemCode;
        string itemName;

        public Items(string itemCode, string itemName)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
        }

        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string ItemName { get => itemName; set => itemName = value; }
    }
}
