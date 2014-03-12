using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class CPU
    {
        private int programCounter;
        private int accumulator;
        
        public CPU()
        {
            accumulator = 0;
        }

        public void nextInstruction()
        {
            programCounter++;
        }

    }
}
