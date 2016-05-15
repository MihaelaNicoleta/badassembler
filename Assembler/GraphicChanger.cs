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
            myForm.oneShape.BorderColor = changeColor;
            myForm.SBUS.BorderColor = changeColor;
        }


    }
}
