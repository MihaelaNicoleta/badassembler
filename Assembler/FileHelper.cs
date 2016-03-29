﻿using System;
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


    }
}