using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class B1Instruction : Instruction
    {
        public String MAS;
        public String MAD;
        public String RS;
        public String RD;
        public String offsetS;
        public String offsetD;

        public B1Instruction(String opcode)
        {
            this.opcode = opcode;
        }

        public int MyProperty { get; set; }

        public override string ToString()
        {
            return opcode + MAS + RS + MAD + RD + "\r\n" + offsetS + offsetD;
        }

        /*public void setMAS(String mas)
        {
            this.MAS = mas;
        }

        public void setMAD(String mad)
        {
            this.MAD = mad;
        }

        public void setRS(String rs)
        {
            this.RS = rs;
        }

        public void setRD(String rd)
        {
            this.RD = rd;
        }*/
    }
}
