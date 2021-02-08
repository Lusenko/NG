using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern3
{
    class Message
    {
        public string jobVacancy;
        public string companyName;
        public string info;
        public string employer;

        public Message(Job job)
        {
            this.jobVacancy = job.getVacancy();
            this.companyName = job.getCompanyName();
            this.info = job.getInfo();
            this.employer = job.getEmploer();
        }
        public void ShowMessage()
        {
            Console.WriteLine("\nVacancy: " + this.jobVacancy);
            Console.WriteLine("Vacancy: " + this.companyName);
            Console.WriteLine("Vacancy: " + this.info);
            Console.WriteLine("Vacancy: " + this.employer + "\n");
        }
    }
}
