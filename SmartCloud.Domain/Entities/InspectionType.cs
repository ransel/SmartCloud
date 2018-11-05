using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class InspectionType
    {
        public InspectionType()
        {
            AssetInspection = new HashSet<AssetInspection>();
            CustomerInspection = new HashSet<CustomerInspection>();
            InspectionManifest = new HashSet<InspectionManifest>();
        }

        public int InspectionTypeId { get; set; }
        public string VersionNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<AssetInspection> AssetInspection { get; set; }
        public ICollection<CustomerInspection> CustomerInspection { get; set; }
        public ICollection<InspectionManifest> InspectionManifest { get; set; }
    }
}
