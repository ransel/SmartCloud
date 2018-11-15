using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class InspectionResults
    {
        public Guid InspectionResultsId { get; set; }
        public Guid? InspectionProcessId { get; set; }
        public int? ActivityTypeId { get; set; }
        public int? StepTypeId { get; set; }
        public bool? HasIssue { get; set; }
        public int? SeverityTypeId { get; set; }
        public bool? IsKillShot { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Audio { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public ActivityType ActivityType { get; set; }
        public InspectionProcess InspectionProcess { get; set; }
        public SeverityType SeverityType { get; set; }
        public StepType StepType { get; set; }
    }
}
