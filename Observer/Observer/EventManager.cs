using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern3
{
    class EventManager
    {
        public List<IListener> eventManagers;

        public EventManager()
        {
            eventManagers = new List<IListener>();
        }
        public void subscriber(IListener listener)
        {
            eventManagers.Add(listener);
        }
        public void unsubscribe(IListener listener)
        {
            eventManagers.Remove(listener);
        }
        public void notify(Job job, string eventName)
        {
            foreach(IListener list in eventManagers)
            {
                list.Update(job, eventName);
            }
        }
    }
}
