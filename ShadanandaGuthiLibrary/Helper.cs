using System.Collections.Generic;
using System.Text;

namespace ShadanandaGuthiLibrary
{
    public static class Helper    {
        public static string GetNepaliNumber(int number)
        {
            List<string> nepaliNumbers = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", "१०", "११", "१२", "१३", "१४", "१५", "१६", "१७", "१८", "१९", "२०", "२१", "२२", "२३", "२४", "२५", "२६", "२७", "२८", "२९", "३०", "३१", "३२", "३३", "३४", "३५", "३६", "३७", "३८", "३९", "४०", "४१", "४२", "४३", "४४", "४५", "४६", "४७", "४८", "४९", "५०", "५१", "५२", "५३", "५४", "५५", "५६", "५७", "५८", "५९", "६०", "६१", "६२", "६३", "६४", "६५", "६६", "६७", "६८", "६९", "७०", "७१", "७२", "७३", "७४", "७५", "७६", "७७", "७८", "७९", "८०", "८१", "८२", "८३", "८४", "८५", "८६", "८७", "८८", "८९", "९०", "९१", "९२", "९३", "९४", "९५", "९६", "९७", "९८", "९९", "१००", "१०१", "१०२", "१०३", "१०४", "१०५", "१०६", "१०७", "१०८", "१०९", "११०", "१११", "११२", "११३", "११४", "११५", "११६", "११७", "११८", "११९", "१२०", "१२१", "१२२", "१२३", "१२४", "१२५", "१२६", "१२७", "१२८", "१२९", "१३०", "१३१", "१३२", "१३३", "१३४", "१३५", "१३६", "१३७", "१३८", "१३९", "१४०", "१४१", "१४२", "१४३", "१४४", "१४५", "१४६", "१४७", "१४८", "१४९", "१५०", "१५१", "१५२", "१५३", "१५४", "१५५", "१५६", "१५७", "१५८", "१५९", "१६०", "१६१", "१६२", "१६३", "१६४", "१६५", "१६६", "१६७", "१६८", "१६९", "१७०" };

            if (number >= 0 && number < nepaliNumbers.Count)
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
