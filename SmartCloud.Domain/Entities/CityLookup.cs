using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class CityLookup
    {
        public CityLookup()
        {
            SiteLocation = new HashSet<SiteLocation>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public int? ProvinceId { get; set; }
        public string PostalCodeArea { get; set; }
        public string MunicipalityType { get; set; }
        public string MapReference { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string CensusDivision { get; set; }
        public string AreaCode { get; set; }
        public string TimeZone { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public ProvinceLookup Province { get; set; }
        public ICollection<SiteLocation> SiteLocation { get; set; }
    }
}
