using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Worked
    {
        int workedNum;
        int workOrderNum;
        string workedDate;
        int defectQuantity;
        string defectCode;
        int workedquantity;

        public Worked(int workedNum, int workOrderNum, 
            string workedDate, int defectQuantity, 
            string defectCode, int workedquantity)
        {
            this.workedNum = workedNum;
            this.workOrderNum = workOrderNum;
            this.workedDate = workedDate;
            this.defectQuantity = defectQuantity;
            this.defectCode = defectCode;
            this.workedquantity = workedquantity;
        }

        public Worked(int workOrderNum, string workedDate, 
            int defectQuantity, string defectCode, int workedquantity)
        {
            this.workOrderNum = workOrderNum;
            this.workedDate = workedDate;
            this.defectQuantity = defectQuantity;
            this.defectCode = defectCode;
            this.workedquantity = workedquantity;
        }

        public int WorkedNum { get => workedNum; set => workedNum = value; }
        public int WorkOrderNum { get => workOrderNum; set => workOrderNum = value; }
        public string WorkedDate { get => workedDate; set => workedDate = value; }
        public int DefectQuantity { get => defectQuantity; set => defectQuantity = value; }
        public string DefectCode { get => defectCode; set => defectCode = value; }
        public int Workedquantity { get => workedquantity; set => workedquantity = value; }
    }
}
