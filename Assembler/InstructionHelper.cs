using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assembler
{
    class InstructionHelper
    {
        public Dictionary<String, String> B1 = new Dictionary<String, String>();
        public Dictionary<String, String> B2 = new Dictionary<String, String>();
        public Dictionary<String, String> B3 = new Dictionary<String, String>();
        public Dictionary<String, String> B4 = new Dictionary<String, String>();

        Dictionary<String, String> registers = new Dictionary<String, String>();
        Dictionary<String, String> addressingModes = new Dictionary<String, String>();

        public Dictionary<String, String> getInstructionType(String instrName)
        {
            // name--opcode
            Dictionary<String, String> result = new Dictionary<String, String>();

            foreach (KeyValuePair<String, String> temp4 in B4)
            {
                if (temp4.Key == instrName)
                {
                    result.Add("B4", temp4.Value); //add classtype and opcode      
                    return result;
                }
            }
            
            foreach (KeyValuePair<String, String> temp1 in B1)
            {
                if (temp1.Key == instrName)
                {
                    result.Add("B1", temp1.Value); //add classtype and opcode      
                    return result;
                }
            }

            foreach (KeyValuePair<String, String> temp2 in B2)
            {
                if (temp2.Key == instrName)
                {
                    result.Add("B2", temp2.Value); //add classtype and opcode      
                    return result;
                }
            }

            foreach (KeyValuePair<String, String> temp3 in B3)
            {
                if (temp3.Key == instrName)
                {
                    result.Add("B3", temp3.Value); //add classtype and opcode      
                    return result;
                }
            }
            return null;
        }       
    }
}
