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
        Memory mem = new Memory();
        
        
        public CPU()
        {
            accumulator = 0;
        }

        public void readFile(string fileName)
        {
            int currentInstruction;

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

            foreach (UInt32 x in mem.instructions)
            {
                Console.WriteLine(x);
            }
            
        }
        public void nextInstruction()
        {
            programCounter++;
            //int instruction = parsedFile[1];
        }


    }
}
