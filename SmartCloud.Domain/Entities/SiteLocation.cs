using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class SiteLocation
    {
        public SiteLocation()
        {
            LineOfBusiness = new HashSet<LineOfBusiness>();
            Organization = new HashSet<Organization>();
        }

        public Guid SiteLocationId { get; set; }
        public string Description { get; set; }
        public int? CityId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CountryId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string CreateSystem { get; set; }

        public CityLookup City { get; set; }
        public CountryLookup Country { get; set; }
        public ProvinceLookup Province { get; set; }
        public ICollection<LineOfBusiness> LineOfBusiness { get; set; }
        public ICollection<Organization> Organization { get; set; }
    }
}
