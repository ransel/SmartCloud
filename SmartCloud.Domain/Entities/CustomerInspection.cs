using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class CustomerInspection
    {
        public int CustomerInspectionId { get; set; }
        public int? ServiceId { get; set; }
        public int? InspectionManifestId { get; set; }
        public int? InspectionTypeId { get; set; }
        public bool? RequiresWorkFlow { get; set; }
        public DateTime? NextScheduleDate { get; set; }
        public bool? PayloadSent { get; set; }
        public decimal? VersionNumber { get; set; }
        public string CustomerPayload { get; set; }
        public bool? IsModified { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }

        public InspectionType InspectionType { get; set; }
        public Ctiotservice Service { get; set; }
    }
}
