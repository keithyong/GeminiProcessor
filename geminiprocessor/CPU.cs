using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class CPU
    {
        private int programCounter;
        Memory mem;
        private static int instructionsArrayLength;
        private bool _continue = true;

        int fetchIR;
        int decodeIR;

        int decodeOpCode, decodeModifier, decodeValue = 0;
        int executeOpCode, executeModifier, executeValue = 0;
        int wbOpCode, wbModifier, wbValue = 0;
        int executeACC;
        int wbACC;

        /*Because the program still needs
         * to run this part of the pipeline
         * at the end of most assembly programs:
         * W 
         * E W 
         * D E W */
        int fetchEndCount; 

        int fetchIRBackup;
        int decodeIRBackup;
        int decodeOpCodeBackup;
        int decodeModifierBackup;
        int decodeValueBackup;
        int executeOpCodeBackup;
        int executeModifierBackup;
        int executeValueBackup;
        int wbOpCodeBackup;
        int wbModifierBackup;
        int wbValueBackup;
        int executeACCBackup;
        int wbACCBackup;

        int delayCount = 0;
        int delayAmount = 0;
        bool isDelay = false;

        private Thread fetchThread;
        private Thread decodeThread;
        private Thread exeThread;
        private Thread wbThread;

        public delegate void barrierEvent(object sender, GeminiEventArgs args);
        public event barrierEvent barrierDone;

        public delegate void programDoneEvent(object sender, EventArgs args);
        public event programDoneEvent programDone;

        public delegate void PCIncrementEvent(object sender, PCIncrementEventArgs args);
        public event PCIncrementEvent PCIncremented;

        public delegate void delayEvent(object sender, DelayCycleArgs args);
        public event delayEvent delayCycle;

        Barrier barrier;

        public CPU(string fileName)
        {
            mem = new Memory();
            this.readFile(fileName);
            fetchThread = new Thread(fetch);
            decodeThread = new Thread(decode);
            exeThread = new Thread(execute);
            wbThread = new Thread(writeBack);
            barrier = new Barrier(5, (b) =>
            {
                //If the recently completed execute was an add (opcode = 3)
                //Start the delay process
                switch (executeOpCode)
                {
                    //Start delays for lda, add, sub if needed
                    case 1:
                        startDelay(1);
                        break;
                    case 3:
                        startDelay(4);
                        break;
                    case 4:
                        startDelay(4);
                        break;
                }

                if (isDelay == true)
                {
                    if (delayCount >= delayAmount)
                    {
                        Console.WriteLine("Delay Done");
                        endDelay();
                    }
                    else
                    {
                        if (delayCycle != null)
                        {
                            delayCount++;
                            delayCycle(this, new DelayCycleArgs(delayAmount, delayCount));
                        }
                    }
                    Console.WriteLine("isDelay = {1}, delayCount = {0}", delayCount, isDelay);
                }
                else
                {
                    pushVariables();
                }
                Console.WriteLine("WB ACC = " + wbACC);
                if (barrierDone != null)
                {
                    barrierDone(this, new GeminiEventArgs(programCounter, fetchIR, wbACC, isDelay));
                }
            });

            executeACC = 0;
            programCounter = 0;
            this.startThreads();
        }

        public void startThreads()
        {
            Console.WriteLine("STARTING THREADS");
            fetchThread.Start();
            decodeThread.Start();
            exeThread.Start();
            wbThread.Start();
        }

        private void fetch()
        {
            while (_continue)
            {
                if (!_continue) break;

                if (isDelay == true)
                {
                    Console.WriteLine("FETCH: PC = {0}, FetchIR = {1} (DELAY)", programCounter, fetchIR);
                }
                else if (programCounter < instructionsArrayLength)
                {
                    programCounter++;
                    if (PCIncremented != null)
                    {
                        PCIncremented(this, new PCIncrementEventArgs(programCounter));
                    }
                    fetchIR = (int)mem.instructions[programCounter - 1];
                    Console.WriteLine("FETCH: PC = {0}, FetchIR = {1}", programCounter, fetchIR);
                }
                else if (fetchEndCount == 2)
                {
                    if (programDone != null)
                    {
                        programDone(this, new EventArgs());
                    }
                    _continue = false;
                    dispose();
                }
                else
                {
                    Console.WriteLine("FETCH: nop");
                    fetchIR = 0;
                    fetchEndCount++;
                }
                barrier.SignalAndWait();
            }
        }

        private void decode()
        {
            while (_continue)
            {
                if (!_continue) break;
                decodeOpCode = getOpCode(decodeIR);
                decodeModifier = getModifier(decodeIR);
                decodeValue = getValue(decodeIR);
                Console.WriteLine("DECODE: [{0}], [{1}], [{2}]", decodeOpCode, decodeModifier, decodeValue);
                barrier.SignalAndWait();
            }
        }

        private void execute() 
        {
            while (_continue)
            {
                if (!_continue) break;
                Console.WriteLine("EXECUTE: [{0}], [{1}], [{2}]", executeOpCode, executeModifier, executeValue);

                switch (executeOpCode)
                {
                    case 0:

                    case 1:
                        lda(executeModifier, executeValue);
                        break;
                    case 2:
                        break;
                    case 3:
                        add(executeModifier, executeValue);
                        break;
                    case 4:
                        sub(executeModifier, executeValue);
                        break;
                    case 5:
                        and(executeModifier, executeValue);
                        break;
                    case 6:
                        or(executeModifier, executeValue);
                        break;
                    case 7:
                        ba(executeValue);
                        break;
                    case 8:
                        be(executeValue);
                        break;
                    case 9:
                        bl(executeValue);
                        break;
                    case 10:
                        bg(executeValue);
                        break;
                    case 11:
                        nop();
                        break;
                    case 12:
                        hlt();
                        break;
                }
                barrier.SignalAndWait();
            }
        }

        private void writeBack()
        {
            while (_continue)
            {
                if (!_continue) break;

                Console.WriteLine("WRITEB: [{0}], [{1}], [{2}]", wbOpCode, wbModifier, wbValue);
                barrier.SignalAndWait();
                if (isDelay == false)
                {
                    switch (wbOpCode)
                    {
                        case 2:
                            sta(wbValue);
                            break;
                    }
                }
            }
        }

        public void nextInstruction()
        {
            barrier.SignalAndWait();
        }

        void startDelay(int count)
        {
            Console.WriteLine("STARTED DELAY WITH {0} CYCLES", count);
            fetchIRBackup = fetchIR;
            decodeIRBackup = decodeIR;
            decodeOpCodeBackup = decodeOpCode;
            decodeModifierBackup = decodeModifier;
            decodeValueBackup = decodeValue;
            executeOpCodeBackup = executeOpCode;
            executeModifierBackup = executeModifier;
            executeValueBackup = executeValue;
            wbOpCodeBackup = wbOpCode;
            wbModifierBackup = wbModifier;
            wbValueBackup = wbValue;
            executeACCBackup = executeACC;
            wbACCBackup = wbACC;

            fetchIR = 0;
            decodeIR = 0;
            decodeOpCode = 0;
            decodeModifier = 0;
            decodeValue = 0;
            executeOpCode = 0;
            executeModifier = 0;
            executeValue = 0;
            wbOpCode = 0;
            wbModifier = 0;
            wbValue = 0;
            executeACC = 0;
            wbACC = 0;

            delayCount = 0;
            delayAmount = count;
            isDelay = true;
        }

        void endDelay()
        {
            fetchIR = fetchIRBackup;
            decodeIR = decodeIRBackup;
            decodeOpCode = decodeOpCodeBackup;
            decodeModifier = decodeModifierBackup;
            decodeValue = decodeValueBackup;
            executeOpCode = executeOpCodeBackup;
            executeModifier = executeModifierBackup;
            executeValue = executeValueBackup;
            wbOpCode = wbOpCodeBackup;
            wbModifier = wbModifierBackup;
            wbValue = wbValueBackup;
            executeACC = executeACCBackup;
            wbACC = wbACCBackup;
            delayCount = 0;
            isDelay = false;
            pushVariables();
        }

        void pushVariables()
        {
            wbACC = executeACC;

            wbOpCode = executeOpCode;
            wbModifier = executeModifier;
            wbValue = executeValue;

            executeOpCode = decodeOpCode;
            executeModifier = decodeModifier;
            executeValue = decodeValue;

            decodeIR = fetchIR;
        }

        void flushInstructions()
        {
            fetchIR = 0;
            decodeIR = 0;
            decodeOpCode = 0;
            decodeModifier = 0;
            decodeValue = 0;
            executeOpCode = 0;
            executeModifier = 0;
            executeValue = 0;
            wbOpCode = 0;
            wbModifier = 0;
            wbValue = 0;
            executeACC = 0;
            wbACC = 0;
        }
        private void nota()
        {
        }

        private void lda(int modifier, int value)
        {
            if (modifier == 1)
            {
                executeACC = value;
            }
            else
            {
                executeACC = mem[value];
            }
        }

        private void sta(int value)
        {
            if ((value <= 255) && (value >= 0))
            {
                mem[value] = executeACC;
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
                executeACC = executeACC + value;
            }
            else
            {
                executeACC = executeACC + mem[value];
            }
        }

        private void sub(int modifier, int value)
        {
            if (modifier == 1)
            {
                executeACC = executeACC - value;
            }
            else
            {
                executeACC = executeACC - mem[value];
            }
        }

        private void and(int modifier, int value)
        {
            if (modifier == 1)
            {
                executeACC = executeACC & value;
            }
            else
            {
                executeACC = executeACC & mem[value];
            }
        }

        private void or(int modifier, int value)
        {
            if (modifier == 1)
            {
                executeACC = executeACC | value;
            }
            else
            {
                executeACC = executeACC | mem[value];
            }
        }

        private void ba(int value)
        {
            int indexToBranchTo = value - 1;
            programCounter = indexToBranchTo;
            Console.WriteLine("BA called. Setting programCounter = {0}", programCounter);
        }

        private void be(int value)
        {
            int indexToBranchTo = value - 1;
            flushInstructions();
            if (executeACC == 0)
            {
                Console.WriteLine("BE - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                programCounter = indexToBranchTo;
            }
        }

        private void bl(int value)
        {
            int indexToBranchTo = value - 1;
            if (executeACC < 0)
            {
                Console.WriteLine("BL - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                programCounter = indexToBranchTo;
            }
            else
            {
                Console.WriteLine("BL didn't work :(");
            }
        }

        private void bg(int value)
        {
            int indexToBranchTo = value - 1;
            if (executeACC > 0)
            {
                Console.WriteLine("BG - branching to instructions[{0}] which is instruction {1}", indexToBranchTo, Convert.ToString(mem.instructions[indexToBranchTo], 2));
                programCounter = indexToBranchTo;
            }
        }

        private void nop()
        {
            executeACC = executeACC + 0;
        }

        private void hlt()
        {
            programDone(this, new EventArgs());
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

        public static UInt32 getOpCode(UInt32 num)
        {
            return num >> 26;
        }
        
        public static int getOpCode(int num)
        {
            return num >> 26;
        }

        public static UInt32 getValue(UInt32 num)
        {
            return num & 33554431;
        }
        
        public static int getValue(int num)
        {
            return num & 33554431;
        }

        public static UInt32 getModifier(UInt32 num)
        {
            return (num & 67108863) >> 25;
        }

        public static int getModifier(int num)
        {
            return (num & 67108863) >> 25;
        }

        public int getProgramCounter()
        {
            return programCounter;
        }

        public int getAccumulator()
        {
            return executeACC;
        }

        public int getNextInstruction()
        {
            if ((programCounter + 1) <= instructionsArrayLength)
            {
                return Convert.ToInt32(mem.instructions[programCounter]);
            }
            else
            {
                return 0;
            }
        }

        public int getCurrentInstruction()
        {
            if ((programCounter + 1) <= instructionsArrayLength)
            {
                return Convert.ToInt32(mem.instructions[programCounter - 1]);
            }
            else
            {
                return 0;
            }
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

        public void dispose()
        {
            fetchThread.Join();
            decodeThread.Join();
            exeThread.Join();
            wbThread.Join();
        }

    }
}
