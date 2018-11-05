using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class IssueManagement
    {
        public IssueManagement()
        {
            ResolutionDetail = new HashSet<ResolutionDetail>();
        }

        public Guid IssueManagementId { get; set; }
        public Guid? AssetInspectionId { get; set; }
        public bool? IsAssigned { get; set; }
        public int? IssueCount { get; set; }
        public Guid? MechanicId { get; set; }
        public DateTime? AssetAssignDate { get; set; }
        public DateTime? ShopReceivalDate { get; set; }
        public DateTime? ExpectedFixDate { get; set; }
        public DateTime? ActualFixDate { get; set; }
        public bool? RequiresWorkflow { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public AssetInspection AssetInspection { get; set; }
        public ICollection<ResolutionDetail> ResolutionDetail { get; set; }
    }
}
