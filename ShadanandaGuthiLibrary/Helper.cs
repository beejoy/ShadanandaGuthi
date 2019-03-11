using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadanandaGuthiLibrary
{
    public static class Helper
    {
        public static string GetNepaliNumber(int number)
        {
            List<string> nepaliNumbers = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", "१०", "११", "१२", "१३", "१४", "१५", "१६", "१७", "१८", "१९", "२०", "२१", "२२", "२३", "२४", "२५", "२६", "२७", "२८", "२९", "३०" };

            if (number >= 0 && number <= 30)
                return nepaliNumbers[number];
            else
                return nepaliNumbers[0];
        }
    }
}
