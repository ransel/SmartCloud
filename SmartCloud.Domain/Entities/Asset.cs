using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Asset
    {
        public Asset()
        {
            AssetAttributes = new HashSet<AssetAttributes>();
            AssetBeaconRel = new HashSet<AssetBeaconRel>();
            AssetBehavior = new HashSet<AssetBehavior>();
            AssetInformationRel = new HashSet<AssetInformationRel>();
        }

        public Guid AssetId { get; set; }
        public int? AssetTypeId { get; set; }
        public bool? HasAttributes { get; set; }
        public Guid? LineOfBusinessId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public AssetType AssetType { get; set; }
        public LineOfBusiness LineOfBusiness { get; set; }
        public ICollection<AssetAttributes> AssetAttributes { get; set; }
        public ICollection<AssetBeaconRel> AssetBeaconRel { get; set; }
        public ICollection<AssetBehavior> AssetBehavior { get; set; }
        public ICollection<AssetInformationRel> AssetInformationRel { get; set; }
    }
}
