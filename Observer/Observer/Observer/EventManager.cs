using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class EventManager
    {
        public Dictionary<int,IListener> eventManagers;

        public EventManager()
        {
            eventManagers = new Dictionary<int, IListener>();
        }
        public void subscriber(IListener listener)
        {
            eventManagers.Add(1,listener);
        }
        public void unsubscribe(IListener listener)
        {
            eventManagers.Remove(1);
        }       
    }
}