using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class IndustryGroup
    {
        public IndustryGroup()
        {
            IndustryType = new HashSet<IndustryType>();
        }

        public int IndustryGroupId { get; set; }
        public string IndustryGroupName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<IndustryType> IndustryType { get; set; }
    }
}
