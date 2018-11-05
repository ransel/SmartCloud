using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class InspectionProcess
    {
        public InspectionProcess()
        {
            InspectionResults = new HashSet<InspectionResults>();
            Metadata = new HashSet<Metadata>();
        }

        public Guid InspectionProcessId { get; set; }
        public Guid? AssetInspectionId { get; set; }
        public int? ProcessTypeId { get; set; }
        public bool? ProcessPassed { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? CompleteTime { get; set; }
        public int? TotalSteps { get; set; }
        public int? StepsPassed { get; set; }
        public int? MinorModerateIssues { get; set; }
        public int? MajorIssues { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public AssetInspection AssetInspection { get; set; }
        public ProcessType ProcessType { get; set; }
        public ICollection<InspectionResults> InspectionResults { get; set; }
        public ICollection<Metadata> Metadata { get; set; }
    }
}
