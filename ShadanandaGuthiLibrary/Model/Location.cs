using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadanandaGuthiLibrary.Model
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationPreviousVDC { get; set; }
        public string LocationNewLevel { get; set; }

        public Location(){}

        public Location(int locationID, string locationPreviousVDC, string locationNewLevel)
        {
            this.LocationID = locationID;
            this.LocationPreviousVDC = locationPreviousVDC;
            this.LocationNewLevel = locationNewLevel;
        }

        public override string ToString()
        {
            //return $"साविक {this.LocationPreviousVDC} (हाल {this.LocationNewLevel})";
            return LocationPreviousVDC;
        }
    }
}
