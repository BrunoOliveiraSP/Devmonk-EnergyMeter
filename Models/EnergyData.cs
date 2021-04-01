using System;
using System.Collections.Generic;

namespace api.Models
{
    public class EnergyData
    {
        public string EnergyMeterCode { get; set; }
        public DateTime MeasureDate { get; set; }
        public int Device { get; set; }
        public int KiloWatss { get; set; }
    }

    public class ClienteInfo
    {
        public int ClientCode { get; set; }
        public string ZipCode { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }

        public EnergyData[] EnergyData { get; set; }
    }
}