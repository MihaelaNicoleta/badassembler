using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class Sequencer
    {

        public int step = 0;

        public void runStepSimulation()
        {
            step++;

            switch(step)
            {
                case 1:
                    {

                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
            }
        }

        public void runSimulation()
        {
            GraphicChanger gc = new GraphicChanger();

            gc.Pd0s();
        }

        private void decodeSBUS(UInt64 MIRCode)
        {
            UInt16 sbus = (UInt16)((MIRCode & 515396075520) >> 35);
            switch (sbus)
            {
                case 0x1: //PdIR[Off]s
                    //PdIROffs();
                    //SBUS = (UInt16)(IR & 0x00FF);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x2: //PdFLAGs		
                    //PdFLAGs();
                    //SBUS = (UInt16)(FLAG);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x3: //PdSPs
                    //PdSPs();
                    //SBUS = (UInt16)(SP);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x4: //PdTs
                    //PdTs();
                    //SBUS = (UInt16)(T);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x5: //PdnTs	
                    //PdnTs();
                    //UInt16 t = T;
                    //SBUS = (UInt16)(~t);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x6: //PdPCs	
                    //PdPCs();
                    //SBUS = (UInt16)(PC);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x7: //PdIVRs	
                    //PdIVRs();
                    //SBUS = (UInt16)(IVR);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x8: //PdADRs		
                    //PdADRs();
                    //SBUS = (UInt16)(ADR);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x9: //PdMDRs	
                    //PdMDRs();
                    //SBUS = (UInt16)(MDR);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xA: //PdRGs		
                    //int nr_reg = (IR & 0x03C0) >> 6; //preiau reg din camp RS din IR
                    //SBUS = (UInt16)(R[nr_reg]);
                    var nr_reg = 1;
                    switch (nr_reg)
                    {
                        case 0x1:
                            //PdRg1();
                            break;
                        case 0x2:
                            //PdRg2();
                            break;
                        case 0x3:
                            //PdRg3();
                            break;
                        case 0x4:
                            // PdRg4();
                            break;
                        case 0x5:
                            //PdRg5();
                            break;
                        case 0x6:
                            //PdRg6();
                            break;
                        case 0x7:
                            //PdRg7();
                            break;
                        case 0x8:
                            //PdRg8();
                            break;
                        case 0x9:
                            //PdRg9();
                            break;
                        case 0xA:
                            //PdRg10();
                            break;
                        case 0xB:
                            //PdRg11();
                            break;
                        case 0xC:
                            //PdRg12();
                            break;
                        case 0xD:
                            //PdRg13();
                            break;
                        case 0xE:
                            // PdRg14();
                            break;
                        case 0xF:
                            // PdRg15();
                            break;
                        default:
                            //PdRg0();
                            break;
                    }
                    break;
                case 0xB: //Pd0s
                    //Pd0s();
                    //SBUS = 0;
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xC: //Pd-1s
                    //Pdm1s();
                    //Int16 v = -1;
                    //SBUS = (UInt16)v;
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xD: //Pd1s
                    //Pd1s();
                    //SBUS = (UInt16)(1);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                default:
                    break;
            }
        }

        private void decodeDBUS()
        {

        }

        private void decodeRBUS()
        {

        }

        private void decodeALU()
        {

        }
    }
}
