using System;

namespace DHI.MPSOPS.DOMAIN.Model
{
    public class Driver
    {
        public string DriverId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string HomePhone { get; set; }
        public string PrivatePhone { get; set; }
        public bool CDL { get; set; }
        public string CCelNum { get; set; }
        public bool Active { get; set; }
        public DateTime HireDate { get; set; }
        public string DirectConnect { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }
        public string Initial { get; set; }
        public int DrIsland { get; set; }
        public bool Updated { get; set; }
        public string Island { get; set; }
        public int Courier { get; set; }
        public decimal Wage { get; set; }
        public decimal PerOrderWage { get; set; }
        public byte Signature { get; set; }
        public bool IsVehicleUsageRequired { get; set; }

    }
}