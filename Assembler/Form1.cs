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

        public static mainForm currentForm = null;

        //given files
        String assemblyCodeFile = "assembly_code.asm";
        String instructionsFile = "codificare_instructiuni.csv";
        String registersAndAddressingModesFile = "registri_moduri_adresare.csv";
        String binaryInstructionsFile = "instructiuni_codificate_binar.bin";
        String microcodeText = "microcode_text.txt";
        String microcodeBinaryTextFile = "microcode_binar_textfile.txt";
        String microcodeBinaryFile = "microcode_binar_binfile.bin";

        //given code
        List<String> assemblyCodeLines = new List<String>();
        List<String> microCodeLines = new List<String>();
        List<String> microCodeBinaryLines = new List<String>();

        //not used
        List<Instruction> instructions = new List<Instruction>();

        //the 01 only instructions
        List<Instruction> binaryInstructionss = new List<Instruction>(); //-- not used

        //save instruction and its type
        Dictionary<Instruction, string> binaryInstructions = new Dictionary<Instruction, string>();

        //dictionaries to keep the intruction and its binary  --not used
        Dictionary<string, string> B1 = new Dictionary<string, string>();
        Dictionary<string, string> B2 = new Dictionary<string, string>();
        Dictionary<string, string> B3 = new Dictionary<string, string>();
        Dictionary<string, string> B4 = new Dictionary<string, string>();

        //dictionaries for registers and addressing modes
        Dictionary<string, string> registers = new Dictionary<string, string>();
        Dictionary<string, string> addressingModes = new Dictionary<string, string>();

        FileHelper fileParser = new FileHelper();
        InstructionHelper instrHelper = new InstructionHelper();
        Sequencer sequencer = new Sequencer();

        //Thread


        bool assemblySuccess = true;
        bool stepByStep = false;

        //sequencer vars
        List<UInt64> MPM = new List<ulong>();

        public mainForm()
        {
            InitializeComponent();

            currentForm = this;
        }

    private void getDefaultInstructionsRegistersAddressingModes()
        {
            // fileParser.showAsmCode(assemblyCodeFile, assemblyCodeLines);
            fileParser.createBinaryInstructionsCodes(instructionsFile);
            fileParser.createBinaryRegistersAndAddressingModesCodes(registersAndAddressingModesFile, registers, addressingModes);

            instrHelper.B1 = fileParser.B1;
            instrHelper.B2 = fileParser.B2;
            instrHelper.B3 = fileParser.B3;
            instrHelper.B4 = fileParser.B4;

            instrHelper.registers = registers;
            instrHelper.addressingModes = addressingModes;
        }


        private void parseAssemblyCode()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
          
            foreach (var line in assemblyCodeLines)
            {
                if (line.ToUpper().Contains(".DATA") == false && line.ToUpper().Contains(".CODE") == false && line.ToUpper().Contains("END") == false)
                {
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
                                    List<String> b1_adrRegMAS = instrHelper.getAddressingMode(values[1].Trim());

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
                                    List<String> b1_adrRegMAD = instrHelper.getAddressingMode(values[2].Trim());
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
                                    List<String> b2_adrRegMAD = instrHelper.getAddressingMode(values[1].Trim());
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
                                    B3instr.offset = instrHelper.getBinaryOffset(values[1].Trim());
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
                            assemblySuccess = false;
                            //TODO: Return not an existing instruction
                            //return null;
                        } 
                }
            }
        }

        private void asmButton_Click(object sender, EventArgs e)
        {
            fileParser.showAsmCode(assemblyCodeFile, assemblyCodeLines);
            foreach(String instruction in assemblyCodeLines)
            {
                asmCode.Text += "\n" + instruction;
            }

        }

        private void assembleButton_Click(object sender, EventArgs e)
        {
            getDefaultInstructionsRegistersAddressingModes();
            parseAssemblyCode();
            fileParser.writeBinaryFile(binaryInstructionsFile, binaryInstructions);

            if(assemblySuccess == true)
            {
                messagesTextBox.Text += "Assembly process was a great success.\r\n";
            }
            else
            {
                messagesTextBox.Text += "Assembly process was a failure.\r\n";
            }
            
        }

        private void microcodeButton_Click(object sender, EventArgs e)
        {
            microCodeLines = fileParser.readMicrocode(microcodeText);
            fileParser.writeBinaryMicrocode(microcodeBinaryTextFile, microcodeBinaryFile);
            MPM = fileParser.loadMicrocodeToMPM(microcodeBinaryFile);

            if (MPM != null)
            {
                messagesTextBox.Text += "Microcode loading was a great success.\r\n";
            }
            else
            {
                messagesTextBox.Text += "Microcode loading was a failure.\r\n";
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            
            sequencer.runSimulation();

        }

        private void runStepByStepButton_Click(object sender, EventArgs e)
        {
            stepByStep = true;
            sequencer.runSimulationStepByStep();
        }
    }
}
