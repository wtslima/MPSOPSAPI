namespace DHI.MPSOPS.DOMAIN.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Suite { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Island { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string RateChart { get; set; }
        public string SkidChart { get; set; }
        public string PieceChart { get; set; }
        public string PoundChart { get; set; }
        public bool EReciept { get; set; }
        public bool EBilling { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public double Evening { get; set; }
        public double Night { get; set; }
        public double Saturday { get; set; }
        public double Sunday { get; set; }
        public double Holliday { get; set; }
        public decimal Wagon { get; set; }
        public decimal Van { get; set; }
        public decimal Truck { get; set; }
        public decimal LiftGate { get; set; }
        public decimal Helper { get; set; }
        public string WeightStandard { get; set; }
        public string WeightCharge { get; set; }
        public string WeightTruck { get; set; }
        public double WaitChargeTimeCar { get; set; }
        public double WaitChargeTimeWagon { get; set; }
        public double WaitChargeTimeVan { get; set; }
        public double WaitChargeTimeTruck { get; set; }
        public double ExtraSkid { get; set; }
        public double Immediate { get; set; }
        public double RoundTrip { get; set; }
        public decimal InsideDel { get; set; }
        public double SkidMIlles { get; set; }
        public bool ActiveAccount { get; set; }
        public double FuelCharge { get; set; }
        public double FuelPercent { get; set; }
        public double Discount { get; set; }
        public string CodAccountType { get; set; }
        public string CodServiceLevel { get; set; }
        public int PrintTicketSp { get; set; }
        public bool SpecialPricing { get; set; }
        public bool HiGeTax { get; set; }
        public bool NoSigRequired { get; set; }
        public bool AutoEmailPod { get; set; }
        public string AutoEmailPodAddress { get; set; }
        public bool ZoneBasedPricing { get; set; }
        public bool PntInvoice { get; set; }
        public int ParentCompany { get; set; }
        public string Vehicle { get; set; }
        public bool ShowOnSpeedEntry { get; set; }
        public int Shift { get; set; }
        public bool BarCodeScanning { get; set; }
        public string CustomerInitial { get; set; }
        public int Warehouse { get; set; }

    }
}