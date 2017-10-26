namespace DHI.MPSOPS.DOMAIN.Model
{
    public class RouteA
    {
        public int IdRouteA { get; set; }
        public string Town { get; set; }
        public int Route { get; set; }
        public string ZipCode { get; set; }
        public string Island { get; set; }
        public string EW { get; set; }
        public int CourierId { get; set; }
        public string ZepCompany { get; set; }
        public string CityZipCompany { get; set; }
        public string DeliveryZone { get; set; }
        public string State { get; set; }
        public int MasterRoute { get; set; }
        public int SubRoute { get; set; }
    }
}