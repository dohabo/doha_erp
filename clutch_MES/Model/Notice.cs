using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Notice
    {
        int contensNum;
        string contents;
        string writeName;
        string writeDate;

        public Notice(int contensNum, string contents, 
            string writeName, string writeDate)
        {
            this.contensNum = contensNum;
            this.contents = contents;
            this.writeName = writeName;
            this.writeDate = writeDate;
        }

        public int ContensNum { get => contensNum; set => contensNum = value; }
        public string Contents { get => contents; set => contents = value; }
        public string WriteName { get => writeName; set => writeName = value; }
        public string WriteDate { get => writeDate; set => writeDate = value; }
    }
}
