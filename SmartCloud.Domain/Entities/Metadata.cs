using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Metadata
    {
        public Guid MetadataId { get; set; }
        public Guid? InspectionProcessId { get; set; }
        public Guid? BeaconGuid { get; set; }
        public int? BeaconNumber { get; set; }
        public float? Proximity { get; set; }
        public double? Temperature { get; set; }
        public float? Frequency { get; set; }
        public float? BatteryLevelRaw { get; set; }
        public float? PowerLevel { get; set; }
        public float? BatteryLevel { get; set; }
        public int? WeatherTypeId { get; set; }
        public bool? IsMoving { get; set; }
        public bool? DetectLight { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public InspectionProcess InspectionProcess { get; set; }
    }
}
