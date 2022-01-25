using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Purchase
    {
        int purchaseNum;
        int companyNum;
        int supplier;
        string status;
        string itemCode;
        int quantity;
        string purchaseAddDate;
        string purchaseInDate;
        int purchaser;
        string note;

        public Purchase(int companyNum, string itemCode, 
            int supplier, string status, int quantity, string purchaseAddDate, 
            string purchaseInDate, string note)
        {
            this.companyNum = companyNum;
            this.itemCode = itemCode;
            this.supplier = supplier;
            this.status = status;
            this.quantity = quantity;
            this.purchaseAddDate = purchaseAddDate;
            this.purchaseInDate = purchaseInDate;
            this.note = note;
        }

        public Purchase(int companyNum, int supplier, 
            string status, string itemCode, int quantity, 
            string purchaseAddDate, string purchaseInDate, int purchaser, string note)
        {
            this.companyNum = companyNum;
            this.supplier = supplier;
            this.status = status;
            this.itemCode = itemCode;
            this.quantity = quantity;
            this.purchaseAddDate = purchaseAddDate;
            this.purchaseInDate = purchaseInDate;
            this.purchaser = purchaser;
            this.note = note;
        }

        public Purchase(int purchaseNum, int companyNum, int supplier, 
            string status, string itemCode, int quantity, string purchaseAddDate, 
            string purchaseInDate, int purchaser, string note)
        {
            this.purchaseNum = purchaseNum;
            this.companyNum = companyNum;
            this.supplier = supplier;
            this.status = status;
            this.itemCode = itemCode;
            this.quantity = quantity;
            this.purchaseAddDate = purchaseAddDate;
            this.purchaseInDate = purchaseInDate;
            this.purchaser = purchaser;
            this.note = note;
        }

        public int CompanyNum { get => companyNum; set => companyNum = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public int Supplier { get => supplier; set => supplier = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string PurchaseAddDate { get => purchaseAddDate; set => purchaseAddDate = value; }
        public string PurchaseInDate { get => purchaseInDate; set => purchaseInDate = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
        public int Purchaser { get => purchaser; set => purchaser = value; }
        public int PurchaseNum { get => purchaseNum; set => purchaseNum = value; }
    }
}
