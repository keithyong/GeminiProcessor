using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class PCIncrementEventArgs : EventArgs
    {
        public int PC { get; set; }
        public PCIncrementEventArgs(int programCounter)
        {
            this.PC = programCounter;
        }
    }
}
