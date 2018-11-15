using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class AssetInspection
    {
        public AssetInspection()
        {
            AssetInformationRel = new HashSet<AssetInformationRel>();
            InspectionProcess = new HashSet<InspectionProcess>();
            IssueManagement = new HashSet<IssueManagement>();
        }

        public Guid AssetInspectionId { get; set; }
        public Guid? UserId { get; set; }
        public int? InspectionTypeId { get; set; }
        public bool? PrePost { get; set; }
        public bool? InspectionPassed { get; set; }
        public int? InspectionPointsMeasured { get; set; }
        public int? InspectionPointsPassed { get; set; }
        public int? InspectionKillShotsFailed { get; set; }
        public decimal? PercentagePass { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? KilometerCount { get; set; }
        public decimal? InspectionDuration { get; set; }
        public TimeSpan? InspectionStartTime { get; set; }
        public TimeSpan? InspectionStopTime { get; set; }
        public DateTime? InspectionDate { get; set; }
        public byte[] UserSignature { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public InspectionType InspectionType { get; set; }
        public ICollection<AssetInformationRel> AssetInformationRel { get; set; }
        public ICollection<InspectionProcess> InspectionProcess { get; set; }
        public ICollection<IssueManagement> IssueManagement { get; set; }
    }
}
