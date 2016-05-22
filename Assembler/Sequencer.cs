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
        public int FLAG;


        public List<UInt64> MPM = new List<ulong>();

        public int MAR = 0;

        public UInt64 index;
        public UInt16 classs;
        public bool isInterrupt = false;


        public void runSimulationStepByStep()
        {
            step++;

            GraphicChanger graphicChanger = new GraphicChanger();

            ulong MIR = MPM[MAR];

            UInt16 shift = (UInt16)(MIR & 255);

            //ulong MIR = 391036338689;

            switch(step)
            {
                case 1:
                    {
                        decodeSBUS(MIR);
                        graphicChanger.selectMicrocodeLine(MAR);

                    }
                    break;

                case 2:
                    {
                        decodeDBUS(MIR);
                    }
                    break;

                case 3:
                    {
                        decodeALU(MIR);
                    }
                    break;

                case 4:
                    {
                        decodeRBUS(MIR);
                    }
                    break;
                case 5:
                    {
                        decodeOtherOperations(MIR);
                    }
                    break;

                case 6:
                    {
                        //decodeOtherOperations(MIR);

                    }
                    break;

                case 7:
                    {
                        var g = decodeSuccesor(MIR);

                        if (g == 1) // MAR = ADRESA_SALT + INDEX
                        {
                            switch ((MIR & 3584) >> 9)
                            {

                                case 0x0: //INDEX0 
                                    MAR = shift;
                                    break;
                                case 0x1: //INDEX1
                                    UInt16 classss = getCl();

                                    switch (classss)
                                    {
                                        case 0:
                                            MAR = shift;
                                            break;
                                        case 1:
                                            MAR = (UInt16)(shift + 0x1);
                                            break;
                                        case 2:
                                            MAR = (UInt16)(shift + 0x3);
                                            break;
                                        case 3:
                                            MAR = (UInt16)(shift + 0x2);
                                            break;
                                    }
                                    break;
                                case 0x2: //INDEX2
                                    index = (UInt16)((IR & 3072) >> 9);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                case 0x3: //INDEX3
                                    index = (UInt16)((IR & 48) >> 3);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                case 0x4: //INDEX4
                                    index = (UInt16)((IR & 28672) >> 11);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                case 0x5: //INDEX5
                                    index = (UInt16)((IR & 1984) >> 5);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                case 0x6: //INDEX6
                                    index = (UInt16)((IR & 7936) >> 7);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                case 0x7: //INDEX7
                                    index = (UInt16)((IR & 31) << 1);
                                    MAR = (UInt16)(shift + index);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        { // MAR = MAR + 1
                            //MAR = (UInt16)(MAR + 0x1);
                            MAR++;
                        }                        
                        graphicChanger.resetGraphicToDefault();
                        step = 0;

                    }
                    break;

                default:
                    break;    

            }
        }

        public void runSimulation()
        {

            GraphicChanger graphicChanger = new GraphicChanger();

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
                    int register = (IR & 960) >> 6; 
                    switch (register)
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
                    var register = IR & 15;

                    switch (register)
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

        private void decodeRBUS(UInt64 MIRCode)
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
                    var register = IR & 15;
                    graphicChanger.PmRG();                   

                    switch (register)
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

        private void decodeALU(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 alu = (UInt16)((MIRCode & 2013265920) >> 27);

            ushort value = 127;
            switch (alu)
            {
                case 0x1: //SUM
                    #region sum
                    if ((((UInt16)(MIRCode & 2013265920)) >> 18) == 2)
                    { //CIN activat atunci mai adun si val 1
                        try
                        {
                            //ActivateCIN();
                            graphicChanger.setALUOperation("SUM");
                            graphicChanger.colorAlu();              
                            //RBUS = (UInt16)(SBUS + DBUS + 0x1);                    
                        }
                        catch (OverflowException) // daca apare overflow
                        {
                            //FLAG = (UInt16)(FLAG | 0X0001); // setez bit overflow V
                            graphicChanger.setFLAGS(value);
                        }
                    }
                    else
                    { //adunare
                        try
                        {
                            graphicChanger.setALUOperation("SUM");
                            graphicChanger.colorAlu();
                            //RBUS = (UInt16)(SBUS + DBUS);
                        }
                        catch (OverflowException)
                        {
                            //FLAG = (UInt16)(FLAG | 0X0001); // setez bit V
                            graphicChanger.setFLAGS(value);
                        }
                    }
                    #endregion
                    break;
                case 0x2: //AND
                    graphicChanger.setALUOperation("AND");
                    graphicChanger.colorAlu();
                    //RBUS = (UInt16)(SBUS & DBUS);
                    break;
                case 0x3: //OR
                    graphicChanger.setALUOperation("OR");
                    graphicChanger.colorAlu();
                    //RBUS = (UInt16)(SBUS | DBUS);
                    break;
                case 0x4: //XOR
                    graphicChanger.setALUOperation("XOR");
                    graphicChanger.colorAlu();
                    //RBUS = (UInt16)(SBUS ^ DBUS);
                    break;
                case 0x5: //ASL
                    graphicChanger.setALUOperation("ASL");
                    graphicChanger.colorAlu();
                    //Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    //RBUS = (UInt16)(DBUS << 1);
                    break;
                case 0x6: //ASR
                    graphicChanger.setALUOperation("ASR");
                    graphicChanger.colorAlu();
                    //Carry = (UInt16)(DBUS & 0x0001);
                    //Int16 t = (Int16)((Int16)DBUS >> 1);
                    //RBUS = (UInt16)t;
                    break;
                case 0x7: //LSR
                    graphicChanger.setALUOperation("LSR");
                    graphicChanger.colorAlu();
                    //Carry = (UInt16)(DBUS & 0x0001);
                    //RBUS = (UInt16)(DBUS >> 1);
                    break;
                case 0x8: //ROL
                    graphicChanger.setALUOperation("ROL");
                    graphicChanger.colorAlu();
                    //Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    //RBUS = (UInt16)((DBUS << 1) + Carry);
                    break;
                case 0x9: //ROR 
                    graphicChanger.setALUOperation("ROR");
                    graphicChanger.colorAlu();
                    //Carry = (UInt16)(DBUS & 0x0001);
                    //bit = (UInt16)(Carry << 15);
                    //RBUS = (UInt16)((DBUS >> 1) + bit);
                    break;
                case 0xA: //RLC
                    graphicChanger.setALUOperation("RLC");
                    graphicChanger.colorAlu();
                    //bit = Carry;
                    //Carry = (UInt16)((DBUS & 0x8000) >> 15);
                    //RBUS = (UInt16)((DBUS << 1) + bit);
                    break;
                case 0xB: //RRC
                    graphicChanger.setALUOperation("RRC");
                    graphicChanger.colorAlu();
                    //bit = Carry;
                    //Carry = (UInt16)(DBUS & 0x0001);
                    //UInt16 leftBit = (UInt16)(Carry << 15);
                    //RBUS = (UInt16)((DBUS >> 1) + (bit << 15));
                    break;
                case 0xC: //nDBUS
                    graphicChanger.setALUOperation("nDBUS");
                    graphicChanger.colorAlu();
                    //RBUS = (UInt16)(~DBUS);
                    break;
                default: //none
                    break;
            }
        }

        private void decodeOtherOperations(UInt64 MIRCode)
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

        private void decodeMemoryOperation(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 memOperation = (UInt16)((MIRCode & 196608) >> 16);

            ushort value = 127;

            switch (memOperation)
            {
                case 0x1: //IFCH
                    //contor++;
                    graphicChanger.IFCH();
                    graphicChanger.setIR(value);
                    break;
                case 0x2: //READ
                    graphicChanger.Read();
                    graphicChanger.setMDR(value);
                    break;
                case 0x3: //WRITE
                    graphicChanger.Write();
                    break;
                default: 
                    break;
            }
        }

        private UInt16 getCl1()
        {
            UInt16 IR15 = (UInt16)((IR & 0x8000) >> 15);
            UInt16 IR13 = (UInt16)((IR & 0x2000) >> 13);
            UInt16 rez = (UInt16)(IR15 & IR13);
            return rez; // IR15 & IR13
        }

        private UInt16 getCl0()
        {
            UInt16 IR15 = (UInt16)((IR & 0x8000) >> 15);
            UInt16 nIR14 = (UInt16)(((~IR) & 0x4000) >> 14);
            UInt16 rez = (UInt16)(IR15 & nIR14);
            return rez; //IR15 & nIR14
        }

        private UInt16 getCl()
        {
            UInt16 CL1 = (UInt16)(getCl1());
            UInt16 CL0 = (UInt16)(getCl0());
            classs = (UInt16)((CL1 << 1) | CL0);
            return classs;
        }

        private UInt16 decodeSuccesor(UInt64 MIRCode)
        {
            UInt16 nTF, condition = 0;
            nTF = (UInt16)((MIRCode & 256) >> 8);

            switch ((MIRCode & 61440) >> 12)
            {
                case 1: //INT
                    if (isInterrupt == true)
                        condition = 1;
                    break;
                case 2: //C
                    condition = (UInt16)((FLAG & 0x0008) >> 3);
                    break;
                case 3: //Z
                    condition = (UInt16)((FLAG & 0x0004) >> 2);
                    break;
                case 4: //S
                    condition = (UInt16)((FLAG & 0x0002) >> 1);
                    break;
                case 5: //V
                    condition = (UInt16)(FLAG & 0x0001);
                    break;
                case 6:
                    UInt16 ma = (UInt16)((IR & 0x0030) >> 4);
                    if (ma == 1)
                        condition = 1;
                    break;
                case 0x7://CIL
                    break;
                case 0x8://ACLOW
                    break;
                default: //NONE
                    condition = 1; // return 1 daca nT/F = 0(not nT/F)
                    break;
            }
            return (UInt16)(nTF ^ condition);
        }
    }
}
