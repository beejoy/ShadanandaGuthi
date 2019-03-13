namespace ShadanandaGuthiLibrary.Model
{
    public class LeasePayment
    {
        public int PaymentID { get; set; }
        public int LeaseID { get; set; }
        public int YearID { get; set; }
        public string LeaseRent { get; set; }
        public string PaymentDate { get; set; }
        public string ReceiptNumber { get; set; }
        public string Remarks { get; set; }
    }
}
