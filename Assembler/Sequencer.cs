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

            GraphicChanger graphicChanger = new GraphicChanger();
            graphicChanger.Pd0s();
        }

        private void decodeSBUS(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 sbus = (UInt16)((MIRCode & 515396075520) >> 35);
            switch (sbus)
            {
                case 0x1: //PdIRs
                    graphicChanger.PdIRs();
                    //SBUS = (UInt16)(IR & 0x00FF);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x2: //PdFLAGs		
                    graphicChanger.PdFLAGs();
                    //SBUS = (UInt16)(FLAG);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x3: //PdSPs
                    graphicChanger.PdSPs();
                    //SBUS = (UInt16)(SP);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x4: //PdTs
                    graphicChanger.PdTs();
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
                    graphicChanger.PdPCs();
                    //SBUS = (UInt16)(PC);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x7: //PdIVRs	
                    graphicChanger.PdIVRs();
                    //SBUS = (UInt16)(IVR);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x8: //PdADRs		
                    graphicChanger.PdADRs();
                    //SBUS = (UInt16)(ADR);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0x9: //PdMDRs	
                    graphicChanger.PdMDRs();
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
                            graphicChanger.PdR1();
                            break;
                        case 0x2:
                            graphicChanger.PdR2();
                            break;
                        case 0x3:
                            graphicChanger.PdR3();
                            break;
                        case 0x4:
                            graphicChanger.PdR4();
                            break;
                        case 0x5:
                            graphicChanger.PdR5();
                            break;
                        case 0x6:
                            graphicChanger.PdR6();
                            break;
                        case 0x7:
                            graphicChanger.PdR7();
                            break;
                        case 0x8:
                            graphicChanger.PdR8();
                            break;
                        case 0x9:
                            graphicChanger.PdR9();
                            break;
                        case 0xA:
                            graphicChanger.PdR10();
                            break;
                        case 0xB:
                            graphicChanger.PdR11();
                            break;
                        case 0xC:
                            graphicChanger.PdR12();
                            break;
                        case 0xD:
                            graphicChanger.PdR13();
                            break;
                        case 0xE:
                            graphicChanger.PdR14();
                            break;
                        case 0xF:
                            graphicChanger.PdR15();
                            break;
                        default:
                            graphicChanger.PdR0();
                            break;
                    }

                    graphicChanger.PdRGs();
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xB: //Pd0s
                    graphicChanger.Pd0s();
                    //SBUS = 0;
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xC: //Pd-1s
                    graphicChanger.Pdminus1s();
                    //Int16 v = -1;
                    //SBUS = (UInt16)v;
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                case 0xD: //Pd1s
                    graphicChanger.Pd1s();
                    //SBUS = (UInt16)(1);
                    //SBUSlabel.Text = Convert_Binary(SBUS.ToString(), 16);
                    break;

                default:
                    break;
            }
        }

        private void decodeDBUS(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 dbus = (UInt16)((MIRCode & 32212254720) >> 31);
            switch (dbus)
            {
                case 0x1: //PdIR[Off]d
                    graphicChanger.PdIRd();
                    //DBUS = (UInt16)(IR & 0x00FF);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x2: //PdFLAGd
                    graphicChanger.PdFLAGd();
                    //DBUS = (UInt16)(FLAG);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x3: //PdSPd
                    graphicChanger.PdSPd();
                    //DBUS = (UInt16)(SP);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x4: //PdTd
                    graphicChanger.PdTd();
                    //DBUS = (UInt16)(T);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x5: //PdnTd
                    //PdnTd();
                    //UInt16 t = T;
                    //DBUS = (UInt16)(~t);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x6: //PdPCd
                    graphicChanger.PdPCd();
                    //DBUS = (UInt16)(PC);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x7: //PdIVRd
                    graphicChanger.PdIVRd();
                    //DBUS = (UInt16)(IVR);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x8: //PdADRd
                    graphicChanger.PdADRd();
                    //DBUS = (UInt16)(ADR);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0x9: //PdMDRd
                    graphicChanger.PdMDRd();
                    //DBUS = (UInt16)(MDR);
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0xA: //PdRGd
                    //int nr_reg = IR & 0x000F; //preiau reg din camp RS din IR
                    //DBUS = Convert.ToUInt16(R[nr_reg]);

                    var  nr_reg = 1;
                    switch (nr_reg)
                    {
                        case 0x1:
                            graphicChanger.PdR1();
                            break;
                        case 0x2:
                            graphicChanger.PdR2();
                            break;
                        case 0x3:
                            graphicChanger.PdR3();
                            break;
                        case 0x4:
                            graphicChanger.PdR4();
                            break;
                        case 0x5:
                            graphicChanger.PdR5();
                            break;
                        case 0x6:
                            graphicChanger.PdR6();
                            break;
                        case 0x7:
                            graphicChanger.PdR7();
                            break;
                        case 0x8:
                            graphicChanger.PdR8();
                            break;
                        case 0x9:
                            graphicChanger.PdR9();
                            break;
                        case 0xA:
                            graphicChanger.PdR10();
                            break;
                        case 0xB:
                            graphicChanger.PdR11();
                            break;
                        case 0xC:
                            graphicChanger.PdR12();
                            break;
                        case 0xD:
                            graphicChanger.PdR13();
                            break;
                        case 0xE:
                            graphicChanger.PdR14();
                            break;
                        case 0xF:
                            graphicChanger.PdR15();
                            break;
                        default:
                            graphicChanger.PdR0();
                            break;
                    }
                    graphicChanger.PdRGd();
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                case 0xB: //Pd0d
                    graphicChanger.Pd0d();
                    //DBUS = 0;
                    //DBUSlabel.Text = Convert_Binary(DBUS.ToString(), 16);
                    break;

                default: //none
                    break;
            }
        }

        private void decodeRBUS()
        {

        }

        private void decodeALU()
        {

        }
    }
}
