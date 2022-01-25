using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class StockHistory
    {
        string section;         // 입고, 출고 구분
        string purchaseNum;     // 입고에 대한 구매 오더 번호 매칭
        string workOrderNum;       // 출고에 대한 작업지시 번호 매칭
        string companyNum;
        string itemCode;        // 품번
        string stockQuantity;      // 수량
        string inDate;
        string warehouse;
        string note;

        public StockHistory(string section, string purchaseNum, string workOrderNum,
            string companyNum, string itemCode, string stockQuantity, 
            string inDate, string warehouse, string note)
        {
            this.section = section;
            this.purchaseNum = purchaseNum;
            this.workOrderNum = workOrderNum;
            this.companyNum = companyNum;
            this.itemCode = itemCode;
            this.stockQuantity = stockQuantity;
            this.inDate = inDate;
            this.warehouse = warehouse;
            this.note = note;
        }

        public StockHistory(string section, string workOrderNum,
            string companyNum, string itemCode, string stockQuantity, string inDate, string note)
        {
            this.section = section;
            this.workOrderNum = workOrderNum;
            this.companyNum = companyNum;
            this.itemCode = itemCode;
            this.stockQuantity = stockQuantity;
            this.inDate = inDate;
            this.note = note;
        }

        public StockHistory(string section, string purchaseNum, string companyNum, 
            string itemCode, string stockQuantity, string inDate, string warehouse, string note)
        {
            this.section = section;
            this.purchaseNum = purchaseNum;
            this.companyNum = companyNum;
            this.itemCode = itemCode;
            this.stockQuantity = stockQuantity;
            this.inDate = inDate;
            this.warehouse = warehouse;
            this.note = note;
        }

        public string Section { get => section; set => section = value; }
        public string CompanyNum { get => companyNum; set => companyNum = value; }
        public string PurchaseNum { get => purchaseNum; set => purchaseNum = value; }
        public string WorkOrderNum { get => workOrderNum; set => workOrderNum = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string StockQuantity { get => stockQuantity; set => stockQuantity = value; }
        public string InDate { get => inDate; set => inDate = value; }
        public string Warehouse { get => warehouse; set => warehouse = value; }
        public string Note { get => note; set => note = value; }
    }
}
