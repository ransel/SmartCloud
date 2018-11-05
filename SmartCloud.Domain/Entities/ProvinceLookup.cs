using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class ProvinceLookup
    {
        public ProvinceLookup()
        {
            CityLookup = new HashSet<CityLookup>();
            SiteLocation = new HashSet<SiteLocation>();
        }

        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public string ProvinceCode { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public CountryLookup Country { get; set; }
        public ICollection<CityLookup> CityLookup { get; set; }
        public ICollection<SiteLocation> SiteLocation { get; set; }
    }
}
