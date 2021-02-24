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
            if (!string.IsNullOrWhiteSpace(vacancy))
            {
                this.vacancy = vacancy;
            }          

            if (!string.IsNullOrWhiteSpace(emploer))
            {
                this.emploer = emploer;
            }
            

            if (!string.IsNullOrWhiteSpace(companyName))
            {
                this.companyName = companyName;
            }
            

            if (!string.IsNullOrWhiteSpace(info))
            {
                this.info = info;
            }
            
            
        }
        public Job(string vacancy, string emploer, string info)
        {
            if (!string.IsNullOrWhiteSpace(vacancy))
            {
                this.vacancy = vacancy;
            }
            
            if (!string.IsNullOrWhiteSpace(emploer))
            {
                this.emploer = emploer;
            }
            
            if (!string.IsNullOrWhiteSpace(info))
            {
                this.info = info;
            }
            
        }        
    }
}
