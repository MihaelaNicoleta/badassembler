using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assembler
{
    class FileHelper
    {
        public Dictionary<String, String> B1 = new Dictionary<String, String>();
        public Dictionary<String, String> B2 = new Dictionary<String, String>();
        public Dictionary<String, String> B3 = new Dictionary<String, String>();
        public Dictionary<String, String> B4 = new Dictionary<String, String>();

        //read asm file and display output
        public void showAsmCode(String fileName, List<String> assemblyCodeLines)
        {
            String asmCodeLine;

            StreamReader sr = new StreamReader(fileName);
            while ((asmCodeLine = sr.ReadLine()) != null)
            {
                //this.asmCode.Text += "\n" + asmCodeLine;
                assemblyCodeLines.Add(asmCodeLine);
            }

            sr.Close();
        }

        //read and parse instructions file
        public void createBinaryInstructionsCodes(String fileName)
        {
            //the number of instructions for each class
            int numberOfB1 = 7;
            int numberOfB2 = 15;
            int numberOfB3 = 9;
            int numberOfB4 = 19;

            String instructionsLine;
            StreamReader sr = new StreamReader(fileName);

            int ct = 0;
            while ((instructionsLine = sr.ReadLine()) != null)
            {
               
                string[] instr_binaryCode = instructionsLine.Split(';');

                if (ct < numberOfB1)
                {
                    B1.Add(instr_binaryCode[0], instr_binaryCode[1]);
                    ct++;
                }
                else {
                    if (ct < (numberOfB1 + numberOfB2))
                    {
                        B2.Add(instr_binaryCode[0], instr_binaryCode[1]);
                        ct++;
                    }
                    else
                    {
                        if (ct < (numberOfB1 + numberOfB2 + numberOfB3))
                        {
                            B3.Add(instr_binaryCode[0], instr_binaryCode[1]);
                            ct++;
                        }
                        else
                        {
                            B4.Add(instr_binaryCode[0], instr_binaryCode[1]);
                            ct++;
                        }
                    }
                }
            }

            sr.Close();
        }

        //read and parse registers/addressing modes file
        public void createBinaryRegistersAndAddressingModesCodes(String fileName, Dictionary<string, string> registers, Dictionary<string, string> addressingModes)
        {
            //the number of registers and addressing modes
            int numberOfRegisters = 16;
            int numberOfAddressingModes = 4;

            String line;
            StreamReader sr = new StreamReader(fileName);

            int ct = 0;
            while ((line = sr.ReadLine()) != null)
            {

                string[] values = line.Split(';');

                if (ct < numberOfRegisters)
                {
                    registers.Add(values[0], values[1]);
                    ct++;
                }
                else
                {
                    addressingModes.Add(values[0], values[1]);
                    ct++;
                }

            }
            sr.Close();
        }

        public void writeBinaryFile(String fileName, Dictionary<Instruction, string> instructions)
        {
            //write to a test file
            StreamWriter streamWriter = new StreamWriter("output.txt");
           
            //create .bin file
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);

            if (instructions != null)
            {
                foreach (KeyValuePair<Instruction, String> instruction in instructions)
                {
                    //write instructions
                    streamWriter.WriteLine(instruction.Key.ToString());
                    binaryWriter.Write(Convert.ToInt16(instruction.Key.ToString(), 2));

                    //write offsets for B1
                    if (instruction.Value == "B1")
                    {
                        B1Instruction B1instr = (B1Instruction) instruction.Key;
                        if(B1instr.offsetS != null)
                        {
                            streamWriter.WriteLine(B1instr.offsetS);
                            binaryWriter.Write(Convert.ToInt16(B1instr.offsetS, 2));
                        }

                        if (B1instr.offsetD != null)
                        {
                            streamWriter.WriteLine(B1instr.offsetD);
                            binaryWriter.Write(Convert.ToInt16(B1instr.offsetD, 2));
                        }
                    }

                    //write offsets for B2
                    if (instruction.Value == "B2")
                    {
                        B2Instruction B2instr = (B2Instruction)instruction.Key;

                        if (B2instr.offsetD != null)
                        {
                            streamWriter.WriteLine(B2instr.offsetD);
                            binaryWriter.Write(Convert.ToInt16(B2instr.offsetD, 2));
                        }
                    }
                }
            }

            fileStream.Flush();
            fileStream.Close();

            streamWriter.Flush();
            streamWriter.Close();

            binaryWriter.Close();

        }

        public List<String> readMicrocode(String fileName)
        {
            List<String> microcode = new List<String>();
            String microcodeLine;

            StreamReader sr = new StreamReader(fileName);
            while ((microcodeLine = sr.ReadLine()) != null)
            {
                microcode.Add(microcodeLine);
            }

            sr.Close();

            return microcode;
        }

        public void writeBinaryMicrocode(String fileName, String binaryFileName)
        {           
            //write to a test file
            StreamWriter streamWriter = new StreamWriter("output_microcode.txt");

            //create .bin file
            FileStream fileStream = new FileStream(binaryFileName, FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);

            StreamReader sr = new StreamReader(fileName);

            String microcodeLineString;
            while ((microcodeLineString = sr.ReadLine()) != null)
            {
                streamWriter.WriteLine(microcodeLineString);
                binaryWriter.Write(Convert.ToInt64(microcodeLineString, 2));
            }        

            fileStream.Flush();
            fileStream.Close();

            streamWriter.Flush();
            streamWriter.Close();

            binaryWriter.Close();
        }

        public List<UInt64> loadMicrocodeToMPM(String fileName)
        {
            List<UInt64> mpm = new List<ulong>();

            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            if(fileStream != null)
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);

                while(binaryReader.PeekChar() != -1)
                {
                    mpm.Add(binaryReader.ReadUInt64());
                }
                
            }

            return mpm;
            
        }
    }
}
