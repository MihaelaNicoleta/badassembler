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

        public List<String> getAddressingMode(String operand)
        {
            operand = operand.ToUpper();

            List<String> result = new List<String>();

            String indexedPattern = @"[0-9]{1,3}\(R[0-9]{1,2}\)";
            Regex indexedRegex = new Regex(indexedPattern, RegexOptions.IgnoreCase);

            String indirectPattern = @"\(R[0-9]{1,2}\)";
            Regex indirectRegex = new Regex(indirectPattern, RegexOptions.IgnoreCase);

            String directPattern = @"R[0-9]{1,2}";
            Regex directRegex = new Regex(directPattern, RegexOptions.IgnoreCase);

            String immediatPattern = @"[0-9]{1,3}";
            Regex immediatRegex = new Regex(immediatPattern, RegexOptions.IgnoreCase);

            //check if indexed addressing mode
            Match m = indexedRegex.Match(operand);
            if (m.Success)
            {
                String[] values = operand.Split(new char[] { '(', ')' });
                String offset = getBinaryOffset(values[0]);
                String register = getRegister(values[1]);

                String addressingMode;
                addressingModes.TryGetValue("AX", out addressingMode);
                result.Add(addressingMode);
                result.Add(register);
                result.Add(offset);
                return result;
            }
            else
            {
                m = indirectRegex.Match(operand);
                if (m.Success)
                {
                    String[] values = operand.Split(new char[] { '(', ')' });
                    String register = getRegister(values[1]);

                    String addressingMode;
                    addressingModes.TryGetValue("AI", out addressingMode);
                    result.Add(addressingMode);
                    result.Add(register);
                    return result;
                }
                else
                {
                    m = directRegex.Match(operand);
                    if (m.Success)
                    {
                        String register = getRegister(operand);
                        String addressingMode;

                        addressingModes.TryGetValue("AD", out addressingMode);
                        result.Add(addressingMode);
                        result.Add(register);
                        return result;
                    }
                    else
                    {
                        m = immediatRegex.Match(operand);
                        if (m.Success)
                        {
                            String valImm = getBinaryOffset(operand);
                            String register = "0000";
                            String addressingMode;

                            addressingModes.TryGetValue("AM", out addressingMode);
                            result.Add(addressingMode);
                            result.Add(register);
                            result.Add(valImm);
                            return result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
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

        public String getBinaryOffset(String offset)
        {
            int integerOffset = Convert.ToInt16(offset);
            var stringOffset = Convert.ToString(integerOffset, 2);

            String zeros = "0";
            for (int i = 0; i < (15 - stringOffset.Length); i++)
            {
                zeros += "0";
            }

            return zeros + stringOffset;
        }

    }
}
