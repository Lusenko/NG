using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Message
    {       
        public string jobVacancy;
        public string companyName;
        public string info;
        public string emploer;
        public Message(Job job)
        {
            this.jobVacancy = job.vacancy;
            this.companyName = job.companyName;
            this.info = job.info;
            this.emploer = job.emploer;
        }
        public void ShowMessage()
        {
            Console.WriteLine("\nVacancy: " + this.jobVacancy);
            Console.WriteLine("Vacancy: " + this.companyName);
            Console.WriteLine("Vacancy: " + this.info);
            Console.WriteLine("Vacancy: " + this.emploer + "\n");
        }
    }
}
