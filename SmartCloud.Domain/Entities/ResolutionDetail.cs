using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class ResolutionDetail
    {
        public Guid ResolutionDetailId { get; set; }
        public Guid? IssueManagementId { get; set; }
        public int? IssueTypeId { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string ResolutionNotes { get; set; }
        public byte[] Photo { get; set; }
        public string InvoiceId { get; set; }
        public decimal? Cost { get; set; }
        public string ErpsystemId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public byte[] LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public IssueManagement IssueManagement { get; set; }
    }
}
