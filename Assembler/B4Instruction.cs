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

        /*if (values[0] == "JMP")
                        isJMP = true;
                    if (values[0] == "CALL")
                        isCALL = true;
                    if (values[0] == "PUSH")
                        isPUSHRi = true;
                    if (values[0] == "POP")
                        isPOPRi = true;
                    return t2.Value;*/

        /*public override string ToString()
        {
            return opcode + MAS + RS + MAD + RD;
        }*/
    }
}
