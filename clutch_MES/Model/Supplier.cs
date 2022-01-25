using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Supplier
    {
        int supplierNum;
        string supplierName;
        string sellingItem;
        string ceoName;
        string adress;

        public Supplier(int supplierNum, string supplierName, 
            string sellingItem, string ceoName, string adress)
        {
            this.supplierNum = supplierNum;
            this.supplierName = supplierName;
            this.sellingItem = sellingItem;
            this.ceoName = ceoName;
            this.adress = adress;
        }

        public int SupplierNum { get => supplierNum; set => supplierNum = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string CeoName { get => ceoName; set => ceoName = value; }
        public string Adress { get => adress; set => adress = value; }
        public string SellingItem { get => sellingItem; set => sellingItem = value; }
    }
}
