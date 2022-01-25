using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Machine
    {
        string machineLine;
        string machineName;

        public Machine(string machineLine, string machineName)
        {
            this.machineLine = machineLine;
            this.machineName = machineName;
        }

        public string MachineLine { get => machineLine; set => machineLine = value; }
        public string MachineName { get => machineName; set => machineName = value; }
    }
}
