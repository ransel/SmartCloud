using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Organization
    {
        public Organization()
        {
            LineOfBusiness = new HashSet<LineOfBusiness>();
        }

        public Guid OrganizationId { get; set; }
        public int? IndustryTypeId { get; set; }
        public Guid? SiteLocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public IndustryType IndustryType { get; set; }
        public SiteLocation SiteLocation { get; set; }
        public ICollection<LineOfBusiness> LineOfBusiness { get; set; }
    }
}
