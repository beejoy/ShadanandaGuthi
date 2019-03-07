namespace ShadanandaGuthiLibrary.Model
{
    public class Land
    {
        public int LandID { get; set; }
        public Location LandLocation { get; set; }
        public string PlotNumber { get; set; }
        public string LandArea { get; set; }
        public string LandInfo => $"{PlotNumber} ({LandArea})";
        public Land() {} 

        public Land(int landID, Location landLocation, string plotNumber, string landArea)
        {
            LandID = landID;
            LandLocation = landLocation;
            PlotNumber = plotNumber;
            LandArea = landArea;
        }
    }
}
