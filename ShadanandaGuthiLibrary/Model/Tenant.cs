namespace ShadanandaGuthiLibrary.Model
{
    public class Tenant
    {
        public int TenantID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Father { get; set; }

        public Tenant() {}

        public Tenant(int tenantID, string fullname, string address, string mobile_no, string father)
        {
            TenantID = tenantID;
            Fullname = fullname;
            Address = address;
            MobileNumber = mobile_no;
            Father = father;
        }
    }
}
