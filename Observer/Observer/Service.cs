using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern3
{
   class Service
    {
        public List<Job> jobs;
        public EventManager eventManager;      

        public Service()
        {
            this.jobs = new List<Job>();
            this.eventManager = new EventManager();         
        }
        public void NewJob(Job job)
        {
            this.jobs.Add(job);
            eventManager.notify(job,"add");
        }
        public void RemoveJob(Job job)
        {
            this.jobs.Remove(job);
            eventManager.notify(job,"remove");
        }
    }
}
