namespace DHI.MPSOPS.DOMAIN.Model
{
    public class Location
    {
        public int DelId { get; set; }
        public string DeliveryId { get; set; }
        public string Destination { get; set; }
        public string Address { get; set; }
        public int TownId { get; set; }
        public string Notes { get; set; }
        public string Suite { get; set; }
        public bool Active { get; set; }
    }
}