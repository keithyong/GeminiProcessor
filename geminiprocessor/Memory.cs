using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    class Memory
    {
        public List<UInt32> instructions = new List<UInt32>();
        public int[] stack = new int[256];
    }
}
