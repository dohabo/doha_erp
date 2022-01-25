using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Work
    {
        int workOrderNum;
        int companyNum;
        string machineLine;
        int workerID;
        string itemCode;
        int workQuantity;
        string workDate;
        string workNote;

        public Work(int companyNum, 
            string machineLine, int workerID, string itemCode, 
            int workQuantity, string workDate, string workNote)
        {
            this.companyNum = companyNum;
            this.machineLine = machineLine;
            this.workerID = workerID;
            this.itemCode = itemCode;
            this.workQuantity = workQuantity;
            this.workDate = workDate;
            this.workNote = workNote;
        }

        public Work(int workOrderNum, int companyNum, string machineLine, 
            int workerID, string itemCode, int workQuantity, 
            string workDate, string workNote)
        {
            this.workOrderNum = workOrderNum;
            this.companyNum = companyNum;
            this.machineLine = machineLine;
            this.workerID = workerID;
            this.itemCode = itemCode;
            this.workQuantity = workQuantity;
            this.workDate = workDate;
            this.workNote = workNote;
        }

        public int WorkOrderNum { get => workOrderNum; set => workOrderNum = value; }
        public int CompanyNum { get => companyNum; set => companyNum = value; }
        public string MachineLine { get => machineLine; set => machineLine = value; }
        public int WorkerID { get => workerID; set => workerID = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public int WorkQuantity { get => workQuantity; set => workQuantity = value; }
        public string WorkDate { get => workDate; set => workDate = value; }
        public string WorkNote { get => workNote; set => workNote = value; }
    }
}
