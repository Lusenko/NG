using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern3
{
    class Job
    {
        public string vacancy;
        public string emploer;
        public string companyName;
        public string info;

       public Job(string vacancy, string emploer, string companyName, string info)
       {
            this.vacancy = vacancy;
            this.emploer = emploer;
            this.companyName = companyName;
            this.info = info;
       }
       public Job(string vacancy, string emploer, string info)
        {
            this.vacancy = vacancy;
            this.emploer = emploer;
            this.info = info;
        }
        public string getVacancy() { return this.vacancy; }
        public string getEmploer() { return this.emploer; }
        public string getCompanyName() { return this.companyName; }
        public string getInfo() { return this.info; }

    }
}
