using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class workJoinVo
    {
        int workedNum;
        string companyNum;
        string machineLine;
        int workerID;
        string itemCode;
        string itemName;
        int workQuantity;
        string workDate;
        string workedDate;
        int workedquantity;
        int defectQuantity;
        string defectCode;
        string defectName;
        string workNote;

        public workJoinVo(int workedNum, string machineLine, 
            int workerID, string itemCode, int workQuantity, 
            string workDate, string workedDate, int workedquantity, 
            int defectQuantity, string defectCode, string workNote)
        {
            this.workedNum = workedNum;
            this.machineLine = machineLine;
            this.workerID = workerID;
            this.itemCode = itemCode;
            this.workQuantity = workQuantity;
            this.workDate = workDate;
            this.workedDate = workedDate;
            this.workedquantity = workedquantity;
            this.defectQuantity = defectQuantity;
            this.defectCode = defectCode;
            this.workNote = workNote;
        }

        public workJoinVo(int workedNum, string companyNum, 
            string machineLine, int workerID, string itemCode, 
            int workQuantity, string workDate, string workedDate, 
            int workedquantity, int defectQuantity, string defectCode, string workNote)
        {
            this.workedNum = workedNum;
            this.companyNum = companyNum;
            this.machineLine = machineLine;
            this.workerID = workerID;
            this.itemCode = itemCode;
            this.workQuantity = workQuantity;
            this.workDate = workDate;
            this.workedDate = workedDate;
            this.workedquantity = workedquantity;
            this.defectQuantity = defectQuantity;
            this.defectCode = defectCode;
            this.workNote = workNote;
        }

        public workJoinVo(string itemCode, string itemName, 
            int workQuantity, int workedquantity)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.workQuantity = workQuantity;
            this.workedquantity = workedquantity;
        }

        public workJoinVo(string machineLine, int workQuantity, int workedquantity)
        {
            this.machineLine = machineLine;
            this.workQuantity = workQuantity;
            this.workedquantity = workedquantity;
        }

        public workJoinVo(string defectName, int defectQuantity)
        {
            this.defectName = defectName;
            this.defectQuantity = defectQuantity;
        }

        public int WorkedNum { get => workedNum; set => workedNum = value; }
        public string MachineLine { get => machineLine; set => machineLine = value; }
        public int WorkerID { get => workerID; set => workerID = value; }
        public string ItemCode { get => itemCode; set => itemCode = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int WorkQuantity { get => workQuantity; set => workQuantity = value; }
        public string WorkDate { get => workDate; set => workDate = value; }
        public string WorkedDate { get => workedDate; set => workedDate = value; }
        public int Workedquantity { get => workedquantity; set => workedquantity = value; }
        public int DefectQuantity { get => defectQuantity; set => defectQuantity = value; }
        public string DefectCode { get => defectCode; set => defectCode = value; }
        public string WorkNote { get => workNote; set => workNote = value; }
        public string DefectName { get => defectName; set => defectName = value; }
        public string CompanyNum { get => companyNum; set => companyNum = value; }
    }
}
