using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GeminiProcessor
{
    public class IPE
    {
        private string _fileToBeParsed;
        Dictionary<String, int> map = new Dictionary<String, int>();
        Dictionary<String, int> labels = new Dictionary<string, int>();
        Dictionary<int, int> instructions = new Dictionary<int, int>();
        ArrayList instBinaries = new ArrayList();


        string labelFormat = @"^(?<cmd>.*?)\s*:";  //Regex for labels like main:
        string instFormat = @"(\w+)\s+([^\d]+)(\d+)"; //Regex for lda #$5 -> ["lda", "#$", "5"]
        string commentFormat = @"\s*(!.*)?\s*$"; //Regex to remove everything after "!"
        string singleInstFormat = @"^(?<cmd>.*?)\s*"; //Regex to match instructions like "nota", "htl"

        int modifierAddition = 33554432; //00000010000000000000000000000000


        public IPE(string fileName)
        {
            map.Add("nota", 0);
            map.Add("lda", 67108864);
            map.Add("sta", 134217728);
            map.Add("add", 201326592);
            map.Add("sub", 268435456);
            map.Add("and", 335544320);
            map.Add("or", 402653184);
            map.Add("ba", 469762048);
            map.Add("be", 536870912);
            map.Add("bl", 603979776);
            map.Add("bg", 671088640);
            map.Add("nop", 738197504);
            map.Add("hlt", 1610612736);
            _fileToBeParsed = fileName;
        }

        public void Parse()
        {
            Console.WriteLine();
            Console.WriteLine();

            string[] lines = File.ReadAllLines(_fileToBeParsed);
            int lineIndex = 0;

            Regex instRegex = new Regex(instFormat);
            Regex labelRegex = new Regex(labelFormat);
            Regex commentRegex = new Regex(commentFormat);
            Regex singleInstRegex = new Regex(singleInstFormat);

            for (int i = 0; i < lines.Length; i++)
            {
                //Trim the text file of any whitespace and comments
                lines[i] = commentRegex.Replace(lines[i], "").Trim();

                var lineMatch = instRegex.Match(lines[i]);
                var labelMatch = labelRegex.Match(lines[i]);
                var singleMatch = singleInstRegex.Match(lines[i]);

                if (lineMatch.Success)
                {
                    lineIndex++;
                    String currentInstruction = lineMatch.Groups[1].Value;
                    int currentInstructionInt = map[currentInstruction];
                    String currentModifier = lineMatch.Groups[2].Value;
                    int currentNumber = Convert.ToInt32(lineMatch.Groups[3].Value);
                    int numberToAdd = currentInstructionInt;


                    if (currentModifier == "#$")
                    {
                        numberToAdd = currentInstructionInt | modifierAddition;
                    }

                    numberToAdd = numberToAdd | currentNumber;
                    this.instBinaries.Add(numberToAdd);
                    Console.WriteLine("Matched: " + currentInstruction + ", " + currentModifier + ", " + currentNumber + "... Added" + numberToAdd + " to the binary array!");
                    
                }
                else if (labelMatch.Success)
                {
                    lineIndex++;
                    Console.WriteLine("Matched a label: " + labelMatch.Value + " to the labels dictionary with index " + lineIndex);
                    labels.Add(labelMatch.Value, lineIndex);
                }
                else if (singleMatch.Success)
                {
                    lineIndex++;
                    Console.WriteLine("Matched a single instruction " + singleMatch.Value);
                }
                else
                {
                    Console.WriteLine("Couldn't match this line - not a recognized instruction");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Current Instructions in Binary Array:");
            foreach (int i in instBinaries)
            {
                Console.WriteLine(i);
            }
        }
    }
}