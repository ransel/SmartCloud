using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class IndustryType
    {
        public IndustryType()
        {
            Organization = new HashSet<Organization>();
        }

        public int IndustryTypeId { get; set; }
        public int? IndustryGroupId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string CreateSystem { get; set; }

        public IndustryGroup IndustryGroup { get; set; }
        public ICollection<Organization> Organization { get; set; }
    }
}
