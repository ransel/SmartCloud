using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Beacon
    {
        public Beacon()
        {
            AssetBeaconRel = new HashSet<AssetBeaconRel>();
        }

        public Guid BeaconId { get; set; }
        public Guid? ManufacturerGuid { get; set; }
        public int? BeaconNumber { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DecomimissionDate { get; set; }
        public DateTime? ReOrderDate { get; set; }
        public float? Frequency { get; set; }
        public float? BatteryLevel { get; set; }
        public float? PowerSetting { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<AssetBeaconRel> AssetBeaconRel { get; set; }
    }
}
