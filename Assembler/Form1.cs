﻿using System;
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

        public mainForm()
        {
            InitializeComponent();
            //showAsmCode("input.asm");
            createBinaryInstructionsCodes("instructiuniinbinar.csv");
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

        private void parseAssemblyCode() {
            //pt directive cu punct
            // String pattern = @"\.[a-zA-z]+)";

            String pattern = @"([a-zA-z]+\s)";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            foreach (var line in assemblyCodeLines) {
                if (line.Contains(".DATA") == false && line.Contains(".CODE") == false && line.Contains("END") == false) {               
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


    }
}
