using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembler
{
    class Instruction
    {
        public string name;
        public string opcode;

        public Instruction()
        {            
        }

        public Instruction(String name, String opcode)
        {
            this.name = name;
            this.opcode = opcode;
        }

        public Instruction(String name)
        {
            this.name = name;
        }

        public void setOpcode(String opcode)
        {
            this.opcode = opcode;
        }

    }
}
