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
            List<string> nepaliNumbers = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", "१०", "११", "१२", "१३", "१४", "१५", "१६", "१७", "१८", "१९", "२०", "२१", "२२", "२३", "२४", "२५", "२६", "२७", "२८", "२९", "३०", "३१", "३२", "३३", "३४", "३५", "३६", "३७", "३८", "३९", "४०" };

            if (number >= 0 && number <= nepaliNumbers.Count)
                return nepaliNumbers[number];
            else
                return nepaliNumbers[0];
        }

        public static string GetNextYear(string currentYear)
        {
            string nextYear = "";

            Dictionary<string, int> dictDigits = new Dictionary<string, int>();
            dictDigits.Add("०", 0);
            dictDigits.Add("१", 1);
            dictDigits.Add("२", 2);
            dictDigits.Add("३", 3);
            dictDigits.Add("४", 4);
            dictDigits.Add("५", 5);
            dictDigits.Add("६", 6);
            dictDigits.Add("७", 7);
            dictDigits.Add("८", 8);
            dictDigits.Add("९", 9);

            StringBuilder enYearSB = new StringBuilder();
            foreach (var digit in currentYear)
            {
                enYearSB.Append(dictDigits[digit.ToString()].ToString());
            }

            int enYear = int.Parse(enYearSB.ToString());
            if (enYear > 0)
            {
                enYear++;

                StringBuilder npYearSB = new StringBuilder();
                foreach (var digit in enYear.ToString())
                {
                    npYearSB.Append(Helper.GetNepaliNumber(int.Parse(digit.ToString())));
                }

                nextYear = npYearSB.ToString();
            }
            return nextYear;
        }
    }
}
