namespace ShadanandaGuthiLibrary.Model
{
    public class LeaseLand
    {
        public int LeaseID { get; set; }
        public string LandInfo { get; set; }
        public string LeaseFrom { get; set; }
        public string AnnualRent { get; set; }
        public bool IsCurrent { get; set; }

        public LeaseLand() {}

        public LeaseLand(int leaseID, string landInfo, string leaseFrom, string annualRent, bool isCurrent)
        {
            LeaseID = leaseID;
            LandInfo = landInfo;
            LeaseFrom = LeaseFrom;
            AnnualRent = annualRent;
            IsCurrent = isCurrent;
        }
    }
}
