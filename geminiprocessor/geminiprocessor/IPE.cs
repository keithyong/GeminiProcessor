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
        Dictionary<String, int> map = new Dictionary<String, int>(); //mappings of instructions to their opcode

        //Code from text is sorted into these Dictionaries
        Dictionary<int, int> branches = new Dictionary<int, int>();
        Dictionary<int, string> branchTo = new Dictionary<int, string>();

        Dictionary<string, int> labels = new Dictionary<string, int>(); //mappings of lineindex to its labels
        public SortedDictionary<int, int> binaries = new SortedDictionary<int, int>(); // mappings of lineindex to its instruction opcode

        string labelFormat = @"^(?<cmd>.*?)\s*:";  //Regex for labels like main:
        string instFormat = @"(\w+)\s+([^\d]+)(\d+)"; //Regex for lda #$5 -> ["lda", "#$", "5"]
        string commentFormat = @"\s*(!.*)?\s*$"; //Regex to remove everything after "!"
        string singleInstFormat = @"\b([a-z]+)"; //Regex to match instructions like "nota", "htl"
        string branchFormat = @"\b([b][a-z]+)\b\s*\b([a-z]+)\b"; //Regex to match "bl out" -> ["bl", "out"]

        int modifierOr = 33554432;

        const string fileName = "parsedFile.out";

        public IPE(string fileName)
        {
            //opcodes
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
            Regex branchRegex = new Regex(branchFormat);

            for (int i = 0; i < lines.Length; i++)
            {
                //Trim the text file of any whitespace and comments
                lines[i] = commentRegex.Replace(lines[i], "").Trim();

                var lineMatch = instRegex.Match(lines[i]);
                var labelMatch = labelRegex.Match(lines[i]);
                var singleMatch = singleInstRegex.Match(lines[i]);
                var branchMatch = branchRegex.Match(lines[i]);

                if (lineMatch.Success)
                {
                    lineIndex++;
                    String currentInstruction = lineMatch.Groups[1].Value;
                    int currentInstructionInt = map[currentInstruction];
                    String currentModifier = lineMatch.Groups[2].Value;
                    int currentNumber = Convert.ToInt32(lineMatch.Groups[3].Value);
                    int value = currentInstructionInt;

                    if (currentModifier == "#$")
                    {
                        value = currentInstructionInt | modifierOr;
                    }

                    value = value | currentNumber;
                    binaries.Add(lineIndex, value);
                    Console.WriteLine(lineIndex + " LineMatched: " + currentInstruction + ", " + currentModifier + ", " + currentNumber + "... Added " + Convert.ToString(value, 2));

                }
                else if (labelMatch.Success)
                {
                    String labelToAdd = labelMatch.Value;
                    int indexOfLabel = lineIndex + 1;
                    labels.Add(labelToAdd, indexOfLabel);
                    Console.WriteLine("LabelMatched: " + labelToAdd + " to the labels dictionary with index " + indexOfLabel);
                }
                else if (branchMatch.Success)
                {
                    lineIndex++;
                    int numberToAdd = map[branchMatch.Groups[1].Value];
                    string branchLabel = branchMatch.Groups[2].Value;

                    branches.Add(lineIndex, numberToAdd);
                    branchTo.Add(lineIndex, branchLabel);
                    Console.WriteLine(lineIndex + " BranchMatched: " + branchMatch.Groups[1].Value + ", " + branchMatch.Groups[2].Value + "... Added " + Convert.ToString(numberToAdd, 2));
                }
                else if (singleMatch.Success)
                {
                    lineIndex++;
                    var numberToAdd = map[singleMatch.Value];
                    binaries.Add(lineIndex, numberToAdd);
                    Console.WriteLine(lineIndex + " SingleMatched " + singleMatch.Value + "... Added " + Convert.ToString(numberToAdd, 2));
                }
                else
                {
                    Console.WriteLine("NO MATCH");
                }
            }

            //fix the branches
            foreach (KeyValuePair<int, int> b in branches)
            {
                string labelToBranchTo = branchTo[b.Key];
                int indexOfBranch = labels[labelToBranchTo + ":"];
                int newBranchBinary = b.Value + indexOfBranch;
                binaries.Add(b.Key, newBranchBinary);
                Console.WriteLine("Added {0} to the instructions array with index {1}", newBranchBinary, b.Key);
            }

            Console.WriteLine();
            Console.WriteLine("Current Instructions in Binary Dictionary:");

            foreach (KeyValuePair<int, int> k in binaries)
            {
                Console.WriteLine("Index = {0}, Value = {1}", k.Key, k.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Current values in Label Dictionary:");

            foreach (KeyValuePair<string, int> k in labels)
            {
                Console.WriteLine("Index = {0}, Value = {1}", k.Value, k.Key);
            }

            WriteValues(binaries);
        }

        public string getFileName()
        {
            return fileName;
        }

        public static void WriteValues(SortedDictionary<int, int> dict)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {

                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    foreach (KeyValuePair<int, int> k in dict)
                    {
                        writer.Write(k.Value);
                    }
                }
            }

        }

        public Dictionary<String, int> getInstructionMapDictionary()
        {
            return map;
        }
    }
}