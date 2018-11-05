using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class InspectionManifest
    {
        public int InspectionManifestId { get; set; }
        public int? InspectionTypeId { get; set; }
        public decimal? VersionNumber { get; set; }
        public string MasterPayload { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }

        public InspectionType InspectionType { get; set; }
    }
}
