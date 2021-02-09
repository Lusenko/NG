using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Job
    {
        public string vacancy { get; set; }
        public string emploer { get; set; }
        public string companyName { get; set; }
        public string info { get; set; }

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
    }
}
