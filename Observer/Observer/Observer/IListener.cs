using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IListener
    {
        void Update(Job job, string eventName);
    }
}
