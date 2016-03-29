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
            Dictionary<String, String> result = new Dictionary<String, String>();

            //nume--opcode
            //check if B4 class
            foreach (KeyValuePair<String, String> temp4 in B4)
            {
                if (temp4.Key == instrName)
                {
                    result.Add("B4", temp4.Value); //add classtype and opcode      
                    return result;
                }
            }

            //char[] separators = { ' ' };
            //string[] values = instr.Split(separators);

            foreach (KeyValuePair<String, String> temp1 in B1)
            {
                if (temp1.Key == instrName)
                {
                    result.Add("B1", temp1.Value); //add classtype and opcode      
                    return result;
                }
            }

            /*foreach (KeyValuePair<String, String> t2 in b2) //clasa b2?
            {
                if (t2.Key == values[0])
                {
                    isb2 = true;
                    if (values[0] == "JMP")
                        isJMP = true;
                    if (values[0] == "CALL")
                        isCALL = true;
                    if (values[0] == "PUSH")
                        isPUSHRi = true;
                    if (values[0] == "POP")
                        isPOPRi = true;
                    return t2.Value;
                }
            }
            foreach (KeyValuePair<String, String> t3 in b3) // clasa b3?
            {
                if (t3.Key == values[0])
                {
                    isb3 = true;
                    return t3.Value;
                }
            }*/
            return null;
        }

        public String getAddressingMode(String operand)
        {
            Dictionary<String, String> result = new Dictionary<String, String>();

            String indexedPattern = @"/[0-9]{1,3}\(R[0-9]{1,2}\)/";
            Regex indexedRegex = new Regex(indexedPattern, RegexOptions.IgnoreCase);

            String indirectPattern = @"/[0-9]{1,3}\(R[0-9]{1,2}\)/";
            Regex indirectRegex = new Regex(indirectPattern, RegexOptions.IgnoreCase);

            String directPattern = @"/[0-9]{1,3}\(R[0-9]{1,2}\)/";
            Regex directRegex = new Regex(directPattern, RegexOptions.IgnoreCase);

            String immediatPattern = @"/[0-9]{1,3}\(R[0-9]{1,2}\)/";
            Regex immediatRegex = new Regex(immediatPattern, RegexOptions.IgnoreCase);

            //indexed addressing mode?
            Match m = indexedRegex.Match(operand);
            if (m.Success)
            {
                Group gadrName = m.Groups[1];
                String adrName = gadrName.ToString();
                adrName = Regex.Replace(adrName, @"\s+", "");

                result.Add(addressingModes.First().Value, "");
                return addressingModes.First().Value;
              
            }

            return null;

             
        }

        public String getRegister(String registerName)
        {
            foreach (KeyValuePair<String, String> temp in registers)
            {
                if (temp.Key == registerName)
                {                         
                    return temp.Value;
                }
            }
            return null;
        }
    }
}
