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
            return opcode + MAD + RD + MAS + RS;
        }

    }
}
