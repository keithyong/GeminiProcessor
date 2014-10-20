using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class GeminiEventArgs : EventArgs
    {
        public int PC { get; set; }
        public int IR { get; set; }
        public int ACC { get; set; }
        public bool isDelay { get; set; }
        
        public GeminiEventArgs(int pc, int ir, int acc, bool delay)
        {
            this.PC = pc;
            this.IR = ir;
            this.ACC = acc;
            this.isDelay = delay;
        }
    }
}
