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
        //public string classType;

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

        /*public String getClassType()
        {
            return this.classType;
        */

        public void setOpcode(String opcode)
        {
            this.opcode = opcode;
        }

        /*public void setClassType(String classType)
        {
            this.classType = classType;
        }*/
    }
}
