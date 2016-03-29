using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class B4Instruction : Instruction
    {
        public B4Instruction(String opcode)
        {
            this.opcode = opcode;
        }

        public override string ToString()
        {
            return opcode;
        }
    }
}
