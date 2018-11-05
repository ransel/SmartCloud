using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class LocationType
    {
        public LocationType()
        {
            AssetBeaconRel = new HashSet<AssetBeaconRel>();
        }

        public int LocationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<AssetBeaconRel> AssetBeaconRel { get; set; }
    }
}
