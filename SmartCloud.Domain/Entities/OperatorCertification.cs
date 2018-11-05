using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class OperatorCertification
    {
        public Guid OperaratorCertificationId { get; set; }
        public Guid? UserId { get; set; }
        public int? OperatorCertificationTypeId { get; set; }
        public string LegacyCertificationId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? RequiresWorkflow { get; set; }
        public DateTime? AlertDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }

        public OperatorCertificationType OperatorCertificationType { get; set; }
        public User User { get; set; }
    }
}
