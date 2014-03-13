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
        Dictionary<int, int> instructions;
        private int programCounter;
        private int accumulator;
        
        
        public CPU()
        {
            accumulator = 0;
        }

        public void readFile(string fileName)
        {

            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Found binary file " + fileName);

                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }
            }
            else
            {
                Console.WriteLine("FILE NO FOUND");
            }
        }
        public void nextInstruction()
        {
            programCounter++;
            //int instruction = parsedFile[1];
        }


    }
}
