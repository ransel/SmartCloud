using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class AssetType
    {
        public AssetType()
        {
            Asset = new HashSet<Asset>();
        }

        public int AssetTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<Asset> Asset { get; set; }
    }
}
