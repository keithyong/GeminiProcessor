using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GeminiProcessor
{
    public class CPU
    {

        private bool _continue = true;

        private int PC;
        private int ACC;
        private Boolean isDone;
        Memory mem;
        private int instructionsArrayLength;
        private int IR;
        private int IR2;
        private int IR3;
        private int IR4;
        object irLock = new object();

        public event FetchDone FetchComplete;

        private Thread fetchThread;
        AutoResetEvent fetchEvent = new AutoResetEvent(false);

        private delegate void FetchDone(object sender, IntEventArgs args);
        
        public CPU()
        {
            ACC = 0;
            PC = 1;
            isDone = false;
            mem = new Memory();
        }

        public void readFile(string fileName)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Found binary file " + fileName);
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                //FETCH
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    mem.instructions.Add(reader.ReadUInt32());
                }
            }

            Console.WriteLine("Contents:");
            foreach (UInt32 x in mem.instructions)
            {
                Console.WriteLine(Convert.ToString( x, 2));
            }

            instructionsArrayLength = mem.instructions.Count;
        }

        private void Fetch()
        {
            while (_continue)
            {
                fetchEvent.WaitOne();
                if (!_continue) break;


                PC++;

                if (FetchComplete != null)
                {
                    FetchComplete(this, new IntEventArgs(this.PC));
                }



                lock (irLock)
                {
                    IR = (int) mem.instructions[PC];  // next instruction goes here
                    IR2 = IR;
                    IR3 = IR2;
                    IR4 = IR3;

                }

                Console.WriteLine("In Fetch:" + IR);
            }
        }

        public void nextInstruction()
        {
            if (PC < instructionsArrayLength)
            {
                //DECODE
                var currentInstruction = mem.instructions[PC - 1];
                var opcode = getOpCode(currentInstruction);
                int modifier = Convert.ToInt32(getModifier(currentInstruction));
                int value = Convert.ToInt32(getValue(currentInstruction));

                switch (opcode)
                {
                    case 0:

                    case 1:
                        lda(modifier, value);
                        break;
                    case 2:
                        sta(value);
                        break;
                    case 3:
                        add(modifier, value);
                        break;
                    case 4:
                        sub(modifier, value);
                        break;
                    case 5:
                        and(modifier, value);
                        break;
                    case 6:
                        or(modifier, value);
                        break;
                    case 7:
                        ba(value);
                        break;
                    case 8:
                        be(value);
                        break;
                    case 9:
                        bl(value);
                        break;
                    case 10:
                        bg(value);
                        break;
                    case 11:
                        nop();
                        break;
                    case 12:
                        hlt();
                        break;
                }
                Console.WriteLine("Accumulator = {0}", ACC);
                PC = PC + 1;
            }
            else
            {
                isDone = true;
            }
        }

        private void nota()
        {
        }

        private void lda(int modifier, int value)
        {
            if (modifier == 1)
            {
                ACC = value;
            }
            else
            {
                ACC = mem[value];
            }
        }
        private void sta(int value)
        {
            if ((value <= 255) && (value >= 0))
            {
                Console.Write("Stack[{0}] = {1}... ", value, ACC);
                mem[value] = ACC;
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        private void add(int modifier, int value)
        {
            if (modifier == 1)
            {
                ACC = ACC + value;
            }
            else
            {
                ACC = ACC + mem[value];
            }
        }

        private void sub(int modifier, int value)
        {
            if (modifier == 1)
            {
                ACC = ACC - value;
            }
            else
            {
                ACC = ACC - mem[value];
            }
        }

        private void and(int modifier, int value)
        {
            if (modifier == 1)
            {
                ACC = ACC & value;
            }
            else
            {
                ACC = ACC & mem[value];
            }
        }

        private void or(int modifier, int value)
        {
            if (modifier == 1)
            {
                ACC = ACC | value;
            }
            else
            {
                ACC = ACC | mem[value];
            }
        }

        private void ba(int value)
        {
            int indexToBranchTo = value - 1;
            Console.WriteLine("BA - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));

            PC = indexToBranchTo;
        }

        private void be(int value)
        {
            int indexToBranchTo = value - 1;

            if (ACC == 0)
            {
                Console.WriteLine("BE - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                PC = indexToBranchTo;
            }
        }

        private void bl(int value)
        {
            int indexToBranchTo = value - 1;
            if (ACC < 0)
            {
                Console.WriteLine("BL - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                PC = indexToBranchTo;
            }
            else
            {
                Console.WriteLine("BL didn't work :(");
            }
        }

        private void bg(int value)
        {
            int indexToBranchTo = value - 1;
            if (ACC > 0)
            {
                Console.WriteLine("BG - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                PC = indexToBranchTo;
            }
        }

        private void nop()
        {
            ACC = ACC + 0;
        }

        private void hlt()
        {
            isDone = true;
        }

        public static UInt32 getOpCode(UInt32 num)
        {
            return num >> 26;
        }
        
        public static UInt32 getValue(UInt32 num)
        {
            return num & 33554431;
        }

        public static UInt32 getModifier(UInt32 num)
        {
            return (num & 67108863) >> 25;
        }

        public int getProgramCounter()
        {
            return PC;
        }

        public int getAccumulator()
        {
            return ACC;
        }

        public int getNextInstruction()
        {
            if ((PC + 1) <= instructionsArrayLength)
            {
                return Convert.ToInt32(mem.instructions[PC]);
            }
            else
            {
                return 0;
            }
        }
        public int getCurrentInstruction()
        {
            if ((PC + 1) <= instructionsArrayLength)
            {
                return Convert.ToInt32(mem.instructions[PC - 1]);
            }
            else
            {
                return 0;
            }
        }

        public Boolean isCPUDone()
        {
            return isDone;
        }

        public int getLengthOfInstructions()
        {
            return instructionsArrayLength;
        }

        public int getHits()
        {
            return mem.getHits();
        }

        public int getMisses()
        {
            return mem.getMisses();
        }
    }
}
