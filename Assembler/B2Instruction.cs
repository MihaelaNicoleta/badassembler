using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class B2Instruction : Instruction
    {
        public String MAD;
        public String RD;
        public String offsetD;

        public B2Instruction(String opcode)
        {
            this.opcode = opcode;
        }

        public override string ToString()
        {
            return opcode + MAD + RD;
        }
    }
}
