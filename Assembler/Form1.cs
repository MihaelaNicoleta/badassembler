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
using System.Threading;

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
        List<Instruction> instructions = new List<Instruction>();

        //the 01 only instructions
        List<Instruction> binaryInstructionss = new List<Instruction>(); //-- not used

        //save instruction and its type
        Dictionary<Instruction, string> binaryInstructions = new Dictionary<Instruction, string>();

        //dictionaries to keep the intruction and its binary codification
        Dictionary<string, string> B1 = new Dictionary<string, string>();
        Dictionary<string, string> B2 = new Dictionary<string, string>();
        Dictionary<string, string> B3 = new Dictionary<string, string>();
        Dictionary<string, string> B4 = new Dictionary<string, string>();

        //dictionaries for registers and addressing modes
        Dictionary<string, string> registers = new Dictionary<string, string>();
        Dictionary<string, string> addressingModes = new Dictionary<string, string>();

        FileParser fileParser = new FileParser();
        InstructionHelper instrHelper = new InstructionHelper();
        //Thread
        

        public mainForm()
        {
            InitializeComponent();
            getDefaultInstructionsRegistersAddressingModes();
            parseAssemblyCode();

        }

        private void getDefaultInstructionsRegistersAddressingModes()
        {
            fileParser.showAsmCode(assemblyCodeFile, assemblyCodeLines);
            fileParser.createBinaryInstructionsCodes(instructionsFile);
            fileParser.createBinaryRegistersAndAddressingModesCodes(registersAndAddressingModesFile, registers, addressingModes);
            /*instrHelper.B1 = this.B1;
            instrHelper.B2 = this.B2;
            instrHelper.B3 = this.B3;
            instrHelper.B4 = this.B4;*/

            instrHelper.B1 = fileParser.B1;
            instrHelper.B2 = fileParser.B2;
            instrHelper.B3 = fileParser.B3;
            instrHelper.B4 = fileParser.B4;
        }


        private void parseAssemblyCode()
        {
            //pt directive cu punct
            // String pattern = @"\.[a-zA-z]+)";

            Dictionary<String, String> result = new Dictionary<String, String>();
            String pattern = @"([a-zA-z]+\s)";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            foreach (var line in assemblyCodeLines)
            {
                if (line.ToUpper().Contains(".DATA") == false && line.ToUpper().Contains(".CODE") == false && line.ToUpper().Contains("END") == false)
                {
                    //Match m = regex.Match(line);
                    //if (m.Success)
                    //{
                    //Group ginstrName = m.Groups[1];
                    //String instrName = ginstrName.ToString();
                    //instrName = Regex.Replace(instrName, @"\s+", "");                        
                    //Instruction instruction = new Instruction(instrName);

                        String[] values = line.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        result = instrHelper.getInstructionType(values[0].Trim());

                        if (result != null)
                        {
                            switch (result.First().Key)
                            {
                                case "B1":
                                    B1Instruction B1instr = new B1Instruction(result.First().Value);
                                    binaryInstructions.Add(B1instr, result.First().Key);

                                    //source
                                    List<String> b1_adrRegMAS = getAddressingMode(values[1].Trim());

                                    if ((b1_adrRegMAS != null))
                                    {                                       
                                        B1instr.MAS = b1_adrRegMAS[0];
                                        B1instr.RS = b1_adrRegMAS[1];
                                        if (b1_adrRegMAS.Count() == 3)
                                        {
                                            B1instr.offsetS = b1_adrRegMAS[2];
                                        }
                                    }  

                                    //destinstion
                                    List<String> b1_adrRegMAD = getAddressingMode(values[2].Trim());
                                    if ((b1_adrRegMAD != null))
                                    {
                                        B1instr.MAD = b1_adrRegMAD[0];
                                        B1instr.RD = b1_adrRegMAD[1];
                                        if (b1_adrRegMAD.Count() == 3)
                                        {
                                            B1instr.offsetD = b1_adrRegMAD[2];
                                        }
                                    }       
                                    break;

                                case "B2":
                                    B2Instruction B2instr = new B2Instruction(result.First().Value);
                                    binaryInstructions.Add(B2instr, result.First().Key);

                                    //destinstion
                                    List<String> b2_adrRegMAD = getAddressingMode(values[1].Trim());
                                    if ((b2_adrRegMAD != null))
                                    {
                                        B2instr.MAD = b2_adrRegMAD[0];
                                        B2instr.RD = b2_adrRegMAD[1];
                                        if (b2_adrRegMAD.Count() == 3)
                                        {
                                            B2instr.offsetD = b2_adrRegMAD[2];
                                        }
                                    }
                                    break;

                                case "B3":
                                    B3Instruction B3instr = new B3Instruction(result.First().Value);
                                    binaryInstructions.Add(B3instr, result.First().Key);

                                    //TODO: check intervals
                                    B3instr.offset = getBinaryOffset(values[1].Trim());
                                    break;

                                case "B4":
                                    B4Instruction B4instr = new B4Instruction(result.First().Value);
                                    binaryInstructions.Add(B4instr, result.First().Key);
                                    break;
                                default:
                                    //show error message
                                    break;
                            }
                        }
                       else
                        {
                            //TODO: Return not an existing instruction
                            //return null;
                        } 

                        
                        //instructions.Add(instruction);
                        //this.asmCode.Text += "\n" + g;
                    /*}
                    else {
                        //TO DO: not correct code, try again
                        //check if comment
                    }*/
                }
            }

            /*foreach (KeyValuePair<Instruction, string> temp4 in binaryInstructions)
            {
                this.asmCode.Text += "\n" + temp4.Value + " " + temp4.Key;               
            }*/
        }

        public List<String> getAddressingMode(String operand)
        {
            operand = operand.ToUpper();

            List<String> result = new List<String>();

            String indexedPattern = @"[0-9]{1,3}\(R[0-9]{1,2}\)";
            Regex indexedRegex = new Regex(indexedPattern, RegexOptions.IgnoreCase);

            String indirectPattern = @"\(R[0-9]{1,2}\)";
            Regex indirectRegex = new Regex(indirectPattern, RegexOptions.IgnoreCase);

            String directPattern = @"R[0-9]{1,2}";
            Regex directRegex = new Regex(directPattern, RegexOptions.IgnoreCase);

            String immediatPattern = @"[0-9]{1,3}";
            Regex immediatRegex = new Regex(immediatPattern, RegexOptions.IgnoreCase);

            //check if indexed addressing mode
            Match m = indexedRegex.Match(operand);
            if (m.Success)
            {
                String[] values = operand.Split(new char[] {'(', ')'});           
                String offset = getBinaryOffset(values[0]);
                String register = getRegister(values[1]);

                String addressingMode;
                addressingModes.TryGetValue("AX", out addressingMode);
                result.Add(addressingMode);
                result.Add(register);
                result.Add(offset);
                return result;
            }
            else
            {
                m = indirectRegex.Match(operand);
                if (m.Success)
                {
                    String[] values = operand.Split(new char[] { '(', ')' });
                    String register = getRegister(values[1]);

                    String addressingMode;
                    addressingModes.TryGetValue("AI", out addressingMode);
                    result.Add(addressingMode);
                    result.Add(register);
                    return result;
                }
                else
                {
                    m = directRegex.Match(operand);
                    if (m.Success)
                    {
                        String register = getRegister(operand);
                        String addressingMode;

                        addressingModes.TryGetValue("AD", out addressingMode);
                        result.Add(addressingMode);
                        result.Add(register);
                        return result;
                    }
                    else
                    {
                        m = immediatRegex.Match(operand);
                        if (m.Success)
                        {
                            String valImm = getBinaryOffset(operand);
                            String register = "0000";
                            String addressingMode;

                            addressingModes.TryGetValue("AM", out addressingMode);
                            result.Add(addressingMode);
                            result.Add(register);
                            result.Add(valImm);
                            return result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }         
        }
     
        public String getRegister(String registerName)
        {
            foreach (KeyValuePair<String, String> temp in registers)
            {
                if (temp.Key == registerName)
                {
                    return temp.Value;
                }
            }
            return null;
        }

        public String getBinaryOffset(String offset)
        {
            int integerOffset = Convert.ToInt16(offset);
            return Convert.ToString(integerOffset, 2);
        }



    }
}
