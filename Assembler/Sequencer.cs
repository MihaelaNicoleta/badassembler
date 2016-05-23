using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assembler
{
    class Sequencer
    {
        public int step = 0;

        public List<UInt64> MPM = new List<ulong>();
        public UInt16 MAR = 0;

        public UInt16 Carry = 0;

        public busses bus = new busses(0);
        public impRegisters regs = new impRegisters(0);
        
        public UInt64 index;
        public UInt16 classs;
        public bool isInterrupt = false;

        public void resetProcessor()
        {
            step = 0;
            MAR = 0;
            
            GraphicChanger graphicChanger = new GraphicChanger();
            graphicChanger.resetRegistersValues();
            graphicChanger.resetGraphicToDefault();
            graphicChanger.selectMicrocodeLine(MAR);

            bus.reset();
            regs.reset();
            
        }
        
        public void runSimulationStepByStep()
        {
            step++;

            GraphicChanger graphicChanger = new GraphicChanger();
            ulong MIR = MPM[MAR];

            if (regs.PC <= mainForm.PCmax)
            {
                switch (step)
                {
                    case 1:
                        {
                            MIR = MPM[MAR];
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
                            decodeMemoryOperations(MIR);

                        }
                        break;

                    case 7:
                        {
                            MAR = getMAR(MIR);

                            graphicChanger.resetGraphicToDefault();
                            step = 0;
                            bus.reset();
                        }
                        break;

                    default:
                        break;

                }
            }
            else
            {
                graphicChanger.resetGraphicToDefault();
                step = 0;
                graphicChanger.setLogMessage("Step by step simulation was a great success.");
            }
            
        }

        public void runSimulation()
        {

            GraphicChanger graphicChanger = new GraphicChanger();
            ulong MIR = MPM[MAR];

            while (regs.PC <= mainForm.PCmax)
            {

                MIR = MPM[MAR];

                graphicChanger.selectMicrocodeLine(MAR);
                decodeSBUS(MIR);                
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                decodeDBUS(MIR);
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                decodeALU(MIR);
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                decodeRBUS(MIR);
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                decodeOtherOperations(MIR);
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                decodeMemoryOperations(MIR);
                //Thread.Sleep(500);
                //graphicChanger.refresh();

                MAR = getMAR(MIR);
                bus.reset();
                graphicChanger.resetGraphicToDefault();

            }
                        
            graphicChanger.setLogMessage("Simulation was a great success.");

        }

        private void decodeSBUS(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 sbus = (UInt16)((MIRCode & 515396075520) >> 35);

            switch (sbus)
            {
                case 0x1: //PdIRs
                    graphicChanger.PdIRs();
                    bus.SBUS = (UInt16)(regs.IR & 0x00FF);
                    break;

                case 0x2: //PdFLAGs		
                    graphicChanger.PdFLAGs();
                    bus.SBUS = (UInt16)(regs.FLAG);
                    break;

                case 0x3: //PdSPs
                    graphicChanger.PdSPs();
                    bus.SBUS = (UInt16)(regs.SP);
                    break;

                case 0x4: //PdTs
                    graphicChanger.PdTs();
                    bus.SBUS = (UInt16)(regs.T);
                    break;

                case 0x5: //PdnotTs	
                    graphicChanger.PdnotTs();
                    bus.SBUS = (UInt16)(~regs.T);
                    break;

                case 0x6: //PdPCs	
                    graphicChanger.PdPCs();
                    bus.SBUS = (UInt16)(regs.PC);
                    break;

                case 0x7: //PdIVRs	
                    graphicChanger.PdIVRs();
                    bus.SBUS = (UInt16)(regs.IVR);
                    break;

                case 0x8: //PdADRs		
                    graphicChanger.PdADRs();
                    bus.SBUS = (UInt16)(regs.ADR);
                    break;

                case 0x9: //PdMDRs	
                    graphicChanger.PdMDRs();
                    bus.SBUS = (UInt16)(regs.MDR);
                    break;

                case 0xA: //PdRGs		
                    int register = (regs.IR & 960) >> 6;

                    switch (register)
                    {
                        case 0x1:
                            graphicChanger.colorR1();
                            bus.SBUS = regs.RG[1];

                            break;
                        case 0x2:
                            graphicChanger.colorR2();
                            bus.SBUS = regs.RG[2];
                            break;
                        case 0x3:
                            graphicChanger.colorR3();
                            bus.SBUS = regs.RG[3];
                            break;
                        case 0x4:
                            graphicChanger.colorR4();
                            bus.SBUS = regs.RG[4];
                            break;
                        case 0x5:
                            graphicChanger.colorR5();
                            bus.SBUS = regs.RG[5];
                            break;
                        case 0x6:
                            graphicChanger.colorR6();
                            bus.SBUS = regs.RG[6];
                            break;
                        case 0x7:
                            graphicChanger.colorR7();
                            bus.SBUS = regs.RG[7];
                            break;
                        case 0x8:
                            graphicChanger.colorR8();
                            bus.SBUS = regs.RG[8];
                            break;
                        case 0x9:
                            graphicChanger.colorR9();
                            bus.SBUS = regs.RG[9];
                            break;
                        case 0xA:
                            graphicChanger.colorR10();
                            bus.SBUS = regs.RG[10];
                            break;
                        case 0xB:
                            graphicChanger.colorR11();
                            bus.SBUS = regs.RG[11];
                            break;
                        case 0xC:
                            graphicChanger.colorR12();
                            bus.SBUS = regs.RG[12];
                            break;
                        case 0xD:
                            graphicChanger.colorR13();
                            bus.SBUS = regs.RG[13];
                            break;
                        case 0xE:
                            graphicChanger.colorR14();
                            bus.SBUS = regs.RG[14];
                            break;
                        case 0xF:
                            graphicChanger.colorR15();
                            bus.SBUS = regs.RG[15];
                            break;
                        default:
                            graphicChanger.colorR0();
                            bus.SBUS = regs.RG[0];
                            break;
                    }

                    graphicChanger.PdRGs();
                    break;

                case 0xB: //Pd0s
                    graphicChanger.Pd0s();
                    bus.SBUS = (UInt16)0;
                    break;

                case 0xC: //Pd-1s
                    graphicChanger.Pdminus1s();
                    int val = -1;
                    bus.SBUS = (UInt16)val;
                    break;

                case 0xD: //Pd1s
                    graphicChanger.Pd1s();
                    bus.SBUS = (UInt16)1;
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
                    bus.DBUS = (UInt16)(regs.IR & 0x00FF);
                    break;

                case 0x2: //PdFLAGd
                    graphicChanger.PdFLAGd();
                    bus.DBUS = (UInt16)regs.FLAG;
                    break;

                case 0x3: //PdSPd
                    graphicChanger.PdSPd();
                    bus.DBUS = (UInt16)regs.SP;
                    break;

                case 0x4: //PdTd
                    graphicChanger.PdTd();
                    bus.DBUS = (UInt16)regs.T;
                    break;

                case 0x5: //PdnotTd
                    graphicChanger.PdnotTd();
                    bus.DBUS = (UInt16)(~regs.T);
                    break;

                case 0x6: //PdPCd
                    graphicChanger.PdPCd();
                    bus.DBUS = (UInt16)regs.PC;
                    break;

                case 0x7: //PdIVRd
                    graphicChanger.PdIVRd();
                    bus.DBUS = (UInt16)regs.IVR;
                    break;

                case 0x8: //PdADRd
                    graphicChanger.PdADRd();
                    bus.DBUS = (UInt16)regs.ADR;
                    break;

                case 0x9: //PdMDRd
                    graphicChanger.PdMDRd();
                    bus.DBUS = (UInt16)regs.MDR;
                    break;

                case 0xA: //PdRGd
                    var register = regs.IR & 15;

                    switch (register)
                    {
                        case 0x1:
                            graphicChanger.colorR1();
                            bus.DBUS = (UInt16)regs.RG[1];
                            break;
                        case 0x2:
                            graphicChanger.colorR2();
                            bus.DBUS = (UInt16)regs.RG[2];
                            break;
                        case 0x3:
                            graphicChanger.colorR3();
                            bus.DBUS = (UInt16)regs.RG[3];
                            break;
                        case 0x4:
                            graphicChanger.colorR4();
                            bus.DBUS = (UInt16)regs.RG[4];
                            break;
                        case 0x5:
                            graphicChanger.colorR5();
                            bus.DBUS = (UInt16)regs.RG[5];
                            break;
                        case 0x6:
                            graphicChanger.colorR6();
                            bus.DBUS = (UInt16)regs.RG[6];
                            break;
                        case 0x7:
                            graphicChanger.colorR7();
                            bus.DBUS = (UInt16)regs.RG[7];
                            break;
                        case 0x8:
                            graphicChanger.colorR8();
                            bus.DBUS = (UInt16)regs.RG[8];
                            break;
                        case 0x9:
                            graphicChanger.colorR9();
                            bus.DBUS = (UInt16)regs.RG[9];
                            break;
                        case 0xA:
                            graphicChanger.colorR10();
                            bus.DBUS = (UInt16)regs.RG[10];
                            break;
                        case 0xB:
                            graphicChanger.colorR11();
                            bus.DBUS = (UInt16)regs.RG[11];
                            break;
                        case 0xC:
                            graphicChanger.colorR12();
                            bus.DBUS = (UInt16)regs.RG[12];
                            break;
                        case 0xD:
                            graphicChanger.colorR13();
                            bus.DBUS = (UInt16)regs.RG[13];
                            break;
                        case 0xE:
                            graphicChanger.colorR14();
                            bus.DBUS = (UInt16)regs.RG[14];
                            break;
                        case 0xF:
                            graphicChanger.colorR15();
                            bus.DBUS = (UInt16)regs.RG[15];
                            break;
                        default:
                            graphicChanger.colorR0();
                            bus.DBUS = (UInt16)regs.RG[0];
                            break;
                    }
                    graphicChanger.PdRGd();
                    break;

                case 0xB: //Pd0d
                    graphicChanger.Pd0d();
                    bus.DBUS = (UInt16)0;
                    break;

                default: //none
                    break;
            }
        }

        private void decodeRBUS(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 rbus = (UInt16)((MIRCode & 125829120) >> 23);

            UInt16 value = 0;

            switch (rbus)
            {
                case 0x1: //PmFLAG
                    regs.FLAG = (UInt16)bus.RBUS;
                    graphicChanger.PmFLAG();
                    break;

                case 0x2: //PmRG
                    var register = regs.IR & 15;
                    graphicChanger.PmRG();
                    value = (UInt16)bus.RBUS;

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
                    value = regs.SP = (UInt16)bus.RBUS;
                    graphicChanger.setSP(value);
                    break;

                case 0x4: //PmT
                    graphicChanger.PmT();
                    value = regs.T = (UInt16)bus.RBUS;
                    graphicChanger.setT(value);
                    break;

                case 0x5: //PmPC
                    graphicChanger.PmPC();
                    value = regs.PC = (UInt16)bus.RBUS;
                    graphicChanger.setPC(value);
                    break;

                case 0x6: //PmIVR
                    graphicChanger.PmIVR();
                    value = regs.IVR = (UInt16)bus.RBUS;
                    graphicChanger.setIVR(value);
                    break;

                case 0x7: //PmADR
                    graphicChanger.PmADR();
                    value = regs.ADR = (UInt16)bus.RBUS;
                    graphicChanger.setADR(value);
                    break;

                case 0x8: //PmMDR
                    graphicChanger.PmMDR();
                    value = regs.MDR = (UInt16)bus.RBUS;
                    graphicChanger.setMDR(value);
                    break;

                default: //none
                    break;
            }
        }

        private void decodeALU(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 alu = (UInt16)((MIRCode & 2013265920) >> 27);

            ushort value = 0;
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
                            bus.RBUS = (UInt16)(bus.SBUS + bus.DBUS + 0x1);
                            graphicChanger.colorAlu();                   
                        }
                        catch (OverflowException) //overflow
                        {
                            regs.FLAG = (UInt16)(regs.FLAG | 0X0001); //setez V
                            graphicChanger.setFLAGS(value);
                        }
                    }
                    else
                    { //adunare
                        try
                        {
                            graphicChanger.setALUOperation("SUM");
                            graphicChanger.colorAlu();
                            bus.RBUS = (UInt16)(bus.SBUS + bus.DBUS);
                        }
                        catch (OverflowException)
                        {
                            regs.FLAG = (UInt16)(regs.FLAG | 0X0001); //setez V
                            graphicChanger.setFLAGS(value);
                        }
                    }
                    #endregion
                    break;
                case 0x2: //AND
                    graphicChanger.setALUOperation("AND");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)(bus.SBUS + bus.DBUS);
                    break;
                case 0x3: //OR
                    graphicChanger.setALUOperation("OR");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)(bus.SBUS | bus.DBUS);
                    break;
                case 0x4: //XOR
                    graphicChanger.setALUOperation("XOR");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)(bus.SBUS ^ bus.DBUS);
                    break;
                case 0x5: //ASL
                    graphicChanger.setALUOperation("ASL");
                    graphicChanger.colorAlu();
                    Carry = (UInt16)((bus.DBUS & 0x8000) >> 15);
                    bus.RBUS = (UInt16)(bus.DBUS << 1);
                    break;
                case 0x6: //ASR
                    graphicChanger.setALUOperation("ASR");
                    graphicChanger.colorAlu();
                    Carry = (UInt16)(bus.DBUS & 0x0001);
                    bus.RBUS = (UInt16)((Int16)((Int16)bus.DBUS >> 1));
                    break;
                case 0x7: //LSR
                    graphicChanger.setALUOperation("LSR");
                    graphicChanger.colorAlu();
                    Carry = (UInt16)(bus.DBUS & 0x0001);
                    bus.RBUS = (UInt16)(bus.DBUS >> 1);
                    break;
                case 0x8: //ROL
                    graphicChanger.setALUOperation("ROL");
                    graphicChanger.colorAlu();
                    Carry = (UInt16)((bus.DBUS & 0x8000) >> 15);
                    bus.RBUS = (UInt16)((bus.DBUS << 1) + Carry);
                    break;
                case 0x9: //ROR 
                    graphicChanger.setALUOperation("ROR");
                    graphicChanger.colorAlu();
                    Carry = (UInt16)(bus.DBUS & 0x0001);
                    bus.RBUS = (UInt16)((bus.DBUS >> 1) + (UInt16)(Carry << 15));
                    break;
                case 0xA: //RLC
                    graphicChanger.setALUOperation("RLC");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)((bus.DBUS << 1) + Carry);
                    Carry = (UInt16)((bus.DBUS & 0x8000) >> 15);
                    break;
                case 0xB: //RRC
                    graphicChanger.setALUOperation("RRC");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)((bus.DBUS >> 1) + (Carry << 15));
                    Carry = (UInt16)(bus.DBUS & 0x0001);
                    break;
                case 0xC: //nDBUS
                    graphicChanger.setALUOperation("nDBUS");
                    graphicChanger.colorAlu();
                    bus.RBUS = (UInt16)(~bus.DBUS);
                    break;
                default: //none
                    break;
            }
        }

        private void decodeOtherOperations(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 otherOp = (UInt16)((MIRCode & 8126464) >> 18);

            ushort value = 0;

            switch (otherOp)
            {
                case 0x1: //PdCOND
                    if (bus.RBUS == 0) //setez Z
                    {
                        regs.FLAG = (UInt16)(regs.FLAG | 0x0004);
                    }
                    if (bus.RBUS >> 15 == 0x1) //setez S
                    {
                        regs.FLAG = (UInt16)(regs.FLAG | 0x0002);
                    }

                    graphicChanger.PdCond();
                    value = regs.FLAG = (UInt16)(regs.FLAG | (Carry << 3));
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x2: //CINPdCOND

                    if (bus.RBUS == 0) //setez Z
                    {
                        regs.FLAG = (UInt16)(regs.FLAG | 0x0004);
                    }
                    if (bus.RBUS >> 15 == 0x1) //setez S
                    {
                        regs.FLAG = (UInt16)(regs.FLAG | 0x0002);
                    }

                    graphicChanger.PdCond();
                    value = regs.FLAG = (UInt16)(regs.FLAG | (Carry << 3));
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x3: //plus2SP
                    graphicChanger.plusSP();
                    regs.SP += (UInt16)2;
                    value = (UInt16)regs.SP;
                    graphicChanger.setSP(value);
                    break;
                case 0x4: //minus2SP
                    graphicChanger.minusSP();
                    regs.SP -= (UInt16)2;
                    value = (UInt16)regs.SP;
                    graphicChanger.setSP(value);
                    break;
                case 0x5: //plus2PC
                    graphicChanger.plusPC();
                    regs.PC += (UInt16)2;
                    value = (UInt16)regs.PC;
                    graphicChanger.setPC(value);
                    break;
                case 0x6: //A(0)BPO
                    break;
                case 0x7: //A(0)C
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0xFFF7);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x8: //A(1)C
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x0008);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x9: //A(0)V
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0xFFFE);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xA: //A(1)V
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x0001);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xB: //A(0)Z
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0xFFFB);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xC: //A(1)Z
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x0004);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xD: //A(0)S
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0xFFFD);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xE: //A(1)S
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x0002);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0xF: //A(0)CVZS
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0xFFF0);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x10: //A(1)CVZS
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x000F);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x11: //A(0)BVI
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG & 0x0FF7F);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                case 0x12: //A(1)BVI
                    graphicChanger.colorFlags();
                    regs.FLAG = (UInt16)(regs.FLAG | 0x0080);
                    value = (UInt16)regs.FLAG;
                    graphicChanger.setFLAGS(value);
                    break;
                default: //none
                    break;
            }
        }

        private void decodeMemoryOperations(UInt64 MIRCode)
        {
            GraphicChanger graphicChanger = new GraphicChanger();
            UInt16 memOperation = (UInt16)((MIRCode & 196608) >> 16);
            UInt16 value = 0;

            switch (memOperation)
            {
                case 0x1: //IFCH
                    graphicChanger.IFCH();
                    regs.IR = (UInt16)((UInt16)(mainForm.MEM[regs.ADR + 1] << 8) | (UInt16)(mainForm.MEM[regs.ADR]));
                    value = (UInt16)regs.IR;
                    graphicChanger.setIR(value);
                    break;
                case 0x2: //READ
                    graphicChanger.Read();
                    regs.MDR = (UInt16)((UInt16)(mainForm.MEM[regs.ADR + 1] << 8) | (UInt16)(mainForm.MEM[regs.ADR]));
                    value = (UInt16)regs.MDR;
                    graphicChanger.setMDR(value);
                    break;
                case 0x3: //WRITE
                    graphicChanger.Write();

                    mainForm.MEM[regs.ADR] = (byte)regs.MDR;
                    mainForm.MEM[regs.ADR + 1] = (byte)((UInt16)(regs.MDR >> 8));
                    UInt16 ADR_2 = (UInt16)(regs.ADR + 1);

                    if (mainForm.MEM[regs.ADR] != 0)
                    {
                        mainForm.MEM[regs.ADR] = mainForm.MEM[regs.ADR];
                        mainForm.MEM[ADR_2] = mainForm.MEM[ADR_2];
                    }
                    else
                    {
                        mainForm.MEM[regs.ADR] = mainForm.MEM[regs.ADR];
                        mainForm.MEM[regs.ADR + 1] = mainForm.MEM[regs.ADR + 1];
                    }

                    break;
                default: 
                    break;
            }
        }

        private UInt16 getCl1()
        {
            UInt16 IR15 = (UInt16)((regs.IR & 0x8000) >> 15);
            UInt16 IR13 = (UInt16)((regs.IR & 0x2000) >> 13);
            UInt16 rez = (UInt16)(IR15 & IR13);
            return rez; // IR15 & IR13
        }

        private UInt16 getCl0()
        {
            UInt16 IR15 = (UInt16)((regs.IR & 0x8000) >> 15);
            UInt16 nIR14 = (UInt16)(((~regs.IR) & 0x4000) >> 14);
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
                    condition = (UInt16)((regs.FLAG & 0x0008) >> 3);
                    break;
                case 3: //Z
                    condition = (UInt16)((regs.FLAG & 0x0004) >> 2);
                    break;
                case 4: //S
                    condition = (UInt16)((regs.FLAG & 0x0002) >> 1);
                    break;
                case 5: //V
                    condition = (UInt16)(regs.FLAG & 0x0001);
                    break;
                case 6:
                    UInt16 ma = (UInt16)((regs.IR & 0x0030) >> 4);
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

        public UInt16 getMAR(UInt64 MIRCode)
        {
            var g = decodeSuccesor(MIRCode);
            UInt16 shift = (UInt16)(MIRCode & 255);

            if (g == 1) // MAR = ADRESA_SALT + INDEX
            {
                switch ((MIRCode & 3584) >> 9)
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
                        index = (UInt16)((regs.IR & 3072) >> 9);
                        MAR = (UInt16)(shift + index);
                        break;
                    case 0x3: //INDEX3
                        index = (UInt16)((regs.IR & 48) >> 3);
                        MAR = (UInt16)(shift + index);
                        break;
                    case 0x4: //INDEX4
                        index = (UInt16)((regs.IR & 28672) >> 11);
                        MAR = (UInt16)(shift + index);
                        break;
                    case 0x5: //INDEX5
                        index = (UInt16)((regs.IR & 1984) >> 5);
                        MAR = (UInt16)(shift + index);
                        break;
                    case 0x6: //INDEX6
                        index = (UInt16)((regs.IR & 7936) >> 7);
                        MAR = (UInt16)(shift + index);
                        break;
                    case 0x7: //INDEX7
                        index = (UInt16)((regs.IR & 31) << 1);
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

            return MAR;
        }
    }
}
