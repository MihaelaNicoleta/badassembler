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
            decodeSBUS(391036338689);
            //graphicChanger.Pd0s();
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
                            graphicChanger.colorR1();
                            break;
                        case 0x2:
                            graphicChanger.colorR2();
                            break;
                        case 0x3:
                            graphicChanger.colorR3();
                            break;
                        case 0x4:
                            graphicChanger.colorR4();
                            break;
                        case 0x5:
                            graphicChanger.colorR5();
                            break;
                        case 0x6:
                            graphicChanger.colorR6();
                            break;
                        case 0x7:
                            graphicChanger.colorR7();
                            break;
                        case 0x8:
                            graphicChanger.colorR8();
                            break;
                        case 0x9:
                            graphicChanger.colorR9();
                            break;
                        case 0xA:
                            graphicChanger.colorR10();
                            break;
                        case 0xB:
                            graphicChanger.colorR11();
                            break;
                        case 0xC:
                            graphicChanger.colorR12();
                            break;
                        case 0xD:
                            graphicChanger.colorR13();
                            break;
                        case 0xE:
                            graphicChanger.colorR14();
                            break;
                        case 0xF:
                            graphicChanger.colorR15();
                            break;
                        default:
                            graphicChanger.colorR0();
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
                            graphicChanger.colorR1();
                            break;
                        case 0x2:
                            graphicChanger.colorR2();
                            break;
                        case 0x3:
                            graphicChanger.colorR3();
                            break;
                        case 0x4:
                            graphicChanger.colorR4();
                            break;
                        case 0x5:
                            graphicChanger.colorR5();
                            break;
                        case 0x6:
                            graphicChanger.colorR6();
                            break;
                        case 0x7:
                            graphicChanger.colorR7();
                            break;
                        case 0x8:
                            graphicChanger.colorR8();
                            break;
                        case 0x9:
                            graphicChanger.colorR9();
                            break;
                        case 0xA:
                            graphicChanger.colorR10();
                            break;
                        case 0xB:
                            graphicChanger.colorR11();
                            break;
                        case 0xC:
                            graphicChanger.colorR12();
                            break;
                        case 0xD:
                            graphicChanger.colorR13();
                            break;
                        case 0xE:
                            graphicChanger.colorR14();
                            break;
                        case 0xF:
                            graphicChanger.colorR15();
                            break;
                        default:
                            graphicChanger.colorR0();
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

        private void decodeRBUS(Int64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 rbus = (UInt16)((MIRCode & 125829120) >> 23);
            switch (rbus)
            {
                case 0x1: //PmFLAG
                    graphicChanger.PmFLAG();
                    //FLAG = RBUS;
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;

                case 0x2: //PmRG
                    //int nr_reg = IR & 0x000F;
                    //R[nr_reg] = RBUS;
                    //PmRGline.BorderColor = Color.Red;

                    var nr_reg = 1;
                    switch (nr_reg)
                    {
                        case 0:
                            //R0text.Text = Convert_Binary(R[0].ToString(), 16);
                            graphicChanger.colorR0();
                            break;
                        case 1:
                            //R1text.Text = Convert_Binary(R[1].ToString(), 16);
                            graphicChanger.colorR1();
                            break;
                        case 2:
                            //R2text.Text = Convert_Binary(R[2].ToString(), 16);
                            graphicChanger.colorR2();
                            break;
                        case 3:
                            //R3text.Text = Convert_Binary(R[3].ToString(), 16);
                            graphicChanger.colorR3();
                            break;
                        case 4:
                            //R4text.Text = Convert_Binary(R[4].ToString(), 16);
                            graphicChanger.colorR4();
                            break;
                        case 5:
                            //R5text.Text = Convert_Binary(R[5].ToString(), 16);
                            graphicChanger.colorR5();
                            break;
                        case 6:
                            //R6text.Text = Convert_Binary(R[6].ToString(), 16);
                            graphicChanger.colorR6();
                            break;
                        case 7:
                            //R7text.Text = Convert_Binary(R[7].ToString(), 16);
                            graphicChanger.colorR7();
                            break;
                        case 8:
                            //R8text.Text = Convert_Binary(R[8].ToString(), 16);
                            graphicChanger.colorR8();
                            break;
                        case 9:
                            //R9text.Text = Convert_Binary(R[9].ToString(), 16);
                            graphicChanger.colorR9();
                            break;
                        case 10:
                            //R10text.Text = Convert_Binary(R[10].ToString(), 16);
                            graphicChanger.colorR10();
                            break;
                        case 11:
                            //R11text.Text = Convert_Binary(R[11].ToString(), 16);
                            graphicChanger.colorR11();
                            break;
                        case 12:
                            //R12text.Text = Convert_Binary(R[12].ToString(), 16);
                            graphicChanger.colorR12();
                            break;
                        case 13:
                            //R13text.Text = Convert_Binary(R[13].ToString(), 16);
                            graphicChanger.colorR13();
                            break;
                        case 14:
                            //R14text.Text = Convert_Binary(R[14].ToString(), 16);
                            graphicChanger.colorR14();
                            break;
                        case 15:
                            //R15text.Text = Convert_Binary(R[15].ToString(), 16);
                            graphicChanger.colorR15();
                            break;
                    }
                    break;

                case 0x3: //PmSP
                    graphicChanger.PmSP();
                    //SP = RBUS;
                    //SPtext.Text = Convert_Binary(SP.ToString(), 16);
                    break;

                case 0x4: //PmT
                    graphicChanger.PmT();
                    //T = RBUS;
                    //Ttext.Text = Convert_Binary(T.ToString(), 16);
                    break;

                case 0x5: //PmPC
                    graphicChanger.PmPC();
                    //PC = RBUS;
                    //PCtext.Text = Convert_Binary(PC.ToString(), 16);
                    break;

                case 0x6: //PmIVR
                    graphicChanger.PmIVR();
                    //IVR = RBUS;
                    //IVRtext.Text = Convert_Binary(IVR.ToString(), 16);
                    break;

                case 0x7: //PmADR
                    graphicChanger.PmADR();
                    //ADR = RBUS;
                    //ADRtext.Text = Convert_Binary(ADR.ToString(), 16);
                    break;

                case 0x8: //PmMDR
                    graphicChanger.PmMDR();
                    //MDR = RBUS;
                    //MDRtext.Text = Convert_Binary(MDR.ToString(), 16);
                    break;

                default: //none
                    break;
            }
        }

        private void decodeALU()
        {

        }

        private void decodeOtherOperations(Int64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 otherOp = (UInt16)((MIRCode & 8126464) >> 18);
            switch (otherOp)
            {
                case 0x1: //PdCOND
                    //if (RBUS == 0) // rezultat 0 => setez bitul Z
                    //{
                    //    FLAG = (UInt16)(FLAG | 0x0004);
                    //}
                    //if (RBUS >> 15 == 0x1) // setez bit de semn S
                    //{
                    //    FLAG = (UInt16)(FLAG | 0x0002);
                    //}
                    graphicChanger.PdCond();
                    //FLAG = (UInt16)(FLAG | (Carry << 3));
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x2: //CIN + PdCOND
                    //if (RBUS == 0) // rezultat 0 => setez bitul Z
                    //{
                    //    FLAG = (UInt16)(FLAG | 0x0004);
                    //}
                    //if (RBUS >> 15 == 0x1) // setez bit de semn S
                    //{
                    //    FLAG = (UInt16)(FLAG | 0x0002);
                    //}
                    graphicChanger.PdCond();
                    //FLAG = (UInt16)(FLAG | (Carry << 3));
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x3: //+2SP
                    graphicChanger.plusSP();
                    //SP += 2;
                    //SPtext.Text = Convert_Binary(SP.ToString(), 16);
                    break;
                case 0x4: //-2SP
                    graphicChanger.minusSP();
                    //SP -= 2;
                    //SPtext.Text = Convert_Binary(SP.ToString(), 16);
                    break;
                case 0x5: //+2PC
                    graphicChanger.plusPC();
                    //PC += 2;
                    //PCtext.Text = Convert_Binary(PC.ToString(), 16);
                    break;
                case 0x6: //A(0)BPO
                    break;
                case 0x7: //A(0)C
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0xFFF7);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x8: //A(1)C
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x0008);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x9: //A(0)V
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0xFFFE);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xA: //A(1)V
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x0001);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xB: //A(0)Z
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0xFFFB);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xC: //A(1)Z
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x0004);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xD: //A(0)S
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0xFFFD);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xE: //A(1)S
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x0002);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0xF: //A(0)CVZS
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0xFFF0);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x10: //A(1)CVZS
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x000F);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x11: //A(0)BVI
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG & 0x0FF7F);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                case 0x12: //A(1)BVI
                    graphicChanger.colorFlags();
                    //FLAG = (UInt16)(FLAG | 0x0080);
                    //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                    break;
                default: //none
                    break;
            }
        }
    }
}
