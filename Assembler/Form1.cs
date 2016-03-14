using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assembler
{
    public partial class mainForm : Form
    {
        //given files
        String assemblyCodeFile = "input.asm";
        String instructionsFile = "instructiuniinbinar.csv";
        String registersAndAddressingModesFile = "registri_moduriAdresare.csv";

        //given code
        List<String> assemblyCodeLines = new List<String>();

        //not used
        List<String> instructions = new List<String>();

        //the number of instructions for each class
        int numberOfB1 = 7;
        int numberOfB2 = 15;
        int numberOfB3 = 9;
        int numberOfB4 = 19;

        //dictionaries to keep the intruction and its binary codification
        Dictionary<string, string> B1 = new Dictionary<string, string>();
        Dictionary<string, string> B2 = new Dictionary<string, string>();
        Dictionary<string, string> B3 = new Dictionary<string, string>();
        Dictionary<string, string> B4 = new Dictionary<string, string>();

        //the number of registers and addressing modes
        int numberOfRegisters = 16;
        int numberOfAddressingModes = 4;

        //dictionaries for registers and addressing modes
        Dictionary<string, string> registers = new Dictionary<string, string>();
        Dictionary<string, string> addressingModes = new Dictionary<string, string>();


        public mainForm()
        {
            InitializeComponent();
            getDefaultInstructionsRegistersAddressingModes();
            //parseAssemblyCode();

        }
        
        //read asm file and display output
        private void showAsmCode(String fileName) {
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
        private void createBinaryInstructionsCodes(String fileName) {
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
        private void createBinaryRegistersAndAddressingModesCodes(String fileName)
        {
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

        private void getDefaultInstructionsRegistersAddressingModes()
        {
            showAsmCode(assemblyCodeFile);
            createBinaryInstructionsCodes(instructionsFile);
            createBinaryRegistersAndAddressingModesCodes(registersAndAddressingModesFile);
        }


        private void parseAssemblyCode()
        {
            //pt directive cu punct
            // String pattern = @"\.[a-zA-z]+)";

            String pattern = @"([a-zA-z]+\s)";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            foreach (var line in assemblyCodeLines)
            {
                if (line.Contains(".DATA") == false && line.Contains(".CODE") == false && line.Contains("END") == false)
                {
                    this.asmCode.Text += "\n" + line;
                    Match m = regex.Match(line);
                    if (m.Success)
                    {
                        Group g = m.Groups[1];
                        this.asmCode.Text += "\n" + g;
                    }
                    else {
                        //TO DO: not correct code, try again
                        //check if comment
                    }
                }
            }
        }



    }
}
