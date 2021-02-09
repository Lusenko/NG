using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Listener : IListener
    {
        public List<Message> messages;
        public void Update(Job job, string eventName)
        {
            if (eventName == "New")
                this.messages.Add(new Message(job));
            else
                this.messages.Remove(new Message(job));
        }
        public void showMess()
        {
            for (int index = 0; index < messages.Count; index++)
                messages[index].ShowMessage();
        }
        public Listener()
        {
            messages = new List<Message>();
        }
    }
}