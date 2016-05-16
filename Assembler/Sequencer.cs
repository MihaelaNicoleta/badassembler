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

        public int IR;

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
                    break;

                case 0x2: //PdFLAGs		
                    graphicChanger.PdFLAGs();
                    break;

                case 0x3: //PdSPs
                    graphicChanger.PdSPs();
                    break;

                case 0x4: //PdTs
                    graphicChanger.PdTs();
                    break;

                case 0x5: //PdnotTs	
                    //graphicChanger.PdnotTs();
                    break;

                case 0x6: //PdPCs	
                    graphicChanger.PdPCs();
                    break;

                case 0x7: //PdIVRs	
                    graphicChanger.PdIVRs();
                    break;

                case 0x8: //PdADRs		
                    graphicChanger.PdADRs();
                    break;

                case 0x9: //PdMDRs	
                    graphicChanger.PdMDRs();
                    break;

                case 0xA: //PdRGs		
                    //int nr_reg = (IR & 0x03C0) >> 6; //preiau reg din camp RS din IR
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
                    break;

                case 0xB: //Pd0s
                    graphicChanger.Pd0s();
                    break;

                case 0xC: //Pd-1s
                    graphicChanger.Pdminus1s();
                    break;

                case 0xD: //Pd1s
                    graphicChanger.Pd1s();
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
                case 0x1: //PdIR[Offset]d
                    graphicChanger.PdIRd();
                    break;

                case 0x2: //PdFLAGd
                    graphicChanger.PdFLAGd();
                    break;

                case 0x3: //PdSPd
                    graphicChanger.PdSPd();
                    break;

                case 0x4: //PdTd
                    graphicChanger.PdTd();
                    break;

                case 0x5: //PdnotTd
                    //graphicChanger.PdnTd();
                    break;

                case 0x6: //PdPCd
                    graphicChanger.PdPCd();
                    break;

                case 0x7: //PdIVRd
                    graphicChanger.PdIVRd();
                    break;

                case 0x8: //PdADRd
                    graphicChanger.PdADRd();
                    break;

                case 0x9: //PdMDRd
                    graphicChanger.PdMDRd();
                    break;

                case 0xA: //PdRGd
                    //int nr_reg = IR & 0x000F; //preiau reg din camp RS din IR

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
                    break;

                case 0xB: //Pd0d
                    graphicChanger.Pd0d();
                    break;

                default: //none
                    break;
            }
        }

        private void decodeRBUS(Int64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 rbus = (UInt16)((MIRCode & 125829120) >> 23);

            ushort value = 127;

            switch (rbus)
            {
                case 0x1: //PmFLAG
                    graphicChanger.PmFLAG();
                    break;

                case 0x2: //PmRG
                    //int nr_reg = IR & 0x000F;
                    //R[nr_reg] = RBUS;
                    graphicChanger.PmRG();

                   

                    var nr_reg = 1;
                    switch (nr_reg)
                    {
                        case 0:
                            graphicChanger.colorR0();
                            graphicChanger.setR0(value);
                            break;
                        case 1:                            
                            graphicChanger.colorR1();
                            graphicChanger.setR1(value);
                            break;
                        case 2:                            
                            graphicChanger.colorR2();
                            graphicChanger.setR2(value);
                            break;
                        case 3:                            
                            graphicChanger.colorR3();
                            graphicChanger.setR3(value);
                            break;
                        case 4:
                            graphicChanger.colorR4();
                            graphicChanger.setR4(value);
                            break;
                        case 5:                            
                            graphicChanger.colorR5();
                            graphicChanger.setR5(value);
                            break;
                        case 6:
                            graphicChanger.colorR6();
                            graphicChanger.setR6(value);
                            break;
                        case 7:
                            graphicChanger.colorR7();
                            graphicChanger.setR7(value);
                            break;
                        case 8:
                            graphicChanger.colorR8();
                            graphicChanger.setR8(value);
                            break;
                        case 9:
                            graphicChanger.colorR9();
                            graphicChanger.setR9(value);
                            break;
                        case 10:
                            graphicChanger.colorR10();
                            graphicChanger.setR10(value);
                            break;
                        case 11:
                            graphicChanger.colorR11();
                            graphicChanger.setR11(value);
                            break;
                        case 12:
                            graphicChanger.colorR12();
                            graphicChanger.setR12(value);
                            break;
                        case 13:
                            graphicChanger.colorR13();
                            graphicChanger.setR13(value);
                            break;
                        case 14:
                            graphicChanger.colorR14();
                            graphicChanger.setR14(value);
                            break;
                        case 15:
                            graphicChanger.colorR15();
                            graphicChanger.setR15(value);
                            break;
                    }
                    break;

                case 0x3: //PmSP
                    graphicChanger.PmSP();
                    graphicChanger.setSP(value);
                    //SP = RBUS;
                    break;

                case 0x4: //PmT
                    graphicChanger.PmT();
                    graphicChanger.setT(value);
                    //T = RBUS;
                    break;

                case 0x5: //PmPC
                    graphicChanger.PmPC();
                    graphicChanger.setPC(value);
                    //PC = RBUS;
                    break;

                case 0x6: //PmIVR
                    graphicChanger.PmIVR();
                    graphicChanger.setIVR(value);
                    //IVR = RBUS;
                    break;

                case 0x7: //PmADR
                    graphicChanger.PmADR();
                    graphicChanger.setADR(value);
                    //ADR = RBUS;
                    break;

                case 0x8: //PmMDR
                    graphicChanger.PmMDR();
                    graphicChanger.setMDR(value);
                    //MDR = RBUS;
                    break;

                default: //none
                    break;
            }
        }

        private void decodeALU()
        {
            UInt16 campALU = (UInt16)((MIR & 0x0000000078000000) >> 27);
            switch (campALU)
            {
                case 0x1: //SUM
                    #region sum
                    if ((((UInt16)(MIR & 0x0000000007800000)) >> 18) == 2)
                    { //CIN activat atunci mai adun si val 1
                        try
                        {
                            //ActivateCIN();
                            ALUlabel.Text = "SUM";
                            Alu();
                            RBUS = (UInt16)(SBUS + DBUS + 0x1);
                            RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                        }
                        catch (OverflowException) // daca apare overflow
                        {
                            FLAG = (UInt16)(FLAG | 0X0001); // setez bit overflow V
                            //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                        }
                    }
                    else
                    { //adunare
                        try
                        {
                            ALUlabel.Text = "SUM";
                            Alu();
                            RBUS = (UInt16)(SBUS + DBUS);
                            RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                        }
                        catch (OverflowException)
                        {
                            FLAG = (UInt16)(FLAG | 0X0001); // setez bit V
                            //FLAGtext.Text = Convert_Binary(FLAG.ToString(), 16);
                        }
                    }
                    #endregion
                    break;
                case 0x2: //AND
                    ALUlabel.Text = "AND";
                    Alu();
                    RBUS = (UInt16)(SBUS & DBUS);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x3: //OR
                    ALUlabel.Text = "OR";
                    Alu();
                    RBUS = (UInt16)(SBUS | DBUS);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x4: //XOR
                    ALUlabel.Text = "XOR";
                    Alu();
                    RBUS = (UInt16)(SBUS ^ DBUS);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x5: //ASL
                    ALUlabel.Text = "ASL";
                    Alu();
                    Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    RBUS = (UInt16)(DBUS << 1);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x6: //ASR
                    ALUlabel.Text = "ASR";
                    Alu();
                    Carry = (UInt16)(DBUS & 0x0001);
                    Int16 t = (Int16)((Int16)DBUS >> 1);
                    RBUS = (UInt16)t;
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x7: //LSR
                    ALUlabel.Text = "LSR";
                    Alu();
                    Carry = (UInt16)(DBUS & 0x0001);
                    RBUS = (UInt16)(DBUS >> 1);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x8: //ROL
                    ALUlabel.Text = "ROL";
                    Alu();
                    Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    RBUS = (UInt16)((DBUS << 1) + Carry);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0x9: //ROR 
                    ALUlabel.Text = "ROR";
                    Alu();
                    Carry = (UInt16)(DBUS & 0x0001);
                    bit = (UInt16)(Carry << 15);
                    RBUS = (UInt16)((DBUS >> 1) + bit);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0xA: //RLC
                    ALUlabel.Text = "RLC";
                    Alu();
                    bit = Carry;
                    Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    RBUS = (UInt16)((DBUS << 1) + bit);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0xB: //RRC
                    ALUlabel.Text = "RRC";
                    Alu();
                    bit = Carry;
                    Carry = (UInt16)(DBUS & 0x0001);
                    UInt16 leftBit = (UInt16)(Carry << 15);
                    RBUS = (UInt16)((DBUS >> 1) + (bit << 15));
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                case 0xC: //nDBUS
                    ALUlabel.Text = "nDBUS";
                    Alu();
                    RBUS = (UInt16)(~DBUS);
                    RBUSlabel.Text = Convert_Binary(RBUS.ToString(), 16);
                    break;
                default: //none
                    break;
            }
        }

        private void decodeOtherOperations(Int64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 otherOp = (UInt16)((MIRCode & 8126464) >> 18);

            ushort value = 127;

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
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | (Carry << 3));
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
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | (Carry << 3));
                    break;
                case 0x3: //+2SP
                    graphicChanger.plusSP();
                    graphicChanger.setSP(value);
                    //SP += 2;
                    break;
                case 0x4: //minus2SP
                    graphicChanger.minusSP();
                    graphicChanger.setSP(value);
                    //SP -= 2;
                    break;
                case 0x5: //plus2PC
                    graphicChanger.plusPC();
                    graphicChanger.setPC(value);
                    //PC += 2;
                    break;
                case 0x6: //A(0)BPO
                    break;
                case 0x7: //A(0)C
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0xFFF7);
                    break;
                case 0x8: //A(1)C
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x0008);
                    break;
                case 0x9: //A(0)V
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0xFFFE);
                    break;
                case 0xA: //A(1)V
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x0001);
                    break;
                case 0xB: //A(0)Z
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0xFFFB);
                    break;
                case 0xC: //A(1)Z
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x0004);
                    break;
                case 0xD: //A(0)S
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0xFFFD);
                    break;
                case 0xE: //A(1)S
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x0002);
                    break;
                case 0xF: //A(0)CVZS
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0xFFF0);
                    break;
                case 0x10: //A(1)CVZS
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x000F);
                    break;
                case 0x11: //A(0)BVI
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG & 0x0FF7F);
                    break;
                case 0x12: //A(1)BVI
                    graphicChanger.colorFlags();
                    graphicChanger.setFLAGS(value);
                    //FLAG = (UInt16)(FLAG | 0x0080);
                    break;
                default: //none
                    break;
            }
        }
    }
}
