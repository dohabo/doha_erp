using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Model
{
    class Company
    {
        string companyNum;
        string companyName;

        public Company(string companyNum, string companyName)
        {
            this.companyNum = companyNum;
            this.companyName = companyName;
        }

        public string CompanyNum { get => companyNum; set => companyNum = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
