using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadanandaGuthiLibrary.Model
{
    public class RentYear
    {
        public int YearID { get; set; }
        public string TheRentYear { get; set; }
        public bool IsCurrentYear { get; set; }

        public RentYear() {}

        public RentYear(int yearID, string rentYear, bool isCurrentYear)
        {
            YearID = yearID;
            TheRentYear = rentYear;
            IsCurrentYear = IsCurrentYear;
        }
    }
}
