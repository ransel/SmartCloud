using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class CountryLookup
    {
        public CountryLookup()
        {
            ProvinceLookup = new HashSet<ProvinceLookup>();
            SiteLocation = new HashSet<SiteLocation>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ICollection<ProvinceLookup> ProvinceLookup { get; set; }
        public ICollection<SiteLocation> SiteLocation { get; set; }
    }
}
