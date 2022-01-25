using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Defect
    {
        string defectCode;
        string defectName;

        public Defect(string defectCode, string defectName)
        {
            this.defectCode = defectCode;
            this.defectName = defectName;
        }

        public string DefectCode { get => defectCode; set => defectCode = value; }
        public string DefectName { get => defectName; set => defectName = value; }
    }
}
