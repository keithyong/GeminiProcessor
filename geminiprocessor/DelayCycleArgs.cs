using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class DelayCycleArgs : EventArgs
    {
        public int delayAmount;
        public int delayCount;

        public DelayCycleArgs(int amountOfDelay, int currentDelayCount)
        {
            this.delayAmount = amountOfDelay;
            this.delayCount = currentDelayCount;
        }
    }
}
