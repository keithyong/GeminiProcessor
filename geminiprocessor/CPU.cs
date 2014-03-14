using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class CPU
    {
        private int programCounter;
        private int accumulator;
        private Boolean isDone;

        Memory mem;
        private int instructionsArrayLength;
        
        public CPU()
        {
            accumulator = 0;
            programCounter = 0;
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
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    mem.instructions.Add(reader.ReadUInt32());
                }
            }

            Console.WriteLine("Contents:");
            foreach (UInt32 x in mem.instructions)
            {
                Console.WriteLine(Convert.ToString(x, 2));
            }

            instructionsArrayLength = mem.instructions.Count;
        }

        public void nextInstruction()
        {
            if (programCounter <= instructionsArrayLength)
            {
                var currentInstruction = mem.instructions[programCounter];
                var opCode = getOpCode(currentInstruction);
                int modifier = Convert.ToInt32(getModifier(currentInstruction));
                int value = Convert.ToInt32(getValue(currentInstruction));
                switch (opCode)
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

                programCounter = programCounter + 1;
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
                accumulator = value;
            }
            else
            {
                accumulator = mem.stack[value];
            }
        }
        private void sta(int value)
        {
            mem.stack[value] = accumulator;
        }

        private void add(int modifier, int value)
        {
            if (modifier == 1)
            {
                accumulator = accumulator + value;
            }
            else
            {
                accumulator = accumulator + mem.stack[value];
            }
        }

        private void sub(int modifier, int value)
        {
            if (modifier == 1)
            {
                accumulator = accumulator - value;
            }
            else
            {
                accumulator = accumulator - mem.stack[value];
            }
        }

        private void and(int modifier, int value)
        {
            if (modifier == 1)
            {
                accumulator = accumulator & value;
            }
            else
            {
                accumulator = accumulator & mem.stack[value];
            }
        }

        private void or(int modifier, int value)
        {
            if (modifier == 1)
            {
                accumulator = accumulator | value;
            }
            else
            {
                accumulator = accumulator | mem.stack[value];
            }
        }

        private void ba(int value)
        {
            int indexToBranchTo = value - 2;
            Console.WriteLine("BA - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, getOpCode(mem.instructions[value]));
            programCounter = indexToBranchTo;
        }

        private void be(int value)
        {
            int indexToBranchTo = value - 1;
            if (accumulator == 0)
            {
                programCounter = indexToBranchTo;
            }
        }

        private void bl(int value)
        {
            int indexToBranchTo = value - 1;
            if (accumulator < 0)
            {
                programCounter = indexToBranchTo;
            }
        }

        private void bg(int value)
        {
            int indexToBranchTo = value - 1;
            if (accumulator > 0)
            {
                programCounter = indexToBranchTo;
            }
        }

        private void nop()
        {
            accumulator = accumulator + 0;
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
            return programCounter;
        }

        public int getAccumulator()
        {
            return accumulator;
        }

        public int getNextInstruction()
        {
            return Convert.ToInt32(mem.instructions[programCounter]);
        }

        public Boolean isCPUDone()
        {
            return isDone;
        }

        public int getLengthOfInstructions()
        {
            return instructionsArrayLength;
        }
        /*NOT DONE
        public string getNextInstructionText(Dictionary<String, int> map)
        {
            return "";

        }*/


    }
}
