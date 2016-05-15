using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;

namespace Assembler
{
    class GraphicChanger
    {
        mainForm myForm = mainForm.currentForm;
        Color changeColor = Color.Orange;

        public void Pd0s()
        {
            myForm.Pd0s.BorderColor = changeColor;
            myForm.zeroShape.BorderColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void Pd0d()
        {
            myForm.Pd0d.BorderColor = changeColor;
            myForm.zeroShape.BorderColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void Pd1s()
        {
            myForm.Pd1.BorderColor = changeColor;
            myForm.oneShape.BorderColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void Pdminus1s()
        {
            myForm.Pdminus1.BorderColor = changeColor;
            myForm.minusOneShape.BorderColor = changeColor;
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
            myForm.PdMDRs.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdMDRd()
        {
            myForm.PdMDRd.BorderColor = changeColor;
            myForm.MDR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdADRs()
        {
            myForm.PdADRs.BorderColor = changeColor;
            myForm.ADR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdADRd()
        {
            myForm.PdADRd.BorderColor = changeColor;
            myForm.ADR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }


        public void PdIVRs()
        {
            myForm.PdIVRs.BorderColor = changeColor;
            myForm.IVR.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdIVRd()
        {
            myForm.PdIVRd.BorderColor = changeColor;
            myForm.IVR.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdPCs()
        {
            myForm.PdPCs.BorderColor = changeColor;
            myForm.PC.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdPCd()
        {
            myForm.PdPCd.BorderColor = changeColor;
            myForm.PC.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdTs()
        {
            myForm.PdTs.BorderColor = changeColor;
            myForm.T.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdTd()
        {
            myForm.PdTd.BorderColor = changeColor;
            myForm.T.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdSPs()
        {
            myForm.PdSPs.BorderColor = changeColor;
            myForm.SP.ForeColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }

        public void PdSPd()
        {
            myForm.PdSPd.BorderColor = changeColor;
            myForm.SP.ForeColor = changeColor;
            myForm.DBUS.BorderColor = changeColor;
        }

        public void PdR0()
        {
            myForm.R0.ForeColor = changeColor;
        }

        public void PdR1()
        {
            myForm.R1.ForeColor = changeColor;
        }

        public void PdR2()
        {
            myForm.R2.ForeColor = changeColor;
        }

        public void PdR3()
        {
            myForm.R3.ForeColor = changeColor;
        }

        public void PdR4()
        {
            myForm.R4.ForeColor = changeColor;
        }

        public void PdR5()
        {
            myForm.R5.ForeColor = changeColor;
        }

        public void PdR6()
        {
            myForm.R6.ForeColor = changeColor;
        }

        public void PdR7()
        {
            myForm.R7.ForeColor = changeColor;
        }

        public void PdR8()
        {
            myForm.R8.ForeColor = changeColor;
        }

        public void PdR9()
        {
            myForm.R9.ForeColor = changeColor;
        }

        public void PdR10()
        {
            myForm.R10.ForeColor = changeColor;
        }

        public void PdR11()
        {
            myForm.R11.ForeColor = changeColor;
        }

        public void PdR12()
        {
            myForm.R12.ForeColor = changeColor;
        }

        public void PdR13()
        {
            myForm.R13.ForeColor = changeColor;
        }

        public void PdR14()
        {
            myForm.R14.ForeColor = changeColor;
        }

        public void PdR15()
        {
            myForm.R15.ForeColor = changeColor;
        }


    }
}
