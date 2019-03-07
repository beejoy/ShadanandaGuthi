namespace ShadanandaGuthiLibrary.Model
{
    public class Lease
    {
        public int LeaseID { get; set; }
        public Land LeaseLand { get; set; }
        public Tenant LeaseTenant { get; set; }
        public string LeaseFrom { get; set; }
        public string AnnualRent { get; set; }
        public string Remarks { get; set; }
        public bool IsCurrentLease { get; set; }
    }
}
