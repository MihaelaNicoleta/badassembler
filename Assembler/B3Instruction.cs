using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class B3Instruction : Instruction
    {
        public B3Instruction(String opcode)
        {
            this.opcode = opcode;
        }
        /*public override string ToString()
        {
            return opcode + MAS + RS + MAD + RD;
        }*/
    }
}
