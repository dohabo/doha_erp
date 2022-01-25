using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class BOM
    {
        string pNum;    //모품번
        string cNum;    //자품번
        int quantity; // 수량

        public BOM(string pNum, string cNum, int quantity)
        {
            this.pNum = pNum;
            this.cNum = cNum;
            this.quantity = quantity;
        }

        public string PNum { get => pNum; set => pNum = value; }
        public string CNum { get => cNum; set => cNum = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
