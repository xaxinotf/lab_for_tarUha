namespace DeBiLaba2.Models
{
    public class Zaput
    {
        public int UserrrId { get; set; }

        public int OrdeId { get; set; }
        public List<int> ides { get; set; }
        public List<int> ProductsInOrders { get; set; }
        public int queryId { get; set; }
        public List<string> Names { get; set; }
        public List<string> LastNames { get; set; }
        public List<string> Dozirovka { get; set; }
        public List<string> TerminPrudatn { get; set; }
        public List<int> OrderCount { get; set; }
        public string PaymentTypeeee { get; set; }
        public List<string> DeliveryAdress { get; set; }
        public List<string> PaymentTypeName { get; set; }
        public List<string> ShipTypeName { get; set; }
        public int oid { get; set; } 
    }
}
