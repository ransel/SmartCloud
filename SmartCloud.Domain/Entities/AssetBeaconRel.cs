using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class AssetBeaconRel
    {
        public Guid AssetBeaconRelId { get; set; }
        public Guid? AssetId { get; set; }
        public Guid? BeaconId { get; set; }
        public int? LocationTypeId { get; set; }
        public DateTime? DateAttached { get; set; }
        public string AttachedBy { get; set; }
        public bool? Configured { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public Asset Asset { get; set; }
        public Beacon Beacon { get; set; }
        public LocationType LocationType { get; set; }
    }
}
