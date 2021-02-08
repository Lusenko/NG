using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern3
{
    interface IListener
    {
        void Update(Job job, string eventName);
    }
}
