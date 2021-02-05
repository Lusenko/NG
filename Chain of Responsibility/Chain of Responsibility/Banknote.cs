using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patern2
{
    class Banknote
    {
        public Banknote(int faceValue, int requiredAmnt = 0)
        {
            FaceValue = faceValue;
            RequiredAmnt = requiredAmnt;
        }
        public int FaceValue { get; private set; }
        public int RequiredAmnt { get; private set; }
        override public string ToString()
        {
            return "Номинал: " + FaceValue + ",\tнеобходимое количество: " + RequiredAmnt;
        }
    }
}
