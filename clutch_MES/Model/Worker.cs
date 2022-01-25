using clutch_MES.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Worker
    {
        int workerID;
        string workerName;
        string inCompany;
        string etc;

        public Worker(int workerID, string workerName, 
            string inCompany, string etc)
        {
            this.workerID = workerID;
            this.workerName = workerName;
            this.inCompany = inCompany;
            this.etc = etc;
        }

        public int WorkerID { get => workerID; set => workerID = value; }
        public string WorkerName { get => workerName; set => workerName = value; }
        public string InCompany { get => inCompany; set => inCompany = value; }
        public string Etc { get => etc; set => etc = value; }
    }
}
