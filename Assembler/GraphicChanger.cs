using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;


namespace Assembler
{
    class GraphicChanger
    {
        mainForm myForm = mainForm.currentForm;
        MicrocodeForm microcodeForm = MicrocodeForm.microcodeForm;
        Color changeColor = Color.Orange;
        Color defaultColor = Color.Black;

        public void Pd0s()
        {
            myForm.Pd0s.BorderColor = changeColor;
            myForm.zero.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void Pd0d()
        {
            myForm.Pd0d.BorderColor = changeColor;
            myForm.zero.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void Pd1s()
        {
            myForm.Pd1.BorderColor = changeColor;
            myForm.one.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void Pdminus1s()
        {
            myForm.Pdminus1.BorderColor = changeColor;
            myForm.minusOne.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdIRs()
        {
            myForm.PdIRs.BorderColor = changeColor;
            myForm.IR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdIRd()
        {
            myForm.PdIRd.BorderColor = changeColor;
            myForm.IR.ForeColor = changeColor;          
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdMDRs()
        {
            myForm.PdMDRd.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdMDRd()
        {
            myForm.PdMDRs.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdADRs()
        {
            myForm.PdADRd.BorderColor = changeColor;
            myForm.ADR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdADRd()
        {
            myForm.PdADRs.BorderColor = changeColor;
            myForm.ADR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }


        public void PdIVRs()
        {
            myForm.PdIVRd.BorderColor = changeColor;
            myForm.IVR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdIVRd()
        {
            myForm.PdIVRs.BorderColor = changeColor;
            myForm.IVR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdPCs()
        {
            myForm.PdPCd.BorderColor = changeColor;
            myForm.PC.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdPCd()
        {
            myForm.PdPCs.BorderColor = changeColor;
            myForm.PC.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdTs()
        {
            myForm.PdTd.BorderColor = changeColor;
            myForm.T.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdTd()
        {
            myForm.PdTs.BorderColor = changeColor;
            myForm.T.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdSPs()
        {
            myForm.PdSPd.BorderColor = changeColor;
            myForm.SP.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdSPd()
        {
            myForm.PdSPs.BorderColor = changeColor;
            myForm.SP.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void colorR0()
        {
            myForm.R0.ForeColor = changeColor;
        }

        public void colorR1()
        {
            myForm.R1.ForeColor = changeColor;
        }

        public void colorR2()
        {
            myForm.R2.ForeColor = changeColor;
        }

        public void colorR3()
        {
            myForm.R3.ForeColor = changeColor;
        }

        public void colorR4()
        {
            myForm.R4.ForeColor = changeColor;
        }

        public void colorR5()
        {
            myForm.R5.ForeColor = changeColor;
        }

        public void colorR6()
        {
            myForm.R6.ForeColor = changeColor;
        }

        public void colorR7()
        {
            myForm.R7.ForeColor = changeColor;
        }

        public void colorR8()
        {
            myForm.R8.ForeColor = changeColor;
        }

        public void colorR9()
        {
            myForm.R9.ForeColor = changeColor;
        }

        public void colorR10()
        {
            myForm.R10.ForeColor = changeColor;
        }

        public void colorR11()
        {
            myForm.R11.ForeColor = changeColor;
        }

        public void colorR12()
        {
            myForm.R12.ForeColor = changeColor;
        }

        public void colorR13()
        {
            myForm.R13.ForeColor = changeColor;
        }

        public void colorR14()
        {
            myForm.R14.ForeColor = changeColor;
        }

        public void colorR15()
        {
            myForm.R15.ForeColor = changeColor;
        }


        public void PdRGs()
        {
            myForm.PdRGd.BorderColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdRGd()
        {
            myForm.PdRGs.BorderColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdFLAGs()
        {
            myForm.PdFLAGd.BorderColor = changeColor;
            myForm.flags.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdFLAGd()
        {
            myForm.PdFLAGs.BorderColor = changeColor;
            myForm.flags.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void colorFlags()
        {
            myForm.flags.ForeColor = changeColor;
        }

        public void PdCond()
        {
            myForm.PdCond1.BorderColor = changeColor;
            myForm.PdCond2.BorderColor = changeColor;
            myForm.PdCond3.BorderColor = changeColor;
            myForm.PdCond4.BorderColor = changeColor;
            myForm.PdCond5.BorderColor = changeColor;
            myForm.muxFlagLine1.BorderColor = changeColor;
            myForm.muxFlagLine2.BorderColor = changeColor;
        }

        public void colorAlu()
        {
            myForm.ALUSLine.BorderColor = changeColor;
            myForm.ALUDLine.BorderColor = changeColor;
            myForm.ALURLine.BorderColor = changeColor;
            myForm.RBUS.BorderColor = changeColor;
        }

        public void PmMDR()
        {
            myForm.PmMDR.BorderColor = changeColor;
            myForm.PmMDR1.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
        }

        public void PmADR()
        {
            myForm.PmADR.BorderColor = changeColor;
            myForm.ADR.ForeColor = changeColor;
        }

        public void PmIVR()
        {
            myForm.PmIVR.BorderColor = changeColor;
            myForm.IVR.ForeColor = changeColor;
        }

        public void PmPC()
        {
            myForm.PmPC.BorderColor = changeColor;
            myForm.PC.ForeColor = changeColor;
        }

        public void PmT()
        {
            myForm.PmT.BorderColor = changeColor;
            myForm.T.ForeColor = changeColor;
        }

        public void PmSP()
        {
            myForm.PmSP.BorderColor = changeColor;
            myForm.SP.ForeColor = changeColor;
        }

        public void PmRG()
        {
            myForm.PmRG.BorderColor = changeColor;
        }

        public void PmFLAG()
        {
            myForm.PmFLAG.BorderColor = changeColor;
            myForm.flags.ForeColor = changeColor;
        }

        public void plusSP()
        {
            myForm.SP.ForeColor = changeColor;
        }

        public void minusSP()
        {
            myForm.SP.ForeColor = changeColor;
        }

        public void plusPC()
        {
            myForm.PC.ForeColor = changeColor;
        }

        public void IFCH()
        {
            myForm.ADRLine1.BorderColor = changeColor;
            myForm.ADRLine2.BorderColor = changeColor;
            myForm.DataOUTLine4.BorderColor = changeColor;
            myForm.DataOUTLine5.BorderColor = changeColor;
            myForm.IR.ForeColor = changeColor;
        }

        public void Read()
        {
            myForm.PdADRd.BorderColor = changeColor;
            myForm.ALUDLine.BorderColor = changeColor;
            myForm.ALUDLine.BorderColor = changeColor;
            myForm.DataOUTLine1.BorderColor = changeColor;
            myForm.DataOUTLine2.BorderColor = changeColor;
            myForm.DataOUTLine3.BorderColor = changeColor;
            myForm.PmMDR.BorderColor = changeColor;
            myForm.PmMDR1.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
        }

        public void Write()
        {
            myForm.PdADRd.BorderColor = changeColor;
            myForm.ALUDLine.BorderColor = changeColor;
            myForm.ALUDLine.BorderColor = changeColor;
            myForm.PdMDRd.BorderColor = changeColor;
            myForm.MDRLine1.BorderColor = changeColor;
            myForm.MDRLine2.BorderColor = changeColor;
            myForm.MDRLine3.BorderColor = changeColor;
        }

        private String toBinary(UInt16 integerValue)
        {
            var stringValue = Convert.ToString(integerValue, 2);

            String zeros = "0";
            for (int i = 0; i < (15 - stringValue.Length); i++)
            {
                zeros += "0";
            }

            return zeros + stringValue;
        }

        private void setNewRegisterValue(Label element, UInt16 value)
        {
            element.Text = toBinary(value);
        }

        public void setMDR(UInt16 value)
        {
            setNewRegisterValue(myForm.MDR, value);
        }

        public void setADR(UInt16 value)
        {
            setNewRegisterValue(myForm.ADR, value);
        }

        public void setIVR(UInt16 value)
        {
            setNewRegisterValue(myForm.IVR, value);
        }

        public void setIR(UInt16 value)
        {
            setNewRegisterValue(myForm.IR, value);
        }

        public void setPC(UInt16 value)
        {
            setNewRegisterValue(myForm.PC, value);
        }

        public void setT(UInt16 value)
        {
            setNewRegisterValue(myForm.T, value);
        }

        public void setSP(UInt16 value)
        {
            setNewRegisterValue(myForm.SP, value);
        }

        public void setR0(UInt16 value)
        {
            setNewRegisterValue(myForm.R0, value);
        }

        public void setR1(UInt16 value)
        {
            setNewRegisterValue(myForm.R1, value);
        }

        public void setR2(UInt16 value)
        {
            setNewRegisterValue(myForm.R2, value);
        }

        public void setR3(UInt16 value)
        {
            setNewRegisterValue(myForm.R3, value);
        }

        public void setR4(UInt16 value)
        {
            setNewRegisterValue(myForm.R4, value);
        }

        public void setR5(UInt16 value)
        {
            setNewRegisterValue(myForm.R5, value);
        }

        public void setR6(UInt16 value)
        {
            setNewRegisterValue(myForm.R6, value);
        }

        public void setR7(UInt16 value)
        {
            setNewRegisterValue(myForm.R7, value);
        }

        public void setR8(UInt16 value)
        {
            setNewRegisterValue(myForm.R8, value);
        }

        public void setR9(UInt16 value)
        {
            setNewRegisterValue(myForm.R9, value);
        }

        public void setR10(UInt16 value)
        {
            setNewRegisterValue(myForm.R10, value);
        }

        public void setR11(UInt16 value)
        {
            setNewRegisterValue(myForm.R11, value);
        }

        public void setR12(UInt16 value)
        {
            setNewRegisterValue(myForm.R12, value);
        }

        public void setR13(UInt16 value)
        {
            setNewRegisterValue(myForm.R13, value);
        }

        public void setR14(UInt16 value)
        {
            setNewRegisterValue(myForm.R14, value);
        }

        public void setR15(UInt16 value)
        {
            setNewRegisterValue(myForm.R15, value);
        }

        public void setFLAGS(UInt16 value)
        {
            setNewRegisterValue(myForm.flags, value);
        }

        public void setALUOperation(String operation)
        {
            myForm.ALUOperation.Text = operation.ToUpper();
        }

        private void resetBusesColor()
        {
            myForm.SBUS.BorderColor = defaultColor;
            myForm.DBUS.BorderColor = defaultColor;
            myForm.RBUS.BorderColor = defaultColor;

            myForm.Pd0s.BorderColor = defaultColor;
            myForm.Pd0d.BorderColor = defaultColor;
            myForm.Pd1.BorderColor = defaultColor;
            myForm.Pdminus1.BorderColor = defaultColor;
            myForm.PdIRs.BorderColor = defaultColor;
            myForm.PdIRs.BorderColor = defaultColor;
            myForm.PdMDRs.BorderColor = defaultColor;
            myForm.PdMDRd.BorderColor = defaultColor;
            myForm.PdADRd.BorderColor = defaultColor;
            myForm.PdADRs.BorderColor = defaultColor;
            myForm.PdIVRd.BorderColor = defaultColor;
            myForm.PdIVRs.BorderColor = defaultColor;
            myForm.PdPCd.BorderColor = defaultColor;
            myForm.PdPCs.BorderColor = defaultColor;
            myForm.PdTd.BorderColor = defaultColor;
            myForm.PdTs.BorderColor = defaultColor;
            myForm.PdSPd.BorderColor = defaultColor;
            myForm.PdSPs.BorderColor = defaultColor;
            myForm.PdRGd.BorderColor = defaultColor;
            myForm.PdRGs.BorderColor = defaultColor;
            myForm.PdFLAGd.BorderColor = defaultColor;
            myForm.PdFLAGs.BorderColor = defaultColor;
            myForm.PdCond1.BorderColor = defaultColor;
            myForm.PdCond2.BorderColor = defaultColor;
            myForm.PdCond3.BorderColor = defaultColor;
            myForm.PdCond4.BorderColor = defaultColor;
            myForm.PdCond5.BorderColor = defaultColor;

            myForm.PmMDR.BorderColor = defaultColor;
            myForm.PmMDR1.BorderColor = defaultColor;
            myForm.PmADR.BorderColor = defaultColor;
            myForm.PmIVR.BorderColor = defaultColor;
            myForm.PmPC.BorderColor = defaultColor;
            myForm.PmT.BorderColor = defaultColor;
            myForm.PmSP.BorderColor = defaultColor;
            myForm.PmRG.BorderColor = defaultColor;
            myForm.PmFLAG.BorderColor = defaultColor;
            myForm.PmFLAG1.BorderColor = defaultColor;

            myForm.ADRLine1.BorderColor = defaultColor;
            myForm.ADRLine2.BorderColor = defaultColor;
            myForm.MDRLine1.BorderColor = defaultColor;
            myForm.MDRLine2.BorderColor = defaultColor;
            myForm.MDRLine3.BorderColor = defaultColor;
            myForm.DataOUTLine1.BorderColor = defaultColor;
            myForm.DataOUTLine2.BorderColor = defaultColor;
            myForm.DataOUTLine3.BorderColor = defaultColor;
            myForm.DataOUTLine4.BorderColor = defaultColor;
            myForm.DataOUTLine5.BorderColor = defaultColor;

            myForm.ALUSLine.BorderColor = defaultColor;
            myForm.ALUDLine.BorderColor = defaultColor;
            myForm.ALURLine.BorderColor = defaultColor;
        }

        private void resetRegistersColor()
        {
            myForm.zero.ForeColor = defaultColor;
            myForm.one.ForeColor = defaultColor;
            myForm.minusOne.ForeColor = defaultColor;
            myForm.IR.ForeColor = defaultColor;
            myForm.MDR.ForeColor = defaultColor;
            myForm.ADR.ForeColor = defaultColor;
            myForm.IVR.ForeColor = defaultColor;
            myForm.PC.ForeColor = defaultColor;
            myForm.T.ForeColor = defaultColor;
            myForm.SP.ForeColor = defaultColor;
            myForm.R0.ForeColor = defaultColor;
            myForm.R1.ForeColor = defaultColor;
            myForm.R2.ForeColor = defaultColor;
            myForm.R3.ForeColor = defaultColor;
            myForm.R4.ForeColor = defaultColor;
            myForm.R5.ForeColor = defaultColor;
            myForm.R6.ForeColor = defaultColor;
            myForm.R7.ForeColor = defaultColor;
            myForm.R8.ForeColor = defaultColor;
            myForm.R9.ForeColor = defaultColor;
            myForm.R10.ForeColor = defaultColor;
            myForm.R11.ForeColor = defaultColor;
            myForm.R12.ForeColor = defaultColor;
            myForm.R13.ForeColor = defaultColor;
            myForm.R14.ForeColor = defaultColor;
            myForm.R15.ForeColor = defaultColor;
            myForm.flags.ForeColor = defaultColor;

        }

        public void resetRegistersValues()
        {
            ushort value = 0;

            setNewRegisterValue(myForm.IR, value);
            setNewRegisterValue(myForm.MDR, value);
            setNewRegisterValue(myForm.ADR, value);
            setNewRegisterValue(myForm.IVR, value);
            setNewRegisterValue(myForm.PC, value);
            setNewRegisterValue(myForm.T, value);
            setNewRegisterValue(myForm.SP, value);
            setNewRegisterValue(myForm.R0, value);
            setNewRegisterValue(myForm.R1, value);
            setNewRegisterValue(myForm.R2, value);
            setNewRegisterValue(myForm.R3, value);
            setNewRegisterValue(myForm.R4, value);
            setNewRegisterValue(myForm.R5, value);
            setNewRegisterValue(myForm.R6, value);
            setNewRegisterValue(myForm.R7, value);
            setNewRegisterValue(myForm.R8, value);
            setNewRegisterValue(myForm.R9, value);
            setNewRegisterValue(myForm.R10, value);
            setNewRegisterValue(myForm.R11, value);
            setNewRegisterValue(myForm.R12, value);
            setNewRegisterValue(myForm.R13, value);
            setNewRegisterValue(myForm.R14, value);
            setNewRegisterValue(myForm.R15, value);
            setNewRegisterValue(myForm.flags, value);
        }

        public void resetGraphicToDefault()
        {
            resetBusesColor();
            resetRegistersColor();
        }

        public void selectMicrocodeLine(int lineNumber)
        {
            microcodeForm.microcodeListBox.SetSelected(lineNumber, true);
        }

        public void setLogMessage(String message)
        {
            myForm.messagesTextBox.Text += message + "\r\n";
        }

        public void refresh()
        {
            myForm.Refresh();
        }

    }
}
